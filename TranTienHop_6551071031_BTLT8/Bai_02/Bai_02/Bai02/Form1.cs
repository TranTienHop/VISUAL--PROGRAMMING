using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai02.Data;
using Bai02.Models;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private int? _selectedMaHD = null;
        private int? _selectedMaCT = null;
        private bool _isBinding = false;
        private List<Mon> _danhSachMon = new();

        private class MonComboItem
        {
            public int MaMon { get; set; }
            public string Display { get; set; } = "";
            public decimal DonGia { get; set; }
            public override string ToString() => Display;
        }

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            dgvHoaDon.CellClick += DgvHoaDon_CellClick;
            dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            dgvChiTiet.CellClick += DgvChiTiet_CellClick;
            dgvChiTiet.SelectionChanged += DgvChiTiet_SelectionChanged;

            btnHoaDonMoi.Click += BtnHoaDonMoi_Click;
            btnSuaHoaDon.Click += BtnSuaHoaDon_Click;
            btnXoaHoaDon.Click += BtnXoaHoaDon_Click;
            btnThemMon.Click += BtnThemMon_Click;
            btnSuaSL.Click += BtnSuaSL_Click;
            btnXoaMon.Click += BtnXoaMon_Click;
            btnTim.Click += BtnTim_Click;
            btnBoLoc.Click += BtnBoLoc_Click;
            btnXemHoaDon.Click += BtnXemHoaDon_Click;
            btnXuatPdf.Click += BtnXuatPdf_Click;
            btnIn.Click += BtnIn_Click;
        }

        #region Khởi tạo & Tải dữ liệu

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                InitControls();
                await LoadMonComboAsync();
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi động chương trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitControls()
        {
            cboSoBan.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cboSoBan.Items.Add(i);
            cboSoBan.SelectedIndex = 0;

            cboLocBan.Items.Clear();
            cboLocBan.Items.Add("Tất cả");
            for (int i = 1; i <= 10; i++)
                cboLocBan.Items.Add(i.ToString());
            cboLocBan.SelectedIndex = 0;

            cboLocHinhThuc.Items.Clear();
            cboLocHinhThuc.Items.Add("Tất cả");
            cboLocHinhThuc.Items.Add("Tiền mặt");
            cboLocHinhThuc.Items.Add("Chuyển khoản");
            cboLocHinhThuc.SelectedIndex = 0;

            dtpTuNgay.Value = new DateTime(2026, 10, 1);
            dtpDenNgay.Value = new DateTime(2026, 10, 31);
            dtpNgayLap.Value = DateTime.Now;
            rdoTienMat.Checked = true;
            nudSoLuong.Value = 1;
        }

        private async Task LoadMonComboAsync()
        {
            using var context = new QuanCaPheContext();
            _danhSachMon = await context.Mons.AsNoTracking().OrderBy(m => m.TenMon).ToListAsync();

            cboMon.Items.Clear();
            foreach (var m in _danhSachMon)
            {
                cboMon.Items.Add(new MonComboItem
                {
                    MaMon = m.MaMon,
                    DonGia = m.DonGia,
                    Display = $"{m.TenMon} - {m.DonGia:N0} đ"
                });
            }
            if (cboMon.Items.Count > 0)
                cboMon.SelectedIndex = 0;
        }

        private async Task FilterHoaDonAsync()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                string locBan = cboLocBan.SelectedItem?.ToString() ?? "Tất cả";
                string locHT = cboLocHinhThuc.SelectedItem?.ToString() ?? "Tất cả";
                string tenMon = txtTenMon.Text.Trim();

                using var context = new QuanCaPheContext();

                var query = context.HoaDons.AsNoTracking().AsQueryable();

                query = query.Where(h => h.NgayLap >= tuNgay && h.NgayLap <= denNgay);

                if (locBan != "Tất cả" && int.TryParse(locBan, out int soBan))
                    query = query.Where(h => h.SoBan == soBan);

                if (locHT != "Tất cả")
                    query = query.Where(h => h.HinhThucTT == locHT);

                if (!string.IsNullOrWhiteSpace(tenMon))
                {
                    var maHDTheoMon = context.ChiTietHoaDons
                        .Where(ct => ct.MaMonNavigation.TenMon.Contains(tenMon))
                        .Select(ct => ct.MaHD);
                    query = query.Where(h => maHDTheoMon.Contains(h.MaHD));
                }

                var hoaDons = await query.OrderByDescending(h => h.NgayLap).ToListAsync();
                var maHDs = hoaDons.Select(h => h.MaHD).ToList();

                var tongTheoHD = await context.ChiTietHoaDons
                    .AsNoTracking()
                    .Where(ct => maHDs.Contains(ct.MaHD))
                    .GroupBy(ct => ct.MaHD)
                    .Select(g => new { MaHD = g.Key, Tong = g.Sum(x => x.SoLuong * x.DonGia) })
                    .ToListAsync();

                var tongDict = tongTheoHD.ToDictionary(x => x.MaHD, x => x.Tong);

                var rows = hoaDons.Select(h => new HoaDonRow
                {
                    MaHD = h.MaHD,
                    NgayLap = h.NgayLap,
                    SoBan = h.SoBan,
                    HinhThucTT = h.HinhThucTT,
                    TongTien = tongDict.TryGetValue(h.MaHD, out var t) ? t : 0
                }).ToList();

                _isBinding = true;
                dgvHoaDon.DataSource = rows;
                _isBinding = false;

                decimal tongDoanhThu = rows.Sum(r => r.TongTien);
                lblTongDoanhThu.Text = $"Tìm thấy {rows.Count} hóa đơn | Tổng doanh thu: {tongDoanhThu:N0} đ";

                if (rows.Count > 0)
                {
                    int restoreIndex = 0;
                    if (_selectedMaHD.HasValue)
                    {
                        int idx = rows.FindIndex(r => r.MaHD == _selectedMaHD.Value);
                        if (idx >= 0) restoreIndex = idx;
                    }
                    dgvHoaDon.ClearSelection();
                    dgvHoaDon.Rows[restoreIndex].Selected = true;
                    dgvHoaDon.CurrentCell = dgvHoaDon.Rows[restoreIndex].Cells[0];
                    await LoadChiTietAsync(rows[restoreIndex].MaHD);
                    FillHeaderFromRow(rows[restoreIndex]);
                }
                else
                {
                    _selectedMaHD = null;
                    dgvChiTiet.DataSource = null;
                    lblTongCong.Text = "Tổng cộng: 0 đ";
                    ResetHeaderControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadChiTietAsync(int maHD)
        {
            try
            {
                using var context = new QuanCaPheContext();
                var list = await (
                    from ct in context.ChiTietHoaDons.AsNoTracking()
                    join m in context.Mons.AsNoTracking() on ct.MaMon equals m.MaMon
                    where ct.MaHD == maHD
                    orderby ct.MaCT
                    select new ChiTietRow
                    {
                        MaCT = ct.MaCT,
                        TenMon = m.TenMon,
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia
                    }).ToListAsync();

                for (int i = 0; i < list.Count; i++)
                    list[i].STT = i + 1;

                _isBinding = true;
                dgvChiTiet.DataSource = list;
                _isBinding = false;

                decimal tong = list.Sum(x => x.ThanhTien);
                lblTongCong.Text = $"Tổng cộng: {tong:N0} đ";
                _selectedMaCT = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Chọn dòng trên lưới

        private async void DgvHoaDon_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count)
                await SelectHoaDonRowAsync(dgvHoaDon.Rows[e.RowIndex]);
        }

        private async void DgvHoaDon_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvHoaDon.CurrentRow != null && dgvHoaDon.CurrentRow.Index >= 0)
                await SelectHoaDonRowAsync(dgvHoaDon.CurrentRow);
        }

        private async Task SelectHoaDonRowAsync(DataGridViewRow row)
        {
            if (row?.DataBoundItem is HoaDonRow item)
            {
                _selectedMaHD = item.MaHD;
                FillHeaderFromRow(item);
                await LoadChiTietAsync(item.MaHD);

                try
                {
                    using var context = new QuanCaPheContext();
                    var hd = await context.HoaDons.AsNoTracking().FirstOrDefaultAsync(h => h.MaHD == item.MaHD);
                    if (hd != null)
                        txtGhiChu.Text = hd.GhiChu ?? "";
                }
                catch { /* ignore */ }
            }
        }

        private void FillHeaderFromRow(HoaDonRow item)
        {
            dtpNgayLap.Value = item.NgayLap;
            if (cboSoBan.Items.Contains(item.SoBan))
                cboSoBan.SelectedItem = item.SoBan;
            else
                cboSoBan.Text = item.SoBan.ToString();

            if (item.HinhThucTT == "Chuyển khoản")
                rdoChuyenKhoan.Checked = true;
            else
                rdoTienMat.Checked = true;
        }

        private void DgvChiTiet_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChiTiet.Rows.Count)
                FillChiTietFromRow(dgvChiTiet.Rows[e.RowIndex]);
        }

        private void DgvChiTiet_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvChiTiet.CurrentRow != null && dgvChiTiet.CurrentRow.Index >= 0)
                FillChiTietFromRow(dgvChiTiet.CurrentRow);
        }

        private void FillChiTietFromRow(DataGridViewRow row)
        {
            if (row?.DataBoundItem is ChiTietRow item)
            {
                _selectedMaCT = item.MaCT;
                nudSoLuong.Value = Math.Max(nudSoLuong.Minimum, Math.Min(nudSoLuong.Maximum, item.SoLuong));

                for (int i = 0; i < cboMon.Items.Count; i++)
                {
                    if (cboMon.Items[i] is MonComboItem mi && mi.Display.StartsWith(item.TenMon))
                    {
                        cboMon.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void ResetHeaderControls()
        {
            _selectedMaHD = null;
            _selectedMaCT = null;
            dtpNgayLap.Value = DateTime.Now;
            if (cboSoBan.Items.Count > 0) cboSoBan.SelectedIndex = 0;
            rdoTienMat.Checked = true;
            txtGhiChu.Clear();
            nudSoLuong.Value = 1;
            if (cboMon.Items.Count > 0) cboMon.SelectedIndex = 0;
        }

        private string GetHinhThucTT() => rdoChuyenKhoan.Checked ? "Chuyển khoản" : "Tiền mặt";

        #endregion

        #region CRUD Hóa đơn

        private async void BtnHoaDonMoi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cboSoBan.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn số bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hd = new HoaDon
                {
                    NgayLap = dtpNgayLap.Value,
                    SoBan = Convert.ToInt32(cboSoBan.SelectedItem),
                    HinhThucTT = GetHinhThucTT(),
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                using var context = new QuanCaPheContext();
                await context.HoaDons.AddAsync(hd);
                await context.SaveChangesAsync();

                _selectedMaHD = hd.MaHD;
                MessageBox.Show($"Đã tạo hóa đơn HD{hd.MaHD:D6} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo hóa đơn mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSuaHoaDon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaHD.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new QuanCaPheContext();
                var hd = await context.HoaDons.FindAsync(_selectedMaHD.Value);
                if (hd == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hd.NgayLap = dtpNgayLap.Value;
                hd.SoBan = Convert.ToInt32(cboSoBan.SelectedItem);
                hd.HinhThucTT = GetHinhThucTT();
                hd.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                await context.SaveChangesAsync();
                MessageBox.Show($"Cập nhật hóa đơn HD{hd.MaHD:D6} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi sửa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoaHoaDon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaHD.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa hóa đơn HD{_selectedMaHD.Value:D6}?\nToàn bộ chi tiết món sẽ bị xóa theo.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                using var context = new QuanCaPheContext();
                var chiTiets = await context.ChiTietHoaDons.Where(ct => ct.MaHD == _selectedMaHD.Value).ToListAsync();
                context.ChiTietHoaDons.RemoveRange(chiTiets);

                var hd = await context.HoaDons.FindAsync(_selectedMaHD.Value);
                if (hd != null)
                    context.HoaDons.Remove(hd);

                await context.SaveChangesAsync();

                _selectedMaHD = null;
                MessageBox.Show("Đã xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CRUD Chi tiết món

        private async void BtnThemMon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaHD.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn hoặc tạo hóa đơn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboMon.SelectedItem is not MonComboItem monItem)
                {
                    MessageBox.Show("Vui lòng chọn món!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soLuong = (int)nudSoLuong.Value;
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ct = new ChiTietHoaDon
                {
                    MaHD = _selectedMaHD.Value,
                    MaMon = monItem.MaMon,
                    SoLuong = soLuong,
                    DonGia = monItem.DonGia
                };

                using var context = new QuanCaPheContext();
                await context.ChiTietHoaDons.AddAsync(ct);
                await context.SaveChangesAsync();

                MessageBox.Show($"Đã thêm món '{monItem.Display.Split('-')[0].Trim()}' vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSuaSL_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaCT.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn dòng chi tiết để sửa số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soLuong = (int)nudSoLuong.Value;
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new QuanCaPheContext();
                var ct = await context.ChiTietHoaDons.FindAsync(_selectedMaCT.Value);
                if (ct == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ct.SoLuong = soLuong;
                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật số lượng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi sửa số lượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoaMon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaCT.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn dòng chi tiết để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa món này khỏi hóa đơn?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                using var context = new QuanCaPheContext();
                var ct = await context.ChiTietHoaDons.FindAsync(_selectedMaCT.Value);
                if (ct == null)
                {
                    MessageBox.Show("Không tìm thấy chi tiết cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.ChiTietHoaDons.Remove(ct);
                await context.SaveChangesAsync();

                _selectedMaCT = null;
                MessageBox.Show("Đã xóa món khỏi hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterHoaDonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Tìm / Bỏ lọc

        private async void BtnTim_Click(object? sender, EventArgs e)
        {
            await FilterHoaDonAsync();
        }

        private async void BtnBoLoc_Click(object? sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2026, 1, 1);
            dtpDenNgay.Value = DateTime.Today.AddMonths(1);
            cboLocBan.SelectedIndex = 0;
            cboLocHinhThuc.SelectedIndex = 0;
            txtTenMon.Clear();
            await FilterHoaDonAsync();
        }

        #endregion

        #region FastReport: Xem / PDF / In

        private string GetReportFilePath(string reportFileName)
        {
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", reportFileName);
            if (File.Exists(path1)) return path1;

            string path2 = Path.Combine(Application.StartupPath, "Reports", reportFileName);
            if (File.Exists(path2)) return path2;

            string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Reports", reportFileName);
            if (File.Exists(path3)) return Path.GetFullPath(path3);

            return path1;
        }

        private async Task<(HoaDon? hd, List<ChiTietIn> chiTiet)> GetReportDataAsync(int maHD)
        {
            using var context = new QuanCaPheContext();
            var hd = await context.HoaDons.AsNoTracking().FirstOrDefaultAsync(h => h.MaHD == maHD);
            if (hd == null) return (null, new List<ChiTietIn>());

            var list = await (
                from ct in context.ChiTietHoaDons.AsNoTracking()
                join m in context.Mons.AsNoTracking() on ct.MaMon equals m.MaMon
                where ct.MaHD == maHD
                orderby ct.MaCT
                select new { m.TenMon, ct.SoLuong, ct.DonGia }).ToListAsync();

            var chiTiet = list.Select((x, i) => new ChiTietIn
            {
                STT = i + 1,
                TenMon = x.TenMon,
                SoLuong = x.SoLuong,
                DonGia = x.DonGia,
                ThanhTien = x.SoLuong * x.DonGia
            }).ToList();

            return (hd, chiTiet);
        }

        private FastReport.Report? PrepareReport(HoaDon hd, List<ChiTietIn> chiTiet, string reportPath)
        {
            var report = new FastReport.Report();
            report.Load(reportPath);
            report.RegisterData(chiTiet, "ChiTiet");
            report.GetDataSource("ChiTiet").Enabled = true;
            report.SetParameterValue("TenQuan", "Quán cà phê Góc Phố");
            report.SetParameterValue("SoHoaDon", $"HD{hd.MaHD:D6}");
            report.SetParameterValue("NgayLap", hd.NgayLap.ToString("dd/MM/yyyy HH:mm"));
            report.SetParameterValue("SoBan", hd.SoBan.ToString());
            report.SetParameterValue("HinhThucTT", hd.HinhThucTT);
            report.Prepare();
            return report;
        }

        private async Task<(bool ok, HoaDon? hd, List<ChiTietIn>? chiTiet, string? reportPath)> ValidateForReportAsync()
        {
            if (!_selectedMaHD.HasValue)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, null, null, null);
            }

            string reportPath = GetReportFilePath("HoaDon.frx");
            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"Không tìm thấy file mẫu báo cáo tại: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null, null, null);
            }

            var (hd, chiTiet) = await GetReportDataAsync(_selectedMaHD.Value);
            if (hd == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null, null, null);
            }

            if (chiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có món nào. Không thể in hóa đơn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, null, null, null);
            }

            return (true, hd, chiTiet, reportPath);
        }

        private async void BtnXemHoaDon_Click(object? sender, EventArgs e)
        {
            try
            {
                var (ok, hd, chiTiet, reportPath) = await ValidateForReportAsync();
                if (!ok || hd == null || chiTiet == null || reportPath == null) return;

                using var report = PrepareReport(hd, chiTiet, reportPath);
                report?.ShowPrepared();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXuatPdf_Click(object? sender, EventArgs e)
        {
            try
            {
                var (ok, hd, chiTiet, reportPath) = await ValidateForReportAsync();
                if (!ok || hd == null || chiTiet == null || reportPath == null) return;

                using var sfd = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = $"HoaDon_HD{hd.MaHD:D6}.pdf",
                    Title = "Lưu hóa đơn PDF"
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using var report = PrepareReport(hd, chiTiet, reportPath);
                if (report == null) return;

                var pdfExport = new FastReport.Export.Pdf.PDFExport();
                report.Export(pdfExport, sfd.FileName);

                var openResult = MessageBox.Show(
                    "Xuất file PDF thành công! Bạn có muốn mở file ngay không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (openResult == DialogResult.Yes)
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
            }
            catch (IOException)
            {
                MessageBox.Show("File PDF đang được mở bởi chương trình khác. Vui lòng đóng file rồi thử lại!", "Lỗi file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnIn_Click(object? sender, EventArgs e)
        {
            try
            {
                var (ok, hd, chiTiet, reportPath) = await ValidateForReportAsync();
                if (!ok || hd == null || chiTiet == null || reportPath == null) return;

                using var report = PrepareReport(hd, chiTiet, reportPath);
                report?.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi in hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
