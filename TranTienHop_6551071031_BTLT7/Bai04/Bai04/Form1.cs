using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai04.Models;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private AnKhangClinicDBContext _context;
        private int? _selectedMaLich = null;

        public Form1()
        {
            InitializeComponent();
            _context = new AnKhangClinicDBContext();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Tắt tự động sinh cột để không bị thừa cột NgayKham, GioKham...
            dgvLichKham.AutoGenerateColumns = false;

            // Thiết lập giá trị mặc định cho DateTimePicker
            dtpNgayKham.Value = DateTime.Today;
            dtpGioKham.Value = DateTime.Today.AddHours(8); // Mặc định 08:00 sáng
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today.AddDays(30);

            // Nạp danh sách trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
            cboTrangThai.SelectedIndex = 0; // 'Chờ khám'

            // Tải danh sách Bác sĩ và Danh sách Lịch khám
            await LoadDanhSachBacSiAsync();
            await LoadDanhSachLichKhamAsync();
        }

        /// <summary>
        /// Tải danh sách Bác sĩ nạp vào ComboBox nhập liệu và ComboBox tìm kiếm
        /// Hiển thị định dạng: "BS. Nguyễn Văn A - Nội tổng quát"
        /// </summary>
        private async Task LoadDanhSachBacSiAsync()
        {
            try
            {
                var dsBacSi = await _context.BacSis
                    .AsNoTracking()
                    .OrderBy(b => b.HoTen)
                    .ToListAsync();

                // 1. Nạp cho ComboBox Nhập liệu (cboBacSi)
                var listNhapLieu = dsBacSi.Select(b => new
                {
                    MaBs = b.MaBs,
                    ThongTinHienThi = b.ThongTinHienThi
                }).ToList();

                cboBacSi.DataSource = listNhapLieu;
                cboBacSi.DisplayMember = "ThongTinHienThi";
                cboBacSi.ValueMember = "MaBs";
                if (cboBacSi.Items.Count > 0)
                {
                    cboBacSi.SelectedIndex = 0;
                }

                // 2. Nạp cho ComboBox Lọc (cboLocBacSi) có thêm lựa chọn "[ Tất cả bác sĩ ]"
                var listLoc = new List<object>
                {
                    new { MaBs = 0, ThongTinHienThi = "Tất cả bác sĩ" }
                };
                listLoc.AddRange(listNhapLieu);

                cboLocBacSi.DataSource = listLoc;
                cboLocBacSi.DisplayMember = "ThongTinHienThi";
                cboLocBacSi.ValueMember = "MaBs";
                cboLocBacSi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bác sĩ: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nạp toàn bộ danh sách lịch khám.
        /// Bắt buộc sử dụng LINQ Include(x => x.MaBsNavigation) để JOIN liên bảng tránh lỗi NullReferenceException.
        /// </summary>
        private async Task LoadDanhSachLichKhamAsync()
        {
            try
            {
                var query = _context.LichKhams
                    .Include(x => x.MaBsNavigation)
                    .AsNoTracking()
                    .OrderBy(x => x.NgayKham)
                    .ThenBy(x => x.GioKham);

                var listRaw = await query.ToListAsync();
                HienThiDuLieuLenGrid(listRaw);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lịch khám: {ex.Message}", "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ánh xạ dữ liệu sang ViewModel và hiển thị trên DataGridView
        /// </summary>
        private void HienThiDuLieuLenGrid(List<LichKham> rawList)
        {
            var viewList = rawList.Select(x => new LichKhamViewModel
            {
                MaLich = x.MaLich,
                TenBenhNhan = x.TenBenhNhan,
                Sdt = x.Sdt ?? "",
                NgayKhamText = x.NgayKham.ToString("dd/MM/yyyy"),
                GioKhamText = x.GioKham.ToString("HH:mm"),
                TenBacSi = x.MaBsNavigation != null 
                    ? (x.MaBsNavigation.HoTen.Trim().StartsWith("BS.", StringComparison.OrdinalIgnoreCase) || x.MaBsNavigation.HoTen.Trim().StartsWith("Bác sĩ", StringComparison.OrdinalIgnoreCase)
                        ? x.MaBsNavigation.HoTen.Trim()
                        : $"BS. {x.MaBsNavigation.HoTen.Trim()}") 
                    : "(Chưa phân công)",
                ChuyenKhoa = x.MaBsNavigation?.ChuyenKhoa ?? "",
                TrangThai = x.TrangThai,
                NgayKham = x.NgayKham,
                GioKham = x.GioKham,
                MaBs = x.MaBs
            }).ToList();

            dgvLichKham.DataSource = viewList;
        }

        /// <summary>
        /// Hỗ trợ click chọn dòng trên DataGridView để hiển thị dữ liệu lên controls
        /// </summary>
        private void dgvLichKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvLichKham.Rows.Count) return;

            var row = dgvLichKham.Rows[e.RowIndex];
            if (row.DataBoundItem is LichKhamViewModel item)
            {
                _selectedMaLich = item.MaLich;

                txtTenBenhNhan.Text = item.TenBenhNhan;
                txtSdt.Text = item.Sdt;
                dtpNgayKham.Value = item.NgayKham.ToDateTime(TimeOnly.MinValue);
                dtpGioKham.Value = DateTime.Today.Add(item.GioKham.ToTimeSpan());
                cboBacSi.SelectedValue = item.MaBs;
                cboTrangThai.SelectedItem = item.TrangThai;
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu trước khi Thêm hoặc Sửa
        /// - Không cho phép đặt lịch khám vào ngày trong quá khứ (NgayKham.Date < DateTime.Today)
        /// - Không được bỏ trống Tên bệnh nhân
        /// - Phải chọn Bác sĩ
        /// </summary>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return false;
            }

            if (cboBacSi.SelectedValue == null || !(cboBacSi.SelectedValue is int maBs) || maBs <= 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ khám bệnh!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBacSi.Focus();
                return false;
            }

            if (cboTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái lịch khám!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return false;
            }

            DateOnly ngayKhamChon = DateOnly.FromDateTime(dtpNgayKham.Value.Date);
            DateOnly homNay = DateOnly.FromDateTime(DateTime.Today);
            if (ngayKhamChon < homNay)
            {
                MessageBox.Show("Không cho phép đặt lịch khám vào ngày trong quá khứ!", "Cảnh báo nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKham.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Làm mới các ô nhập liệu và bỏ chọn
        /// </summary>
        private void ResetForm()
        {
            _selectedMaLich = null;
            txtTenBenhNhan.Clear();
            txtSdt.Clear();
            dtpNgayKham.Value = DateTime.Today;
            dtpGioKham.Value = DateTime.Today.AddHours(8);
            if (cboBacSi.Items.Count > 0)
            {
                cboBacSi.SelectedIndex = 0;
            }
            cboTrangThai.SelectedIndex = 0; // 'Chờ khám'
            dgvLichKham.ClearSelection();
            txtTenBenhNhan.Focus();
        }

        /// <summary>
        /// Thêm lịch khám mới vào database
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var lichKham = new LichKham
                {
                    TenBenhNhan = txtTenBenhNhan.Text.Trim(),
                    Sdt = txtSdt.Text.Trim(),
                    NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date),
                    GioKham = TimeOnly.FromDateTime(dtpGioKham.Value),
                    MaBs = Convert.ToInt32(cboBacSi.SelectedValue),
                    TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám"
                };

                _context.LichKhams.Add(lichKham);
                await _context.SaveChangesAsync();

                MessageBox.Show("Đặt lịch khám bệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDanhSachLichKhamAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm lịch khám: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật thông tin lịch khám đã chọn
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaLich == null)
            {
                MessageBox.Show("Vui lòng click chọn một dòng lịch khám trên bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                var lichKham = await _context.LichKhams.FindAsync(_selectedMaLich.Value);
                if (lichKham == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin lịch khám cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lichKham.TenBenhNhan = txtTenBenhNhan.Text.Trim();
                lichKham.Sdt = txtSdt.Text.Trim();
                lichKham.NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date);
                lichKham.GioKham = TimeOnly.FromDateTime(dtpGioKham.Value);
                lichKham.MaBs = Convert.ToInt32(cboBacSi.SelectedValue);
                lichKham.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám";

                await _context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDanhSachLichKhamAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật lịch khám: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa lịch khám đang chọn.
        /// Bắt buộc hiển thị hộp thoại xác nhận Yes/No trước khi gọi SaveChangesAsync().
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaLich == null)
            {
                MessageBox.Show("Vui lòng click chọn một dòng lịch khám trên bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lichKham = await _context.LichKhams
                .Include(l => l.MaBsNavigation)
                .FirstOrDefaultAsync(l => l.MaLich == _selectedMaLich.Value);

            if (lichKham == null)
            {
                MessageBox.Show("Không tìm thấy thông tin lịch khám cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hộp thoại xác nhận bắt buộc Yes/No
            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lịch khám của bệnh nhân \"{lichKham.TenBenhNhan}\" vào ngày {lichKham.NgayKham:dd/MM/yyyy}?",
                "Xác nhận xóa lịch khám",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _context.LichKhams.Remove(lichKham);
                    await _context.SaveChangesAsync();

                    MessageBox.Show("Xóa lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDanhSachLichKhamAsync();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa lịch khám: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Làm mới form nhập liệu và tải lại danh sách
        /// </summary>
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            await LoadDanhSachLichKhamAsync();
        }

        /// <summary>
        /// Tìm kiếm lịch khám:
        /// Lọc theo khoảng ngày (NgayKham >= TuNgay && NgayKham <= DenNgay) VÀ kết hợp theo Bác sĩ được chọn.
        /// Cập nhật kết quả lên DataGridView lập tức.
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateOnly tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            DateOnly denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu ('Từ ngày') không được lớn hơn ngày kết thúc ('Đến ngày')!", "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var query = _context.LichKhams
                    .Include(x => x.MaBsNavigation)
                    .AsNoTracking()
                    .Where(x => x.NgayKham >= tuNgay && x.NgayKham <= denNgay);

                // Nếu có chọn bác sĩ cụ thể (MaBs > 0)
                if (cboLocBacSi.SelectedValue is int maBs && maBs > 0)
                {
                    query = query.Where(x => x.MaBs == maBs);
                }

                var list = await query
                    .OrderBy(x => x.NgayKham)
                    .ThenBy(x => x.GioKham)
                    .ToListAsync();

                HienThiDuLieuLenGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm lịch khám: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị tất cả lịch khám không lọc
        /// </summary>
        private async void btnTatCa_Click(object sender, EventArgs e)
        {
            cboLocBacSi.SelectedIndex = 0;
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today.AddDays(30);
            await LoadDanhSachLichKhamAsync();
        }

        /// <summary>
        /// Mở form phụ Quản lý Bác sĩ và tự động nạp lại danh sách bác sĩ khi form phụ đóng
        /// </summary>
        private async void btnQuanLyBacSi_Click(object sender, EventArgs e)
        {
            using (var formBs = new FormBacSi())
            {
                formBs.ShowDialog(this);
                // Sau khi quản lý bác sĩ xong, nạp lại ComboBox và Grid
                await LoadDanhSachBacSiAsync();
                await LoadDanhSachLichKhamAsync();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _context?.Dispose();
        }
    }
}
