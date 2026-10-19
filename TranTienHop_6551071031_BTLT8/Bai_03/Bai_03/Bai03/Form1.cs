using System.Diagnostics;
using System.Drawing.Printing;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Bai03.Data;
using Bai03.Models;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer _searchTimer;
        private readonly PhieuDiemPrinter _printer = new();
        private string? _selectedMaSV;
        private int? _selectedMaDiem;
        private bool _isBinding;
        private List<Lop> _lopList = new();

        private sealed class SinhVienRow
        {
            public string MaSV { get; set; } = "";
            public string HoTen { get; set; } = "";
            public DateTime NgaySinh { get; set; }
            public string GioiTinh { get; set; } = "";
            public string MaLop { get; set; } = "";
            public string TenLop { get; set; } = "";
        }

        private sealed class DiemRow
        {
            public int MaDiem { get; set; }
            public int STT { get; set; }
            public string TenMon { get; set; } = "";
            public int SoTinChi { get; set; }
            public decimal Diem { get; set; }
        }

        private sealed class LopListItem
        {
            public string MaLop { get; set; } = "";
            public string Display { get; set; } = "";
            public override string ToString() => Display;
        }

        public Form1()
        {
            InitializeComponent();

            _searchTimer = new System.Windows.Forms.Timer { Interval = 350 };
            _searchTimer.Tick += SearchTimer_Tick;

            Load += Form1_Load;
            lstLop.SelectedIndexChanged += LstLop_SelectedIndexChanged;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;

            dgvSinhVien.CellClick += DgvSinhVien_CellClick;
            dgvSinhVien.SelectionChanged += DgvSinhVien_SelectionChanged;
            dgvDiem.CellClick += DgvDiem_CellClick;
            dgvDiem.SelectionChanged += DgvDiem_SelectionChanged;

            btnThemSV.Click += BtnThemSV_Click;
            btnSuaSV.Click += BtnSuaSV_Click;
            btnXoaSV.Click += BtnXoaSV_Click;

            btnThemMon.Click += BtnThemMon_Click;
            btnSuaDiem.Click += BtnSuaDiem_Click;
            btnXoaMon.Click += BtnXoaMon_Click;

            btnXemTruoc.Click += BtnXemTruoc_Click;
            btnIn.Click += BtnIn_Click;
            btnCaiDatTrang.Click += BtnCaiDatTrang_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        #region Load / Filter

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                dgvSinhVien.AutoGenerateColumns = false;
                dgvDiem.AutoGenerateColumns = false;
                await LoadLopAsync();
                await FilterSinhVienAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi động: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadLopAsync()
        {
            using var db = new QuanLyDiemContext();
            _lopList = await db.Lops.AsNoTracking().OrderBy(l => l.MaLop).ToListAsync();

            lstLop.Items.Clear();
            lstLop.Items.Add(new LopListItem { MaLop = "", Display = "Tất cả" });
            foreach (var lop in _lopList)
            {
                lstLop.Items.Add(new LopListItem
                {
                    MaLop = lop.MaLop,
                    Display = $"{lop.MaLop} - {lop.TenLop}"
                });
            }
            lstLop.SelectedIndex = 0;

            cboLop.DataSource = null;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = _lopList.ToList();
        }

        private string GetSelectedMaLopFilter()
        {
            if (lstLop.SelectedItem is LopListItem item)
                return item.MaLop;
            return "";
        }

        private async Task FilterSinhVienAsync()
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                string maLop = GetSelectedMaLopFilter();

                using var db = new QuanLyDiemContext();
                var query = db.SinhViens.AsNoTracking()
                    .Include(s => s.MaLopNavigation)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(maLop))
                    query = query.Where(s => s.MaLop == maLop);

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    string kw = keyword.ToLower();
                    query = query.Where(s =>
                        s.MaSV.ToLower().Contains(kw) ||
                        s.HoTen.ToLower().Contains(kw));
                }

                var list = await query.OrderBy(s => s.MaSV).ToListAsync();
                var rows = list.Select(s => new SinhVienRow
                {
                    MaSV = s.MaSV,
                    HoTen = s.HoTen,
                    NgaySinh = s.NgaySinh,
                    GioiTinh = s.GioiTinh,
                    MaLop = s.MaLop,
                    TenLop = s.MaLopNavigation.TenLop
                }).ToList();

                _isBinding = true;
                dgvSinhVien.DataSource = rows;
                _isBinding = false;

                if (rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(_selectedMaSV) && rows.Any(r => r.MaSV == _selectedMaSV))
                    {
                        SelectSinhVienRow(_selectedMaSV);
                    }
                    else
                    {
                        FillSinhVienFromRow(rows[0]);
                        await LoadDiemAsync(rows[0].MaSV);
                    }
                }
                else
                {
                    ResetSinhVienControls();
                    ClearDiem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách SV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectSinhVienRow(string maSV)
        {
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.DataBoundItem is SinhVienRow r && r.MaSV == maSV)
                {
                    row.Selected = true;
                    dgvSinhVien.CurrentCell = row.Cells[0];
                    FillSinhVienFromRow(r);
                    _ = LoadDiemAsync(maSV);
                    break;
                }
            }
        }

        private async void LstLop_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            await FilterSinhVienAsync();
        }

        private void TxtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private async void SearchTimer_Tick(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            await FilterSinhVienAsync();
        }

        #endregion

        #region Sinh vien selection / CRUD

        private void DgvSinhVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVienRow row)
            {
                FillSinhVienFromRow(row);
                _ = LoadDiemAsync(row.MaSV);
            }
        }

        private void DgvSinhVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvSinhVien.CurrentRow?.DataBoundItem is SinhVienRow row)
            {
                FillSinhVienFromRow(row);
                _ = LoadDiemAsync(row.MaSV);
            }
        }

        private void FillSinhVienFromRow(SinhVienRow row)
        {
            _selectedMaSV = row.MaSV;
            txtMaSV.Text = row.MaSV;
            txtHoTen.Text = row.HoTen;
            dtpNgaySinh.Value = row.NgaySinh;
            if (string.Equals(row.GioiTinh, "Nữ", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(row.GioiTinh, "Nu", StringComparison.OrdinalIgnoreCase))
                rdoNu.Checked = true;
            else
                rdoNam.Checked = true;

            if (cboLop.DataSource != null)
                cboLop.SelectedValue = row.MaLop;
        }

        private void ResetSinhVienControls()
        {
            _selectedMaSV = null;
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = new DateTime(2005, 1, 1);
            rdoNam.Checked = true;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        private async void BtnThemSV_Click(object? sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                if (string.IsNullOrWhiteSpace(maSV))
                {
                    MessageBox.Show("MSSV không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboLop.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new QuanLyDiemContext();
                if (await db.SinhViens.AnyAsync(s => s.MaSV == maSV))
                {
                    MessageBox.Show($"MSSV '{maSV}' đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sv = new SinhVien
                {
                    MaSV = maSV,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = rdoNu.Checked ? "Nữ" : "Nam",
                    MaLop = cboLop.SelectedValue.ToString()!
                };
                await db.SinhViens.AddAsync(sv);
                await db.SaveChangesAsync();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _selectedMaSV = maSV;
                await FilterSinhVienAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm SV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSuaSV_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedMaSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string newMaSV = txtMaSV.Text.Trim();
                if (string.IsNullOrWhiteSpace(newMaSV))
                {
                    MessageBox.Show("MSSV không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || cboLop.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new QuanLyDiemContext();
                var sv = await db.SinhViens.FindAsync(_selectedMaSV);
                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.Equals(newMaSV, _selectedMaSV, StringComparison.OrdinalIgnoreCase)
                    && await db.SinhViens.AnyAsync(s => s.MaSV == newMaSV))
                {
                    MessageBox.Show($"MSSV '{newMaSV}' đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Neu doi MaSV: cap nhat DiemMon truoc
                if (!string.Equals(newMaSV, _selectedMaSV, StringComparison.Ordinal))
                {
                    var diems = await db.DiemMons.Where(d => d.MaSV == _selectedMaSV).ToListAsync();
                    db.SinhViens.Remove(sv);
                    await db.SaveChangesAsync();

                    var newSv = new SinhVien
                    {
                        MaSV = newMaSV,
                        HoTen = txtHoTen.Text.Trim(),
                        NgaySinh = dtpNgaySinh.Value.Date,
                        GioiTinh = rdoNu.Checked ? "Nữ" : "Nam",
                        MaLop = cboLop.SelectedValue.ToString()!
                    };
                    await db.SinhViens.AddAsync(newSv);
                    await db.SaveChangesAsync();

                    foreach (var d in diems)
                    {
                        await db.DiemMons.AddAsync(new DiemMon
                        {
                            MaSV = newMaSV,
                            TenMon = d.TenMon,
                            SoTinChi = d.SoTinChi,
                            Diem = d.Diem
                        });
                    }
                    await db.SaveChangesAsync();
                    _selectedMaSV = newMaSV;
                }
                else
                {
                    sv.HoTen = txtHoTen.Text.Trim();
                    sv.NgaySinh = dtpNgaySinh.Value.Date;
                    sv.GioiTinh = rdoNu.Checked ? "Nữ" : "Nam";
                    sv.MaLop = cboLop.SelectedValue.ToString()!;
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterSinhVienAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi sửa SV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoaSV_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedMaSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Xóa sinh viên '{_selectedMaSV}' sẽ xóa toàn bộ điểm môn liên quan. Tiếp tục?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                using var db = new QuanLyDiemContext();
                var diems = await db.DiemMons.Where(d => d.MaSV == _selectedMaSV).ToListAsync();
                if (diems.Count > 0)
                    db.DiemMons.RemoveRange(diems);

                var sv = await db.SinhViens.FindAsync(_selectedMaSV);
                if (sv != null)
                    db.SinhViens.Remove(sv);

                await db.SaveChangesAsync();
                MessageBox.Show("Đã xóa sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _selectedMaSV = null;
                await FilterSinhVienAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa SV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Diem mon

        private async Task LoadDiemAsync(string maSV)
        {
            try
            {
                using var db = new QuanLyDiemContext();
                var list = await db.DiemMons.AsNoTracking()
                    .Where(d => d.MaSV == maSV)
                    .OrderBy(d => d.MaDiem)
                    .ToListAsync();

                var rows = list.Select((d, i) => new DiemRow
                {
                    MaDiem = d.MaDiem,
                    STT = i + 1,
                    TenMon = d.TenMon,
                    SoTinChi = d.SoTinChi,
                    Diem = d.Diem
                }).ToList();

                _isBinding = true;
                dgvDiem.DataSource = rows;
                _isBinding = false;
                _selectedMaDiem = null;
                txtTenMon.Clear();
                nudTinChi.Value = 3;
                nudDiem.Value = 0;

                UpdateTongKet(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDiem()
        {
            dgvDiem.DataSource = null;
            _selectedMaDiem = null;
            txtTenMon.Clear();
            nudTinChi.Value = 3;
            nudDiem.Value = 0;
            lblTongTinChi.Text = "Tổng tín chỉ: 0";
            lblDiemTB.Text = "Điểm TB: 0.00";
            lblXepLoai.Text = "Xếp loại: Chưa có điểm";
        }

        public static (decimal diemTB, int tongTC, string xepLoai) TinhTongKet(IEnumerable<DiemMon> diems)
        {
            var list = diems.ToList();
            if (list.Count == 0)
                return (0m, 0, "Chưa có điểm");

            int tongTC = list.Sum(d => d.SoTinChi);
            decimal diemTB = Math.Round(list.Sum(d => d.Diem * d.SoTinChi) / tongTC, 2);

            string xepLoai;
            if (diemTB >= 8m) xepLoai = "Giỏi";
            else if (diemTB >= 7m) xepLoai = "Khá";
            else if (diemTB >= 5m) xepLoai = "TB";
            else xepLoai = "Yếu";

            return (diemTB, tongTC, xepLoai);
        }

        private void UpdateTongKet(List<DiemMon> list)
        {
            var (tb, tc, xl) = TinhTongKet(list);
            lblTongTinChi.Text = $"Tổng tín chỉ: {tc}";
            lblDiemTB.Text = $"Điểm TB: {tb:0.00}";
            lblXepLoai.Text = $"Xếp loại: {xl}";
        }

        private void DgvDiem_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDiem.Rows[e.RowIndex].DataBoundItem is DiemRow row)
                FillDiemFromRow(row);
        }

        private void DgvDiem_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvDiem.CurrentRow?.DataBoundItem is DiemRow row)
                FillDiemFromRow(row);
        }

        private void FillDiemFromRow(DiemRow row)
        {
            _selectedMaDiem = row.MaDiem;
            txtTenMon.Text = row.TenMon;
            nudTinChi.Value = Math.Clamp(row.SoTinChi, 1, 6);
            nudDiem.Value = Math.Clamp(row.Diem, 0, 10);
        }

        private async void BtnThemMon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedMaSV))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTenMon.Text))
                {
                    MessageBox.Show("Tên môn không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new QuanLyDiemContext();
                var diem = new DiemMon
                {
                    MaSV = _selectedMaSV,
                    TenMon = txtTenMon.Text.Trim(),
                    SoTinChi = (int)nudTinChi.Value,
                    Diem = nudDiem.Value
                };
                await db.DiemMons.AddAsync(diem);
                await db.SaveChangesAsync();
                MessageBox.Show("Thêm môn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDiemAsync(_selectedMaSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm môn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSuaDiem_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaDiem.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn môn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTenMon.Text))
                {
                    MessageBox.Show("Tên môn không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var db = new QuanLyDiemContext();
                var diem = await db.DiemMons.FindAsync(_selectedMaDiem.Value);
                if (diem == null)
                {
                    MessageBox.Show("Không tìm thấy môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                diem.TenMon = txtTenMon.Text.Trim();
                diem.SoTinChi = (int)nudTinChi.Value;
                diem.Diem = nudDiem.Value;
                await db.SaveChangesAsync();

                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!string.IsNullOrEmpty(_selectedMaSV))
                    await LoadDiemAsync(_selectedMaSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi sửa điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoaMon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaDiem.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn môn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa môn này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                using var db = new QuanLyDiemContext();
                var diem = await db.DiemMons.FindAsync(_selectedMaDiem.Value);
                if (diem != null)
                {
                    db.DiemMons.Remove(diem);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Đã xóa môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!string.IsNullOrEmpty(_selectedMaSV))
                    await LoadDiemAsync(_selectedMaSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa môn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region In / Excel

        private async Task<(SinhVien? sv, List<DiemMon> diems, decimal tb, int tc, string xl)?> GetPhieuDataAsync()
        {
            if (string.IsNullOrEmpty(_selectedMaSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            using var db = new QuanLyDiemContext();
            var sv = await db.SinhViens.AsNoTracking()
                .Include(s => s.MaLopNavigation)
                .FirstOrDefaultAsync(s => s.MaSV == _selectedMaSV);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var diems = await db.DiemMons.AsNoTracking()
                .Where(d => d.MaSV == _selectedMaSV)
                .OrderBy(d => d.MaDiem)
                .ToListAsync();

            if (diems.Count == 0)
            {
                MessageBox.Show("Sinh viên chưa có điểm để in phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var (tb, tc, xl) = TinhTongKet(diems);
            return (sv, diems, tb, tc, xl);
        }

        private async void BtnXemTruoc_Click(object? sender, EventArgs e)
        {
            try
            {
                var data = await GetPhieuDataAsync();
                if (data == null || data.Value.sv == null) return;

                _printer.SetData(data.Value.sv, data.Value.diems, data.Value.tb, data.Value.tc, data.Value.xl);
                _printer.ShowPreview(this);
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show($"Lỗi máy in: {ex.Message}", "Lỗi in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xem trước: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnIn_Click(object? sender, EventArgs e)
        {
            try
            {
                var data = await GetPhieuDataAsync();
                if (data == null || data.Value.sv == null) return;

                _printer.SetData(data.Value.sv, data.Value.diems, data.Value.tb, data.Value.tc, data.Value.xl);
                _printer.ShowPrintDialog(this);
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show($"Lỗi máy in: {ex.Message}", "Lỗi in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi in: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCaiDatTrang_Click(object? sender, EventArgs e)
        {
            try
            {
                _printer.ShowPageSetup(this);
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show($"Lỗi máy in: {ex.Message}", "Lỗi in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cài đặt trang: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXuatExcel_Click(object? sender, EventArgs e)
        {
            try
            {
                string maLop = GetSelectedMaLopFilter();
                if (string.IsNullOrEmpty(maLop))
                {
                    // Neu chon "Tat ca", uu tien lop cua SV dang chon
                    if (!string.IsNullOrEmpty(_selectedMaSV) && dgvSinhVien.CurrentRow?.DataBoundItem is SinhVienRow row)
                        maLop = row.MaLop;

                    if (string.IsNullOrEmpty(maLop))
                    {
                        MessageBox.Show("Vui lòng chọn một lớp cụ thể trên ListBox để xuất Excel!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using var db = new QuanLyDiemContext();
                var data = await (
                    from d in db.DiemMons.AsNoTracking()
                    join s in db.SinhViens.AsNoTracking() on d.MaSV equals s.MaSV
                    join l in db.Lops.AsNoTracking() on s.MaLop equals l.MaLop
                    where s.MaLop == maLop
                    orderby s.MaSV, d.MaDiem
                    select new
                    {
                        s.MaSV,
                        s.HoTen,
                        Lop = l.TenLop,
                        d.TenMon,
                        d.SoTinChi,
                        d.Diem
                    }).ToListAsync();

                if (data.Count == 0)
                {
                    MessageBox.Show("Lớp không có dữ liệu điểm để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"DiemLop_{maLop}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                    Title = "Xuất Excel điểm lớp"
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                using var workbook = new XLWorkbook();
                var ws = workbook.Worksheets.Add("DiemLop");

                string[] headers = { "MSSV", "Họ tên", "Lớp", "Môn", "TC", "Điểm" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = ws.Cell(1, i + 1);
                    cell.Value = headers[i];
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor = XLColor.FromArgb(217, 234, 211);
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }

                int rowIdx = 2;
                foreach (var item in data)
                {
                    ws.Cell(rowIdx, 1).Value = item.MaSV;
                    ws.Cell(rowIdx, 2).Value = item.HoTen;
                    ws.Cell(rowIdx, 3).Value = item.Lop;
                    ws.Cell(rowIdx, 4).Value = item.TenMon;
                    ws.Cell(rowIdx, 5).Value = item.SoTinChi;
                    ws.Cell(rowIdx, 6).Value = (double)item.Diem;
                    ws.Cell(rowIdx, 6).Style.NumberFormat.Format = "0.00";
                    for (int c = 1; c <= 6; c++)
                        ws.Cell(rowIdx, c).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    rowIdx++;
                }

                int lastData = rowIdx - 1;

                // Dong tong ket: AVERAGE Diem + SUM TC
                ws.Cell(rowIdx, 4).Value = "Tổng / TB";
                ws.Cell(rowIdx, 4).Style.Font.Bold = true;

                ws.Cell(rowIdx, 5).FormulaA1 = $"SUM(E2:E{lastData})";
                ws.Cell(rowIdx, 5).Style.Font.Bold = true;

                ws.Cell(rowIdx, 6).FormulaA1 = $"AVERAGE(F2:F{lastData})";
                ws.Cell(rowIdx, 6).Style.Font.Bold = true;
                ws.Cell(rowIdx, 6).Style.NumberFormat.Format = "0.00";

                for (int c = 1; c <= 6; c++)
                {
                    ws.Cell(rowIdx, c).Style.Fill.BackgroundColor = XLColor.FromArgb(243, 243, 243);
                    ws.Cell(rowIdx, c).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }

                ws.Columns().AdjustToContents();
                workbook.SaveAs(sfd.FileName);

                var open = MessageBox.Show(
                    $"Xuất Excel thành công ({data.Count} dòng điểm)!\nBạn có muốn mở file?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (open == DialogResult.Yes)
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
            catch (IOException)
            {
                MessageBox.Show("File Excel đang được mở. Vui lòng đóng rồi thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
