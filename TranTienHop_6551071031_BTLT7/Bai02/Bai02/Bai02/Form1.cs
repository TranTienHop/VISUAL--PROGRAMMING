using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai01.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private FitZoneDbContext _context = null!;
        private int _selectedMaHV = 0; // Lưu MaHV của dòng đang được chọn

        public Form1()
        {
            InitializeComponent();
        }

        #region 1. KHỞI TẠO & TẢI DỮ LIỆU

        private async void Form1_Load(object sender, EventArgs e)
        {
            _context = new FitZoneDbContext();

            // Khởi tạo ComboBox Hạng thành viên nhập liệu
            cboHangThanhVien.Items.Clear();
            cboHangThanhVien.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboHangThanhVien.SelectedIndex = 0;

            // Khởi tạo ComboBox Tìm kiếm hạng
            cboTimKiemHang.Items.Clear();
            cboTimKiemHang.Items.AddRange(new object[] { "Tất cả", "Basic", "VIP", "Premium" });
            cboTimKiemHang.SelectedIndex = 0;

            // Cấu hình các cột hiển thị DataGridView
            SetupDataGridView();

            // Tải dữ liệu ban đầu
            await LoadDataAsync();
        }

        private void SetupDataGridView()
        {
            dgvHoiVien.AutoGenerateColumns = false;
            dgvHoiVien.Columns.Clear();

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaHV",
                HeaderText = "Mã HV",
                Width = 60
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HoTen",
                HeaderText = "Họ tên",
                Width = 130
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GioiTinhText",
                HeaderText = "Giới tính",
                Width = 70
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgaySinhText",
                HeaderText = "Ngày sinh",
                Width = 85
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SDT",
                HeaderText = "SĐT",
                Width = 100
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HangThanhVien",
                HeaderText = "Hạng thành viên",
                Width = 110
            });

            dgvHoiVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrangThaiText",
                HeaderText = "Trạng thái",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        /// <summary>
        /// Tải toàn bộ danh sách hội viên lên DataGridView dạng Async
        /// </summary>
        private async Task LoadDataAsync()
        {
            try
            {
                var list = await _context.HoiViens
                    .AsNoTracking()
                    .OrderBy(h => h.MaHV)
                    .Select(h => new
                    {
                        h.MaHV,
                        h.HoTen,
                        h.GioiTinh,
                        GioiTinhText = h.GioiTinh ? "Nam" : "Nữ",
                        h.NgaySinh,
                        NgaySinhText = h.NgaySinh.ToString("dd/MM/yyyy"),
                        h.SDT,
                        h.Email,
                        h.HangThanhVien,
                        h.TrangThai,
                        TrangThaiText = h.TrangThai ? "Đang hoạt động" : "Tạm ngưng"
                    })
                    .ToListAsync();

                dgvHoiVien.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 2. ĐỔ DỮ LIỆU LÊN CONTROL (CELLCLICK)

        private async void dgvHoiVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvHoiVien.Rows[e.RowIndex];
                if (row.Cells[0].Value == null) return;

                _selectedMaHV = Convert.ToInt32(row.Cells[0].Value);

                var hv = await _context.HoiViens.FindAsync(_selectedMaHV);
                if (hv != null)
                {
                    txtHoTen.Text = hv.HoTen;
                    txtSDT.Text = hv.SDT ?? "";
                    txtEmail.Text = hv.Email ?? "";

                    if (hv.GioiTinh)
                        radNam.Checked = true;
                    else
                        radNu.Checked = true;

                    dtpNgaySinh.Value = hv.NgaySinh.ToDateTime(TimeOnly.MinValue);

                    cboHangThanhVien.SelectedItem = hv.HangThanhVien;
                    chkTrangThai.Checked = hv.TrangThai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy chi tiết hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 3. VALIDATION DỮ LIỆU ĐẦU VÀO

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu với thông báo riêng biệt cho từng trường
        /// </summary>
        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            // 1. Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorMessage = "Họ tên hội viên không được để trống!";
                txtHoTen.Focus();
                return false;
            }

            // 2. Kiểm tra Số điện thoại (chỉ chứa chữ số và độ dài từ 9 đến 11 ký tự)
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorMessage = "Số điện thoại không được để trống!";
                txtSDT.Focus();
                return false;
            }
            if (!Regex.IsMatch(sdt, @"^[0-9]{9,11}$"))
            {
                errorMessage = "Số điện thoại chỉ được chứa chữ số và có độ dài từ 9 đến 11 ký tự!";
                txtSDT.Focus();
                return false;
            }

            // 3. Kiểm tra Email
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email không được để trống!";
                txtEmail.Focus();
                return false;
            }
            if (!email.Contains("@") || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "Email không đúng định dạng hợp lệ (ví dụ: example@gmail.com)!";
                txtEmail.Focus();
                return false;
            }

            // 4. Kiểm tra Tuổi hội viên (>= 15 tuổi)
            var today = DateTime.Today;
            var birthDate = dtpNgaySinh.Value.Date;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;

            if (age < 15)
            {
                errorMessage = $"Hội viên phải từ 15 tuổi trở lên (Tuổi tính theo ngày sinh hiện tại: {age})!";
                dtpNgaySinh.Focus();
                return false;
            }

            // 5. Kiểm tra Hạng thành viên
            if (cboHangThanhVien.SelectedItem == null)
            {
                errorMessage = "Vui lòng chọn hạng thành viên!";
                cboHangThanhVien.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region 4. CÁC THAO TÁC CRUD

        // THÊM HỘI VIÊN
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newHv = new HoiVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    SDT = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    GioiTinh = radNam.Checked,
                    NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value),
                    HangThanhVien = cboHangThanhVien.SelectedItem?.ToString() ?? "Basic",
                    TrangThai = chkTrangThai.Checked,
                    NgayDangKy = DateTime.Now
                };

                _context.HoiViens.Add(newHv);
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm mới hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỬA HỘI VIÊN
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaHV <= 0)
            {
                MessageBox.Show("Vui lòng chọn một hội viên trong bảng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var hv = await _context.HoiViens.FindAsync(_selectedMaHV);
                if (hv == null)
                {
                    MessageBox.Show("Không tìm thấy hội viên cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hv.HoTen = txtHoTen.Text.Trim();
                hv.SDT = txtSDT.Text.Trim();
                hv.Email = txtEmail.Text.Trim();
                hv.GioiTinh = radNam.Checked;
                hv.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                hv.HangThanhVien = cboHangThanhVien.SelectedItem?.ToString() ?? "Basic";
                hv.TrangThai = chkTrangThai.Checked;

                await _context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // XÓA HỘI VIÊN
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaHV <= 0)
            {
                MessageBox.Show("Vui lòng chọn một hội viên trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa hội viên có Mã HV: {_selectedMaHV} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var hv = await _context.HoiViens.FindAsync(_selectedMaHV);
                    if (hv != null)
                    {
                        _context.HoiViens.Remove(hv);
                        await _context.SaveChangesAsync();

                        MessageBox.Show("Đã xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        await LoadDataAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // LÀM MỚI FORM
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            _ = LoadDataAsync();
        }

        private void ResetForm()
        {
            _selectedMaHV = 0;
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            cboHangThanhVien.SelectedIndex = 0;
            chkTrangThai.Checked = true;

            txtTimKiemTen.Clear();
            cboTimKiemHang.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        #endregion

        #region 5. TÌM KIẾM ĐỒNG THỜI NHIỀU ĐIỀU KIỆN (LINQ)

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiemTen.Text.Trim();
                string selectedHang = cboTimKiemHang.SelectedItem?.ToString() ?? "Tất cả";

                IQueryable<HoiVien> query = _context.HoiViens.AsNoTracking();

                // Điều kiện 1: Tên hội viên (gần đúng)
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(x => x.HoTen.Contains(keyword));
                }

                // Điều kiện 2: Hạng thành viên
                if (selectedHang != "Tất cả")
                {
                    query = query.Where(x => x.HangThanhVien == selectedHang);
                }

                var result = await query
                    .OrderBy(h => h.MaHV)
                    .Select(h => new
                    {
                        h.MaHV,
                        h.HoTen,
                        h.GioiTinh,
                        GioiTinhText = h.GioiTinh ? "Nam" : "Nữ",
                        h.NgaySinh,
                        NgaySinhText = h.NgaySinh.ToString("dd/MM/yyyy"),
                        h.SDT,
                        h.Email,
                        h.HangThanhVien,
                        h.TrangThai,
                        TrangThaiText = h.TrangThai ? "Đang hoạt động" : "Tạm ngưng"
                    })
                    .ToListAsync();

                dgvHoiVien.DataSource = result;

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hội viên nào phù hợp với điều kiện tìm kiếm!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
