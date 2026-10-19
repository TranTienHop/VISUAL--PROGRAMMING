using System.Net.Http;
using System.Text.Json;
using Bai_02.Models;
using Bai_02.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Bai_02;

public partial class FormKhachThue : Form
{
    private const string TrangThaiTrong = "Trống";
    private const string TrangThaiDangThue = "Đang thuê";

    private readonly QlNhaTroContext _context = new();
    private readonly DiaChiService _diaChiService = new();

    private int? _selectedMaKhach;
    private bool _loadingTinh;
    private bool _apiTinhOk;
    private bool _choPhepNhapPhuongThuCong;

    public FormKhachThue()
    {
        InitializeComponent();
    }

    private async void FormKhachThue_Load(object sender, EventArgs e)
    {
        dgvKhach.AutoGenerateColumns = false;
        dtpNgaySinh.Value = new DateTime(2004, 5, 12);

        await LoadPhongComboAsync();
        await LoadDanhSachKhachAsync();
        await LoadTinhThanhAsync();
    }

    #region Load dữ liệu

    private async Task LoadPhongComboAsync(int? keepMaPhong = null)
    {
        var phong = await _context.PhongTros.AsNoTracking().OrderBy(p => p.TenPhong).ToListAsync();

        cboPhong.DataSource = phong.ToList();
        cboPhong.DisplayMember = nameof(PhongTro.ThongTinHienThi);
        cboPhong.ValueMember = nameof(PhongTro.MaPhong);
        if (keepMaPhong.HasValue)
            cboPhong.SelectedValue = keepMaPhong.Value;
        else if (cboPhong.Items.Count > 0)
            cboPhong.SelectedIndex = 0;

        var locPhong = new List<object> { new { MaPhong = 0, ThongTinHienThi = "Tất cả phòng" } };
        locPhong.AddRange(phong.Select(p => new { p.MaPhong, p.ThongTinHienThi }));
        cboLocPhong.DataSource = locPhong;
        cboLocPhong.DisplayMember = "ThongTinHienThi";
        cboLocPhong.ValueMember = "MaPhong";
        cboLocPhong.SelectedIndex = 0;
    }

    private async Task LoadDanhSachKhachAsync(string? keyword = null, int? maPhong = null, int? maTinh = null)
    {
        try
        {
            var query = _context.KhachThues
                .Include(k => k.MaPhongNavigation)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                query = query.Where(k =>
                    k.HoTen.Contains(kw) ||
                    (k.SoDienThoai != null && k.SoDienThoai.Contains(kw)));
            }

            if (maPhong.HasValue && maPhong.Value > 0)
                query = query.Where(k => k.MaPhong == maPhong.Value);

            if (maTinh.HasValue && maTinh.Value > 0)
                query = query.Where(k => k.MaTinh == maTinh.Value);

            var list = await query.OrderBy(k => k.MaKhach).ToListAsync();
            dgvKhach.DataSource = list.Select(k => new KhachThueViewModel
            {
                MaKhach = k.MaKhach,
                HoTen = k.HoTen,
                SoDienThoai = k.SoDienThoai ?? "",
                TenPhong = k.MaPhongNavigation?.TenPhong ?? "",
                GiaThue = k.MaPhongNavigation?.GiaThue ?? 0,
                QueQuan = FormatQueQuan(k.TenPhuongXa, k.TenTinh),
                DaDangKyTamTru = k.DaDangKyTamTru,
                GioiTinh = k.GioiTinh,
                NgaySinh = k.NgaySinh,
                MaPhong = k.MaPhong,
                MaTinh = k.MaTinh,
                TenTinh = k.TenTinh,
                MaPhuongXa = k.MaPhuongXa,
                TenPhuongXa = k.TenPhuongXa
            }).ToList();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi tải danh sách khách thuê");
            MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static string FormatQueQuan(string? phuong, string? tinh)
    {
        if (string.IsNullOrWhiteSpace(phuong) && string.IsNullOrWhiteSpace(tinh))
            return "";
        if (string.IsNullOrWhiteSpace(phuong))
            return tinh ?? "";
        if (string.IsNullOrWhiteSpace(tinh))
            return phuong ?? "";
        return $"{phuong} – {tinh}";
    }

    private async Task LoadTinhThanhAsync()
    {
        _loadingTinh = true;
        cboTinh.Enabled = false;
        cboTinh.DataSource = null;
        cboTinh.Items.Clear();
        cboTinh.Items.Add("Đang tải...");
        cboTinh.SelectedIndex = 0;
        lblStatus.Text = "Đang tải tỉnh/thành từ provinces.open-api.vn...";

        try
        {
            var provinces = await _diaChiService.LayDanhSachTinhAsync();
            _apiTinhOk = true;

            cboTinh.DataSource = provinces;
            cboTinh.DisplayMember = "Name";
            cboTinh.ValueMember = "Code";

            var locTinh = new List<object> { new { Code = 0, Name = "Tất cả tỉnh/thành" } };
            locTinh.AddRange(provinces.Select(p => new { p.Code, p.Name }));
            cboLocTinh.DataSource = locTinh;
            cboLocTinh.DisplayMember = "Name";
            cboLocTinh.ValueMember = "Code";
            cboLocTinh.SelectedIndex = 0;

            lblStatus.Text = $"Đã tải {provinces.Count} tỉnh/thành từ provinces.open-api.vn";
            cboTinh.Enabled = true;
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or JsonException)
        {
            DiaChiService.LogNetworkError(ex);
            _apiTinhOk = false;
            EnableManualAddressEntry();
            MessageBox.Show(
                "Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng",
                "Lỗi mạng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            lblStatus.Text = "Không tải được địa chỉ – có thể nhập thủ công Phường/Xã";
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Lỗi tải tỉnh/thành");
            _apiTinhOk = false;
            EnableManualAddressEntry();
            MessageBox.Show(
                "Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng",
                "Lỗi mạng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            lblStatus.Text = "Không tải được địa chỉ – có thể nhập thủ công Phường/Xã";
        }
        finally
        {
            _loadingTinh = false;
        }
    }

    private void EnableManualAddressEntry()
    {
        _choPhepNhapPhuongThuCong = true;
        cboTinh.DropDownStyle = ComboBoxStyle.DropDown;
        cboTinh.Enabled = true;
        cboTinh.DataSource = null;
        cboTinh.Items.Clear();

        cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
        cboPhuongXa.Enabled = true;
        cboPhuongXa.DataSource = null;
        cboPhuongXa.Items.Clear();

        cboLocTinh.DataSource = null;
        cboLocTinh.Items.Clear();
        cboLocTinh.Items.Add("Tất cả tỉnh/thành");
        cboLocTinh.SelectedIndex = 0;
    }

    private async Task LoadPhuongXaAsync(int maTinh)
    {
        cboPhuongXa.Enabled = false;
        cboPhuongXa.DataSource = null;
        cboPhuongXa.Items.Clear();
        cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPhuongXa.Items.Add("Đang tải...");
        cboPhuongXa.SelectedIndex = 0;

        try
        {
            var wards = await _diaChiService.LayDanhSachPhuongXaAsync(maTinh);
            cboPhuongXa.DataSource = wards;
            cboPhuongXa.DisplayMember = "Name";
            cboPhuongXa.ValueMember = "Code";
            cboPhuongXa.Enabled = true;
            _choPhepNhapPhuongThuCong = false;
        }
        catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException)
        {
            DiaChiService.LogNetworkError(ex);
            MessageBox.Show(
                "Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng",
                "Lỗi mạng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            _choPhepNhapPhuongThuCong = true;
            cboPhuongXa.Items.Clear();
            cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
            cboPhuongXa.Enabled = true;
        }
    }

    #endregion

    #region Form helpers

    private void ResetForm()
    {
        _selectedMaKhach = null;
        txtHoTen.Clear();
        rdoNam.Checked = true;
        dtpNgaySinh.Value = new DateTime(2004, 5, 12);
        txtSdt.Clear();
        chkTamTru.Checked = false;
        if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
        if (_apiTinhOk && cboTinh.Items.Count > 0) cboTinh.SelectedIndex = 0;
        else if (!_apiTinhOk) { cboTinh.Text = ""; cboPhuongXa.Text = ""; }
        dgvKhach.ClearSelection();
        txtHoTen.Focus();
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return false;
        }
        if (cboPhong.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void FillDiaChi(KhachThue entity)
    {
        if (_apiTinhOk && cboTinh.SelectedItem is ProvinceDto tinh)
        {
            entity.MaTinh = tinh.Code;
            entity.TenTinh = tinh.Name;
        }
        else if (!string.IsNullOrWhiteSpace(cboTinh.Text))
        {
            entity.MaTinh = null;
            entity.TenTinh = cboTinh.Text.Trim();
        }
        else
        {
            entity.MaTinh = null;
            entity.TenTinh = null;
        }

        if (!_choPhepNhapPhuongThuCong && cboPhuongXa.SelectedItem is WardDto xa)
        {
            entity.MaPhuongXa = xa.Code;
            entity.TenPhuongXa = xa.Name;
        }
        else if (!string.IsNullOrWhiteSpace(cboPhuongXa.Text) && cboPhuongXa.Text != "Đang tải...")
        {
            entity.MaPhuongXa = null;
            entity.TenPhuongXa = cboPhuongXa.Text.Trim();
        }
        else
        {
            entity.MaPhuongXa = null;
            entity.TenPhuongXa = null;
        }
    }

    private async Task CapNhatTinhTrangPhongAsync(int maPhong)
    {
        var phong = await _context.PhongTros.FindAsync(maPhong);
        if (phong == null) return;

        bool conKhach = await _context.KhachThues.AnyAsync(k => k.MaPhong == maPhong);
        phong.TinhTrang = conKhach ? TrangThaiDangThue : TrangThaiTrong;
        await _context.SaveChangesAsync();
    }

    #endregion

    #region Events

    private async void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_loadingTinh || !_apiTinhOk) return;
        if (cboTinh.SelectedValue is int code)
            await LoadPhuongXaAsync(code);
        else if (cboTinh.SelectedItem is ProvinceDto p)
            await LoadPhuongXaAsync(p.Code);
    }

    private async void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvKhach.Rows[e.RowIndex].DataBoundItem is not KhachThueViewModel item) return;

        _selectedMaKhach = item.MaKhach;
        txtHoTen.Text = item.HoTen;
        if (item.GioiTinh == "Nữ") rdoNu.Checked = true; else rdoNam.Checked = true;
        dtpNgaySinh.Value = item.NgaySinh.ToDateTime(TimeOnly.MinValue);
        txtSdt.Text = item.SoDienThoai;
        chkTamTru.Checked = item.DaDangKyTamTru;
        cboPhong.SelectedValue = item.MaPhong;

        if (_apiTinhOk && item.MaTinh.HasValue)
        {
            cboTinh.SelectedValue = item.MaTinh.Value;
            // chờ phường load xong rồi chọn
            await Task.Delay(50);
            if (item.MaPhuongXa.HasValue && !_choPhepNhapPhuongThuCong)
            {
                try { cboPhuongXa.SelectedValue = item.MaPhuongXa.Value; }
                catch { /* ward code cũ có thể không còn */ }
            }
            else if (!string.IsNullOrWhiteSpace(item.TenPhuongXa))
            {
                cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
                cboPhuongXa.Text = item.TenPhuongXa;
            }
        }
        else
        {
            cboTinh.Text = item.TenTinh ?? "";
            cboPhuongXa.Text = item.TenPhuongXa ?? "";
        }
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;
        try
        {
            int maPhong = Convert.ToInt32(cboPhong.SelectedValue);
            var khach = new KhachThue
            {
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = rdoNu.Checked ? "Nữ" : "Nam",
                NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date),
                SoDienThoai = txtSdt.Text.Trim(),
                DaDangKyTamTru = chkTamTru.Checked,
                MaPhong = maPhong
            };
            FillDiaChi(khach);

            _context.KhachThues.Add(khach);
            await _context.SaveChangesAsync();
            await CapNhatTinhTrangPhongAsync(maPhong);

            MessageBox.Show("Thêm khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            await LoadPhongComboAsync();
            await LoadDanhSachKhachAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaKhach == null)
        {
            MessageBox.Show("Vui lòng chọn khách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!ValidateInput()) return;

        try
        {
            var khach = await _context.KhachThues.FindAsync(_selectedMaKhach.Value);
            if (khach == null) return;

            int maPhongCu = khach.MaPhong;
            int maPhongMoi = Convert.ToInt32(cboPhong.SelectedValue);

            khach.HoTen = txtHoTen.Text.Trim();
            khach.GioiTinh = rdoNu.Checked ? "Nữ" : "Nam";
            khach.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date);
            khach.SoDienThoai = txtSdt.Text.Trim();
            khach.DaDangKyTamTru = chkTamTru.Checked;
            khach.MaPhong = maPhongMoi;
            FillDiaChi(khach);

            await _context.SaveChangesAsync();
            await CapNhatTinhTrangPhongAsync(maPhongCu);
            if (maPhongCu != maPhongMoi)
                await CapNhatTinhTrangPhongAsync(maPhongMoi);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            await LoadPhongComboAsync();
            await LoadDanhSachKhachAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaKhach == null)
        {
            MessageBox.Show("Vui lòng chọn khách để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var khach = await _context.KhachThues.FindAsync(_selectedMaKhach.Value);
        if (khach == null) return;

        if (MessageBox.Show($"Xóa khách \"{khach.HoTen}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        try
        {
            int maPhong = khach.MaPhong;
            _context.KhachThues.Remove(khach);
            await _context.SaveChangesAsync();
            await CapNhatTinhTrangPhongAsync(maPhong);

            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            await LoadPhongComboAsync();
            await LoadDanhSachKhachAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        ResetForm();
        await LoadDanhSachKhachAsync();
    }

    private async void btnTim_Click(object sender, EventArgs e)
    {
        int? maPhong = null;
        int? maTinh = null;
        if (cboLocPhong.SelectedValue is int mp && mp > 0) maPhong = mp;
        if (cboLocTinh.SelectedValue is int mt && mt > 0) maTinh = mt;
        await LoadDanhSachKhachAsync(txtTim.Text, maPhong, maTinh);
    }

    private async void btnBoLoc_Click(object sender, EventArgs e)
    {
        txtTim.Clear();
        if (cboLocPhong.Items.Count > 0) cboLocPhong.SelectedIndex = 0;
        if (cboLocTinh.Items.Count > 0) cboLocTinh.SelectedIndex = 0;
        await LoadDanhSachKhachAsync();
    }

    private void btnGayLoi_Click(object sender, EventArgs e)
    {
        throw new InvalidOperationException("Đây là lỗi thử nghiệm (Gây lỗi thử).");
    }

    #endregion

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context.Dispose();
        Log.CloseAndFlush();
    }
}
