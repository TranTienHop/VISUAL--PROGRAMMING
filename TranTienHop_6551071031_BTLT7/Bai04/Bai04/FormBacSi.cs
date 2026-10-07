using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai04.Models;

namespace Bai04
{
    public partial class FormBacSi : Form
    {
        private AnKhangClinicDBContext _context;
        private int? _selectedMaBs = null;

        public FormBacSi()
        {
            InitializeComponent();
            _context = new AnKhangClinicDBContext();
        }

        private async void FormBacSi_Load(object sender, EventArgs e)
        {
            await LoadDanhSachBacSiAsync();
        }

        private async Task LoadDanhSachBacSiAsync()
        {
            try
            {
                var list = await _context.BacSis
                    .AsNoTracking()
                    .Select(b => new
                    {
                        b.MaBs,
                        b.HoTen,
                        b.ChuyenKhoa,
                        b.Sdt,
                        SoLichKham = b.LichKhams.Count
                    })
                    .OrderBy(b => b.MaBs)
                    .ToListAsync();

                dgvBacSi.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBacSi.Rows.Count) return;

            var row = dgvBacSi.Rows[e.RowIndex];
            if (row.Cells["colMaBs"]?.Value != null && int.TryParse(row.Cells["colMaBs"].Value?.ToString(), out int maBs))
            {
                _selectedMaBs = maBs;
                txtMaBs.Text = maBs.ToString();
                txtHoTen.Text = row.Cells["colHoTen"]?.Value?.ToString() ?? "";
                txtChuyenKhoa.Text = row.Cells["colChuyenKhoa"]?.Value?.ToString() ?? "";
                txtSdt.Text = row.Cells["colSdt"]?.Value?.ToString() ?? "";
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bác sĩ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtChuyenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập chuyên khoa của bác sĩ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChuyenKhoa.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            _selectedMaBs = null;
            txtMaBs.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSdt.Clear();
            dgvBacSi.ClearSelection();
            txtHoTen.Focus();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var bacSi = new BacSi
                {
                    HoTen = txtHoTen.Text.Trim(),
                    ChuyenKhoa = txtChuyenKhoa.Text.Trim(),
                    Sdt = txtSdt.Text.Trim()
                };

                _context.BacSis.Add(bacSi);
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDanhSachBacSiAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaBs == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ từ danh sách để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                var bacSi = await _context.BacSis.FindAsync(_selectedMaBs.Value);
                if (bacSi == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bacSi.HoTen = txtHoTen.Text.Trim();
                bacSi.ChuyenKhoa = txtChuyenKhoa.Text.Trim();
                bacSi.Sdt = txtSdt.Text.Trim();

                await _context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDanhSachBacSiAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaBs == null)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ từ danh sách để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bacSi = await _context.BacSis.FindAsync(_selectedMaBs.Value);
            if (bacSi == null)
            {
                MessageBox.Show("Không tìm thấy bác sĩ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra ràng buộc khóa ngoại với bảng LichKham
            bool coLichKham = await _context.LichKhams.AnyAsync(l => l.MaBs == _selectedMaBs.Value);
            if (coLichKham)
            {
                MessageBox.Show($"Bác sĩ \"{bacSi.HoTen}\" đang có lịch khám bệnh liên kết. Không thể xóa!", 
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa bác sĩ \"{bacSi.HoTen}\" (Chuyên khoa: {bacSi.ChuyenKhoa})?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _context.BacSis.Remove(bacSi);
                    await _context.SaveChangesAsync();

                    MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDanhSachBacSiAsync();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _context?.Dispose();
        }
    }
}
