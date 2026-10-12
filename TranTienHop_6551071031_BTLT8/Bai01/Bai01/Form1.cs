using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Bai01.Data;
using Bai01.Models;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer _searchTimer;
        private int? _selectedMaHang = null;
        private bool _isBinding = false;

        public Form1()
        {
            InitializeComponent();

            // Khởi tạo Timer phục vụ tìm kiếm gõ tới đâu lọc tới đó (350ms sau khi ngừng gõ)
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 350;
            _searchTimer.Tick += SearchTimer_Tick;

            // Gán các sự kiện
            Load += Form1_Load;
            dgvHangHoa.CellClick += DgvHangHoa_CellClick;
            dgvHangHoa.SelectionChanged += DgvHangHoa_SelectionChanged;

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;

            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            cboLocLoaiHang.SelectedIndexChanged += CboLocLoaiHang_SelectedIndexChanged;
            chkChiConKinhDoanh.CheckedChanged += ChkChiConKinhDoanh_CheckedChanged;

            btnXemBangGia.Click += BtnXemBangGia_Click;
            btnXuatPdf.Click += BtnXuatPdf_Click;
            btnXuatExcelLuoi.Click += BtnXuatExcelLuoi_Click;
            btnXuatExcelTonKho.Click += BtnXuatExcelTonKho_Click;
        }

        #region Khởi tạo & Tải dữ liệu

        private async void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                InitComboBoxes();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi động chương trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitComboBoxes()
        {
            // Danh mục Loại hàng
            string[] loaiHangs = { "Đồ uống", "Thực phẩm khô", "Gia vị", "Đồ gia dụng" };
            cboLoaiHang.Items.Clear();
            cboLoaiHang.Items.AddRange(loaiHangs);
            cboLoaiHang.SelectedIndex = 0;

            // Bộ lọc loại hàng (có mục "Tất cả loại" theo mẫu)
            cboLocLoaiHang.Items.Clear();
            cboLocLoaiHang.Items.Add("Tất cả loại");
            cboLocLoaiHang.Items.AddRange(loaiHangs);
            cboLocLoaiHang.SelectedIndex = 0;

            // Danh mục Đơn vị tính
            string[] donVis = { "Chai", "Gói", "Hộp", "Túi" };
            cboDonVi.Items.Clear();
            cboDonVi.Items.AddRange(donVis);
            cboDonVi.SelectedIndex = 0;

            dtpNgayNhap.Value = DateTime.Today;
        }

        private async Task LoadDataAsync()
        {
            await FilterDataAsync();
        }

        private async Task FilterDataAsync()
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                string selectedLoai = cboLocLoaiHang.SelectedItem?.ToString() ?? "Tất cả loại";
                bool chiConBan = chkChiConKinhDoanh.Checked;

                using var context = new TiemTapHoaContext();
                var query = context.HangHoas.AsNoTracking().AsQueryable();

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query = query.Where(h => h.TenHang.Contains(keyword));
                }

                if (!string.IsNullOrEmpty(selectedLoai) && !selectedLoai.StartsWith("Tất cả"))
                {
                    query = query.Where(h => h.LoaiHang == selectedLoai);
                }

                if (chiConBan)
                {
                    query = query.Where(h => h.ConKinhDoanh);
                }

                var list = await query.OrderBy(h => h.MaHang).ToListAsync();

                _isBinding = true;
                dgvHangHoa.DataSource = list;
                _isBinding = false;

                lblTrangThai.Text = $"Tìm thấy {list.Count} mặt hàng";

                // Nếu có hàng được chọn, đổ lại dữ liệu
                if (dgvHangHoa.Rows.Count > 0)
                {
                    FillControlsFromRow(dgvHangHoa.Rows[0]);
                }
                else
                {
                    ResetInputControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Bắt sự kiện chọn dòng trên DataGridView

        private void DgvHangHoa_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count)
            {
                FillControlsFromRow(dgvHangHoa.Rows[e.RowIndex]);
            }
        }

        private void DgvHangHoa_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;

            if (dgvHangHoa.CurrentRow != null && dgvHangHoa.CurrentRow.Index >= 0)
            {
                FillControlsFromRow(dgvHangHoa.CurrentRow);
            }
        }

        private void FillControlsFromRow(DataGridViewRow row)
        {
            if (row?.DataBoundItem is HangHoa item)
            {
                _selectedMaHang = item.MaHang;
                txtTenHang.Text = item.TenHang;

                if (!string.IsNullOrEmpty(item.LoaiHang) && cboLoaiHang.Items.Contains(item.LoaiHang))
                    cboLoaiHang.SelectedItem = item.LoaiHang;
                else
                    cboLoaiHang.Text = item.LoaiHang ?? "";

                if (!string.IsNullOrEmpty(item.DonVi) && cboDonVi.Items.Contains(item.DonVi))
                    cboDonVi.SelectedItem = item.DonVi;
                else
                    cboDonVi.Text = item.DonVi ?? "";

                nudGiaBan.Value = Math.Max(nudGiaBan.Minimum, Math.Min(nudGiaBan.Maximum, item.GiaBan));
                nudSoLuongTon.Value = Math.Max(nudSoLuongTon.Minimum, Math.Min(nudSoLuongTon.Maximum, item.SoLuongTon));
                dtpNgayNhap.Value = item.NgayNhap;
                chkConKinhDoanh.Checked = item.ConKinhDoanh;
            }
        }

        private void ResetInputControls()
        {
            _selectedMaHang = null;
            txtTenHang.Clear();
            if (cboLoaiHang.Items.Count > 0) cboLoaiHang.SelectedIndex = 0;
            if (cboDonVi.Items.Count > 0) cboDonVi.SelectedIndex = 0;
            nudGiaBan.Value = 0;
            nudSoLuongTon.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            txtTenHang.Focus();
        }

        #endregion

        #region Thêm - Sửa - Xóa - Làm mới

        private async void BtnThem_Click(object? sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu hợp lệ: tên hàng không để trống, giá bán > 0
                if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                {
                    MessageBox.Show("Tên hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHang.Focus();
                    return;
                }

                if (nudGiaBan.Value <= 0)
                {
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudGiaBan.Focus();
                    return;
                }

                var item = new HangHoa
                {
                    TenHang = txtTenHang.Text.Trim(),
                    LoaiHang = cboLoaiHang.SelectedItem?.ToString() ?? cboLoaiHang.Text.Trim(),
                    DonVi = cboDonVi.SelectedItem?.ToString() ?? cboDonVi.Text.Trim(),
                    GiaBan = nudGiaBan.Value,
                    SoLuongTon = (int)nudSoLuongTon.Value,
                    NgayNhap = dtpNgayNhap.Value,
                    ConKinhDoanh = chkConKinhDoanh.Checked
                };

                using var context = new TiemTapHoaContext();
                await context.HangHoas.AddAsync(item);
                await context.SaveChangesAsync();

                MessageBox.Show($"Thêm mới hàng hóa '{item.TenHang}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterDataAsync();
                ResetInputControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hàng hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSua_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaHang.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng trên danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                {
                    MessageBox.Show("Tên hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenHang.Focus();
                    return;
                }

                if (nudGiaBan.Value <= 0)
                {
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudGiaBan.Focus();
                    return;
                }

                using var context = new TiemTapHoaContext();
                var item = await context.HangHoas.FindAsync(_selectedMaHang.Value);
                if (item == null)
                {
                    MessageBox.Show("Không tìm thấy hàng hóa cần sửa trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                item.TenHang = txtTenHang.Text.Trim();
                item.LoaiHang = cboLoaiHang.SelectedItem?.ToString() ?? cboLoaiHang.Text.Trim();
                item.DonVi = cboDonVi.SelectedItem?.ToString() ?? cboDonVi.Text.Trim();
                item.GiaBan = nudGiaBan.Value;
                item.SoLuongTon = (int)nudSoLuongTon.Value;
                item.NgayNhap = dtpNgayNhap.Value;
                item.ConKinhDoanh = chkConKinhDoanh.Checked;

                await context.SaveChangesAsync();

                MessageBox.Show($"Cập nhật hàng hóa '{item.TenHang}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await FilterDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa hàng hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXoa_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!_selectedMaHang.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng trên danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new TiemTapHoaContext();
                var item = await context.HangHoas.FindAsync(_selectedMaHang.Value);
                if (item == null)
                {
                    MessageBox.Show("Không tìm thấy hàng hóa cần xóa trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa mặt hàng '{item.TenHang}' (Mã: {item.MaHang}) khỏi cơ sở dữ liệu?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    context.HangHoas.Remove(item);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Đã xóa mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await FilterDataAsync();
                    ResetInputControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hàng hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoi_Click(object? sender, EventArgs e)
        {
            ResetInputControls();
            txtTimKiem.Clear();
            cboLocLoaiHang.SelectedIndex = 0;
            chkChiConKinhDoanh.Checked = false;
        }

        #endregion

        #region Tìm kiếm (Debounce 350ms)

        private void TxtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private async void SearchTimer_Tick(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            await FilterDataAsync();
        }

        private async void CboLocLoaiHang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            await FilterDataAsync();
        }

        private async void ChkChiConKinhDoanh_CheckedChanged(object? sender, EventArgs e)
        {
            await FilterDataAsync();
        }

        #endregion

        #region FastReport & Xuất PDF

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

        private async Task<DataTable> GetBangGiaDataTableAsync()
        {
            using var context = new TiemTapHoaContext();
            var list = await context.HangHoas
                .AsNoTracking()
                .Where(h => h.ConKinhDoanh)
                .OrderBy(h => h.MaHang)
                .ToListAsync();

            var dt = new DataTable("HangHoa");
            dt.Columns.Add("MaHang", typeof(int));
            dt.Columns.Add("TenHang", typeof(string));
            dt.Columns.Add("LoaiHang", typeof(string));
            dt.Columns.Add("DonVi", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("SoLuongTon", typeof(int));
            dt.Columns.Add("NgayNhap", typeof(DateTime));
            dt.Columns.Add("ConKinhDoanh", typeof(bool));

            foreach (var h in list)
            {
                dt.Rows.Add(h.MaHang, h.TenHang, h.LoaiHang, h.DonVi, h.GiaBan, h.SoLuongTon, h.NgayNhap, h.ConKinhDoanh);
            }

            return dt;
        }

        private async void BtnXemBangGia_Click(object? sender, EventArgs e)
        {
            try
            {
                string reportPath = GetReportFilePath("BangGia.frx");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Không tìm thấy file mẫu báo cáo tại: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = await GetBangGiaDataTableAsync();

                using var report = new FastReport.Report();
                report.Load(reportPath);
                report.RegisterData(dt, "HangHoa");
                report.GetDataSource("HangHoa").Enabled = true;
                report.SetParameterValue("NgayIn", DateTime.Now.ToString("dd/MM/yyyy"));

                report.Prepare();
                report.ShowPrepared();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị báo cáo FastReport: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXuatPdf_Click(object? sender, EventArgs e)
        {
            try
            {
                string reportPath = GetReportFilePath("BangGia.frx");
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Không tìm thấy file mẫu báo cáo tại: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = $"BangGia_{DateTime.Now:yyyyMMdd_HHmmss}.pdf",
                    Title = "Lưu file bảng giá PDF"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = await GetBangGiaDataTableAsync();

                    using var report = new FastReport.Report();
                    report.Load(reportPath);
                    report.RegisterData(dt, "HangHoa");
                    report.GetDataSource("HangHoa").Enabled = true;
                    report.SetParameterValue("NgayIn", DateTime.Now.ToString("dd/MM/yyyy"));

                    report.Prepare();

                    var pdfExport = new FastReport.Export.Pdf.PDFExport();
                    report.Export(pdfExport, sfd.FileName);

                    var openResult = MessageBox.Show(
                        "Xuất file PDF thành công! Bạn có muốn mở file ngay không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (openResult == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File PDF đang được mở bởi một chương trình khác. Vui lòng đóng file rồi thử lại!", "Lỗi file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Xuất Excel bằng ClosedXML

        private void BtnXuatExcelLuoi_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvHangHoa.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trên lưới để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"DanhSachHangHoa_Luoi_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                    Title = "Lưu file Excel xuất từ lưới"
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("DanhSachHangHoa");

                // Tiêu đề các cột
                int colIndex = 1;
                for (int c = 0; c < dgvHangHoa.Columns.Count; c++)
                {
                    if (dgvHangHoa.Columns[c].Visible)
                    {
                        var cell = worksheet.Cell(1, colIndex);
                        cell.Value = dgvHangHoa.Columns[c].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.BackgroundColor = XLColor.FromArgb(230, 240, 250);
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        colIndex++;
                    }
                }

                // Dữ liệu từ các dòng hiển thị trên DataGridView (đúng số dòng đang hiển thị, số là số)
                int rowIndex = 2;
                foreach (DataGridViewRow row in dgvHangHoa.Rows)
                {
                    if (row.IsNewRow) continue;

                    colIndex = 1;
                    for (int c = 0; c < dgvHangHoa.Columns.Count; c++)
                    {
                        var col = dgvHangHoa.Columns[c];
                        if (!col.Visible) continue;

                        var val = row.Cells[c].Value;
                        var cell = worksheet.Cell(rowIndex, colIndex);
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                        if (val == null || val == DBNull.Value)
                        {
                            cell.Value = "";
                        }
                        else if (val is int intVal)
                        {
                            cell.Value = intVal;
                            cell.Style.NumberFormat.Format = col.Name == colMaHang.Name ? "0" : "#,##0";
                            cell.Style.Alignment.Horizontal = col.Name == colMaHang.Name ? XLAlignmentHorizontalValues.Center : XLAlignmentHorizontalValues.Right;
                        }
                        else if (val is decimal decVal)
                        {
                            cell.Value = (double)decVal;
                            cell.Style.NumberFormat.Format = "#,##0";
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                        }
                        else if (val is double dblVal)
                        {
                            cell.Value = dblVal;
                            cell.Style.NumberFormat.Format = "#,##0";
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                        }
                        else if (val is DateTime dtVal)
                        {
                            cell.Value = dtVal.ToString("dd/MM/yyyy");
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }
                        else if (val is bool boolVal)
                        {
                            cell.Value = boolVal ? "Còn bán" : "Ngừng bán";
                            cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        }
                        else
                        {
                            string str = val.ToString() ?? "";
                            if (decimal.TryParse(str, out decimal parsedNum) && col.Name == colGiaBan.Name)
                            {
                                cell.Value = (double)parsedNum;
                                cell.Style.NumberFormat.Format = "#,##0";
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                            }
                            else
                            {
                                cell.Value = str;
                            }
                        }

                        colIndex++;
                    }

                    rowIndex++;
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(sfd.FileName);

                var openResult = MessageBox.Show(
                    "Xuất file Excel từ lưới thành công! Bạn có muốn mở file ngay không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (openResult == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File Excel đang được mở bởi một chương trình khác. Vui lòng đóng file rồi thử lại!", "Lỗi truy cập file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnXuatExcelTonKho_Click(object? sender, EventArgs e)
        {
            try
            {
                using var sfd = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"BaoCaoTonKho_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                    Title = "Lưu file Excel tồn kho"
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                // Truy vấn bằng EF Core các hàng còn kinh doanh
                using var context = new TiemTapHoaContext();
                var list = await context.HangHoas
                    .AsNoTracking()
                    .Where(h => h.ConKinhDoanh)
                    .OrderBy(h => h.MaHang)
                    .ToListAsync();

                using var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("BaoCaoTonKho");

                // Tiêu đề các cột
                string[] headers = { "STT", "Mã hàng", "Tên hàng", "Loại hàng", "Đơn vị", "Giá bán", "Số lượng tồn", "Giá trị tồn" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = worksheet.Cell(1, i + 1);
                    cell.Value = headers[i];
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor = XLColor.FromArgb(217, 234, 211);
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }

                // Dữ liệu hàng hóa (5 dòng)
                int currentRow = 2;
                for (int i = 0; i < list.Count; i++)
                {
                    var h = list[i];

                    // STT
                    worksheet.Cell(currentRow, 1).Value = i + 1;
                    worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Mã hàng
                    worksheet.Cell(currentRow, 2).Value = h.MaHang;
                    worksheet.Cell(currentRow, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Tên hàng
                    worksheet.Cell(currentRow, 3).Value = h.TenHang;

                    // Loại hàng
                    worksheet.Cell(currentRow, 4).Value = h.LoaiHang ?? "";

                    // Đơn vị
                    worksheet.Cell(currentRow, 5).Value = h.DonVi ?? "";
                    worksheet.Cell(currentRow, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Giá bán (cột F)
                    var cellGia = worksheet.Cell(currentRow, 6);
                    cellGia.Value = (double)h.GiaBan;
                    cellGia.Style.NumberFormat.Format = "#,##0";
                    cellGia.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    // Số lượng tồn (cột G)
                    var cellSl = worksheet.Cell(currentRow, 7);
                    cellSl.Value = h.SoLuongTon;
                    cellSl.Style.NumberFormat.Format = "#,##0";
                    cellSl.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    // Giá trị tồn (cột H) - Công thức = F * G
                    var cellGiaTri = worksheet.Cell(currentRow, 8);
                    cellGiaTri.FormulaA1 = $"F{currentRow}*G{currentRow}";
                    cellGiaTri.Style.NumberFormat.Format = "#,##0";
                    cellGiaTri.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    // Kẻ viền từng ô
                    for (int c = 1; c <= 8; c++)
                    {
                        worksheet.Cell(currentRow, c).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    currentRow++;
                }

                int lastDataRow = currentRow - 1;

                // Dòng Tổng: nhãn "Tổng", công thức SUM(H2:Hlast)
                var totalLabelCell = worksheet.Cell(currentRow, 3);
                totalLabelCell.Value = "Tổng";
                totalLabelCell.Style.Font.Bold = true;
                totalLabelCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // Tổng số lượng tồn: SUM(G2:Glast)
                var totalSlCell = worksheet.Cell(currentRow, 7);
                totalSlCell.FormulaA1 = $"SUM(G2:G{lastDataRow})";
                totalSlCell.Style.Font.Bold = true;
                totalSlCell.Style.NumberFormat.Format = "#,##0";
                totalSlCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                // Tổng giá trị tồn: SUM(H2:Hlast)
                var totalValCell = worksheet.Cell(currentRow, 8);
                totalValCell.FormulaA1 = $"SUM(H2:H{lastDataRow})";
                totalValCell.Style.Font.Bold = true;
                totalValCell.Style.NumberFormat.Format = "#,##0";
                totalValCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                for (int c = 1; c <= 8; c++)
                {
                    var cell = worksheet.Cell(currentRow, c);
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor = XLColor.FromArgb(243, 243, 243);
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }

                // Thiết lập AutoFilter và Cố định dòng tiêu đề (Freeze)
                worksheet.Range(1, 1, lastDataRow, 8).SetAutoFilter();
                worksheet.SheetView.FreezeRows(1);

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(sfd.FileName);

                var openResult = MessageBox.Show(
                    "Xuất file Excel tồn kho thành công! Bạn có muốn mở file ngay không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (openResult == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File Excel đang được mở bởi một chương trình khác. Vui lòng đóng file rồi thử lại!", "Lỗi truy cập file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất file Excel tồn kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
