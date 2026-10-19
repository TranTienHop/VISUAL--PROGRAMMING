using System.Globalization;
using Bai_05.Models;
using Bai_05.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Bai_05;

public partial class Form1 : Form
{
    private readonly QlDatTourContext _context = new();
    private readonly TyGiaService _tyGiaService = new();

    private int? _selectedMaTour;
    private int? _selectedMaKh;
    private decimal _currentTyGia;
    private string _currentNgoaiTe = "";
    private bool _loadingTyGia;

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        dgvTour.AutoGenerateColumns = false;
        dgvKhachHang.AutoGenerateColumns = false;
        dgvDatTour.AutoGenerateColumns = false;

        if (cboNgoaiTe.Items.Count > 0)
            cboNgoaiTe.SelectedIndex = 0;

        cboDatThang.Items.Clear();
        cboDatThang.Items.Add("Tất cả tháng");
        for (int i = 1; i <= 12; i++)
            cboDatThang.Items.Add($"Tháng {i}");
        cboDatThang.SelectedIndex = 0;

        dtpNgayKhoiHanh.Value = DateTime.Today.AddDays(30);

        await LoadTourAsync();
        await LoadKhachHangAsync();
        await LoadComboDatTourAsync();
        await LoadDatTourAsync();
    }

    #region Tour

    private async Task LoadTourAsync(string? keyword = null)
    {
        try
        {
            var query = _context.Tours.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                query = query.Where(t => t.TenTour.Contains(kw) || t.DiemDen.Contains(kw));
            }

            var list = await query.OrderBy(t => t.MaTour).ToListAsync();
            dgvTour.DataSource = list.Select(t => new
            {
                t.MaTour,
                t.TenTour,
                t.DiemDen,
                NgoaiTe = t.NgoaiTe?.Trim(),
                GiaHienThi = t.GiaHienThi,
                NgayKhoiHanhText = t.NgayKhoiHanh.ToString("dd/MM/yyyy"),
                t.SoChoToiDa,
                t.GiaNgoaiTe,
                t.NgayKhoiHanh
            }).ToList();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi tải danh sách tour");
            MessageBox.Show($"Lỗi tải tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ResetTourForm()
    {
        _selectedMaTour = null;
        txtTenTour.Clear();
        txtDiemDen.Clear();
        if (cboNgoaiTe.Items.Count > 0) cboNgoaiTe.SelectedIndex = 0;
        nudGiaNgoaiTe.Value = 0;
        dtpNgayKhoiHanh.Value = DateTime.Today.AddDays(30);
        nudSoChoToiDa.Value = 20;
        dgvTour.ClearSelection();
        txtTenTour.Focus();
    }

    private bool ValidateTour()
    {
        if (string.IsNullOrWhiteSpace(txtTenTour.Text))
        {
            MessageBox.Show("Vui lòng nhập tên tour!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenTour.Focus();
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtDiemDen.Text))
        {
            MessageBox.Show("Vui lòng nhập điểm đến!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDiemDen.Focus();
            return false;
        }
        if (cboNgoaiTe.SelectedItem == null)
        {
            MessageBox.Show("Vui lòng chọn ngoại tệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (nudGiaNgoaiTe.Value <= 0)
        {
            MessageBox.Show("Giá ngoại tệ phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dgvTour.Rows[e.RowIndex];
        if (row.Cells["colTourMa"].Value == null) return;

        _selectedMaTour = Convert.ToInt32(row.Cells["colTourMa"].Value);
        txtTenTour.Text = row.Cells["colTourTen"].Value?.ToString() ?? "";
        txtDiemDen.Text = row.Cells["colTourDiemDen"].Value?.ToString() ?? "";
        string nt = row.Cells["colTourNgoaiTe"].Value?.ToString()?.Trim() ?? "USD";
        cboNgoaiTe.SelectedItem = nt;

        if (row.DataBoundItem != null)
        {
            dynamic item = row.DataBoundItem;
            nudGiaNgoaiTe.Value = item.GiaNgoaiTe;
            dtpNgayKhoiHanh.Value = ((DateOnly)item.NgayKhoiHanh).ToDateTime(TimeOnly.MinValue);
            nudSoChoToiDa.Value = item.SoChoToiDa;
        }
    }

    private async void btnTourThem_Click(object sender, EventArgs e)
    {
        if (!ValidateTour()) return;
        try
        {
            var tour = new Tour
            {
                TenTour = txtTenTour.Text.Trim(),
                DiemDen = txtDiemDen.Text.Trim(),
                NgoaiTe = cboNgoaiTe.SelectedItem!.ToString()!,
                GiaNgoaiTe = nudGiaNgoaiTe.Value,
                NgayKhoiHanh = DateOnly.FromDateTime(dtpNgayKhoiHanh.Value.Date),
                SoChoToiDa = (int)nudSoChoToiDa.Value
            };
            _context.Tours.Add(tour);
            await _context.SaveChangesAsync();
            MessageBox.Show("Thêm tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTourForm();
            await LoadTourAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi thêm tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnTourSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaTour == null)
        {
            MessageBox.Show("Vui lòng chọn tour để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!ValidateTour()) return;

        try
        {
            var tour = await _context.Tours.FindAsync(_selectedMaTour.Value);
            if (tour == null)
            {
                MessageBox.Show("Không tìm thấy tour!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tour.TenTour = txtTenTour.Text.Trim();
            tour.DiemDen = txtDiemDen.Text.Trim();
            tour.NgoaiTe = cboNgoaiTe.SelectedItem!.ToString()!;
            tour.GiaNgoaiTe = nudGiaNgoaiTe.Value;
            tour.NgayKhoiHanh = DateOnly.FromDateTime(dtpNgayKhoiHanh.Value.Date);
            tour.SoChoToiDa = (int)nudSoChoToiDa.Value;
            await _context.SaveChangesAsync();

            MessageBox.Show("Cập nhật tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTourForm();
            await LoadTourAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi sửa tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnTourXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaTour == null)
        {
            MessageBox.Show("Vui lòng chọn tour để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool coDat = await _context.DatTours.AnyAsync(d => d.MaTour == _selectedMaTour.Value);
        if (coDat)
        {
            MessageBox.Show("Tour đã có đặt chỗ, không thể xóa!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("Bạn chắc chắn muốn xóa tour này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        try
        {
            var tour = await _context.Tours.FindAsync(_selectedMaTour.Value);
            if (tour == null) return;
            _context.Tours.Remove(tour);
            await _context.SaveChangesAsync();
            MessageBox.Show("Xóa tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTourForm();
            await LoadTourAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi xóa tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnTourLamMoi_Click(object sender, EventArgs e)
    {
        ResetTourForm();
        txtTourTim.Clear();
        await LoadTourAsync();
    }

    private async void btnTourTim_Click(object sender, EventArgs e)
        => await LoadTourAsync(txtTourTim.Text);

    #endregion

    #region Khách hàng

    private async Task LoadKhachHangAsync(string? keyword = null)
    {
        try
        {
            var query = _context.KhachHangs.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                query = query.Where(k => k.HoTen.Contains(kw) || (k.SoDienThoai != null && k.SoDienThoai.Contains(kw)));
            }

            dgvKhachHang.DataSource = await query.OrderBy(k => k.MaKh).ToListAsync();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi tải khách hàng");
            MessageBox.Show($"Lỗi tải khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ResetKhForm()
    {
        _selectedMaKh = null;
        txtKhHoTen.Clear();
        txtKhSdt.Clear();
        txtKhEmail.Clear();
        dgvKhachHang.ClearSelection();
        txtKhHoTen.Focus();
    }

    private bool ValidateKh()
    {
        if (string.IsNullOrWhiteSpace(txtKhHoTen.Text))
        {
            MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtKhHoTen.Focus();
            return false;
        }
        return true;
    }

    private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvKhachHang.Rows[e.RowIndex].DataBoundItem is KhachHang kh)
        {
            _selectedMaKh = kh.MaKh;
            txtKhHoTen.Text = kh.HoTen;
            txtKhSdt.Text = kh.SoDienThoai ?? "";
            txtKhEmail.Text = kh.Email ?? "";
        }
    }

    private async void btnKhThem_Click(object sender, EventArgs e)
    {
        if (!ValidateKh()) return;
        try
        {
            _context.KhachHangs.Add(new KhachHang
            {
                HoTen = txtKhHoTen.Text.Trim(),
                SoDienThoai = txtKhSdt.Text.Trim(),
                Email = txtKhEmail.Text.Trim()
            });
            await _context.SaveChangesAsync();
            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetKhForm();
            await LoadKhachHangAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi thêm khách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnKhSua_Click(object sender, EventArgs e)
    {
        if (_selectedMaKh == null)
        {
            MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!ValidateKh()) return;

        try
        {
            var kh = await _context.KhachHangs.FindAsync(_selectedMaKh.Value);
            if (kh == null) return;
            kh.HoTen = txtKhHoTen.Text.Trim();
            kh.SoDienThoai = txtKhSdt.Text.Trim();
            kh.Email = txtKhEmail.Text.Trim();
            await _context.SaveChangesAsync();
            MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetKhForm();
            await LoadKhachHangAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi sửa khách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnKhXoa_Click(object sender, EventArgs e)
    {
        if (_selectedMaKh == null)
        {
            MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool coDat = await _context.DatTours.AnyAsync(d => d.MaKh == _selectedMaKh.Value);
        if (coDat)
        {
            MessageBox.Show("Khách đã có đặt tour, không thể xóa!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        try
        {
            var kh = await _context.KhachHangs.FindAsync(_selectedMaKh.Value);
            if (kh == null) return;
            _context.KhachHangs.Remove(kh);
            await _context.SaveChangesAsync();
            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetKhForm();
            await LoadKhachHangAsync();
            await LoadComboDatTourAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi xóa khách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnKhLamMoi_Click(object sender, EventArgs e)
    {
        ResetKhForm();
        txtKhTim.Clear();
        await LoadKhachHangAsync();
    }

    private async void btnKhTim_Click(object sender, EventArgs e)
        => await LoadKhachHangAsync(txtKhTim.Text);

    #endregion

    #region Đặt tour

    private async Task LoadComboDatTourAsync()
    {
        try
        {
            var khach = await _context.KhachHangs.AsNoTracking().OrderBy(k => k.HoTen).ToListAsync();
            cboDatKhach.DataSource = khach;
            cboDatKhach.DisplayMember = nameof(KhachHang.ThongTinHienThi);
            cboDatKhach.ValueMember = nameof(KhachHang.MaKh);

            var tours = await _context.Tours.AsNoTracking().OrderBy(t => t.TenTour).ToListAsync();
            cboDatTour.DataSource = tours;
            cboDatTour.DisplayMember = nameof(Tour.TenTour);
            cboDatTour.ValueMember = nameof(Tour.MaTour);

            if (cboDatTour.Items.Count > 0)
                await CapNhatTyGiaVaTongTienAsync();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi nạp combo đặt tour");
        }
    }

    private async Task LoadDatTourAsync(string? keyword = null, int? thangKhoiHanh = null)
    {
        try
        {
            var query = _context.DatTours
                .Include(d => d.MaKhNavigation)
                .Include(d => d.MaTourNavigation)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string kw = keyword.Trim();
                query = query.Where(d =>
                    d.MaKhNavigation.HoTen.Contains(kw) ||
                    d.MaTourNavigation.TenTour.Contains(kw));
            }

            if (thangKhoiHanh.HasValue && thangKhoiHanh.Value > 0)
            {
                int m = thangKhoiHanh.Value;
                query = query.Where(d => d.MaTourNavigation.NgayKhoiHanh.Month == m);
            }

            var list = await query.OrderByDescending(d => d.NgayDat).ToListAsync();
            var view = list.Select(d => new DatTourViewModel
            {
                MaDat = d.MaDat,
                HoTenKhach = d.MaKhNavigation?.HoTen ?? "",
                TenTour = d.MaTourNavigation?.TenTour ?? "",
                SoNguoi = d.SoNguoi,
                TyGiaHienThi = $"{d.TyGia.ToString("N4", CultureInfo.GetCultureInfo("vi-VN"))} {d.MaTourNavigation?.NgoaiTe?.Trim()}/VND",
                TongTienVnd = d.TongTienVnd,
                NgayDat = d.NgayDat,
                NgayDatHienThi = d.NgayDat.ToString("dd/MM/yyyy HH:mm"),
                NgayKhoiHanh = d.MaTourNavigation?.NgayKhoiHanh
            }).ToList();

            dgvDatTour.DataSource = view;
            decimal doanhThu = view.Sum(x => x.TongTienVnd);
            lblDoanhThu.Text = $"Tổng doanh thu: {doanhThu:N0} đ";
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi tải danh sách đặt tour");
            MessageBox.Show($"Lỗi tải đặt tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void cboDatTour_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_loadingTyGia) return;
        await CapNhatTyGiaVaTongTienAsync();
    }

    private void nudDatSoNguoi_ValueChanged(object sender, EventArgs e)
        => TinhTongTien();

    private async Task CapNhatTyGiaVaTongTienAsync()
    {
        if (cboDatTour.SelectedItem is not Tour tour)
        {
            lblGiaNguoiValue.Text = "---";
            lblTyGiaValue.Text = "---";
            lblTyGiaNguon.Text = "";
            lblTongTienValue.Text = "0 đ";
            return;
        }

        _currentNgoaiTe = tour.NgoaiTe?.Trim() ?? "";
        lblGiaNguoiValue.Text = $"{tour.GiaNgoaiTe:N0} {_currentNgoaiTe}";

        _loadingTyGia = true;
        btnDatTour.Enabled = false;
        lblTyGiaValue.Text = "Đang tải...";
        lblTyGiaNguon.Text = "";
        try
        {
            var ketQua = await _tyGiaService.LayTyGiaAsync(_currentNgoaiTe);
            if (ketQua == null)
            {
                _currentTyGia = 0;
                lblTyGiaValue.Text = "Không lấy được";
                lblTyGiaNguon.Text = "Kiểm tra mạng / appsettings.json";
                MessageBox.Show(
                    "Không lấy được tỷ giá từ API chính và dự phòng. Vui lòng kiểm tra mạng.",
                    "Lỗi tỷ giá",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                _currentTyGia = ketQua.TyGia;
                lblTyGiaValue.Text = $"1 {_currentNgoaiTe} = {_currentTyGia:N0} VND";
                lblTyGiaNguon.Text = $"Tỷ giá lấy từ: {ketQua.Host}";
                btnDatTour.Enabled = true;
            }
            TinhTongTien();
        }
        finally
        {
            _loadingTyGia = false;
            if (_currentTyGia > 0) btnDatTour.Enabled = true;
        }
    }

    private void TinhTongTien()
    {
        if (cboDatTour.SelectedItem is not Tour tour || _currentTyGia <= 0)
        {
            lblTongTienValue.Text = "0 đ";
            return;
        }

        decimal tong = tour.GiaNgoaiTe * nudDatSoNguoi.Value * _currentTyGia;
        lblTongTienValue.Text = $"{Math.Round(tong, 0):N0} đ";
    }

    private async Task<int> LaySoChoConLaiAsync(int maTour)
    {
        var tour = await _context.Tours.AsNoTracking().FirstOrDefaultAsync(t => t.MaTour == maTour);
        if (tour == null) return 0;
        int daDat = await _context.DatTours.Where(d => d.MaTour == maTour).SumAsync(d => (int?)d.SoNguoi) ?? 0;
        return tour.SoChoToiDa - daDat;
    }

    private async void btnDatTour_Click(object sender, EventArgs e)
    {
        if (cboDatKhach.SelectedValue == null || cboDatTour.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn khách hàng và tour!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_currentTyGia <= 0)
        {
            MessageBox.Show("Chưa có tỷ giá hợp lệ, không thể đặt tour!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int maKh = Convert.ToInt32(cboDatKhach.SelectedValue);
        int maTour = Convert.ToInt32(cboDatTour.SelectedValue);
        int soNguoi = (int)nudDatSoNguoi.Value;

        int conLai = await LaySoChoConLaiAsync(maTour);
        if (soNguoi > conLai)
        {
            MessageBox.Show(
                $"Số người vượt quá chỗ còn lại ({conLai}). Không thể đặt tour!",
                "Hết chỗ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (cboDatTour.SelectedItem is not Tour tour) return;

        decimal tongTien = Math.Round(tour.GiaNgoaiTe * soNguoi * _currentTyGia, 0);

        try
        {
            var dat = new DatTour
            {
                MaKh = maKh,
                MaTour = maTour,
                SoNguoi = soNguoi,
                NgayDat = DateTime.Now,
                TyGia = _currentTyGia,
                TongTienVnd = tongTien
            };
            _context.DatTours.Add(dat);
            await _context.SaveChangesAsync();

            MessageBox.Show(
                $"Đặt tour thành công!\nTổng tiền: {tongTien:N0} đ\nTỷ giá lưu: {_currentTyGia:N4}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            nudDatSoNguoi.Value = 1;
            await LoadDatTourAsync();
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Lỗi đặt tour");
            MessageBox.Show($"Lỗi đặt tour: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDatTim_Click(object sender, EventArgs e)
    {
        int? thang = null;
        if (cboDatThang.SelectedIndex > 0)
            thang = cboDatThang.SelectedIndex;
        await LoadDatTourAsync(txtDatTim.Text, thang);
    }

    private async void btnDatBoLoc_Click(object sender, EventArgs e)
    {
        txtDatTim.Clear();
        cboDatThang.SelectedIndex = 0;
        await LoadDatTourAsync();
    }

    #endregion

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _context.Dispose();
        Log.CloseAndFlush();
    }
}
