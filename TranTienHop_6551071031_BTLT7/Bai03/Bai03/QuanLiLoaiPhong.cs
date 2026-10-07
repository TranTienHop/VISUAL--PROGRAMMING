using System;
using System.Linq;
using System.Windows.Forms;
using Bai03.Models;

namespace Bai03
{
    public partial class QuanLiLoaiPhong : Form
    {
        private SunriseHomestayDBContext _context;
        private int _selectedMaLoai = 0;

        public event Action? DataChanged;

        public QuanLiLoaiPhong()
        {
            InitializeComponent();
            _context = new SunriseHomestayDBContext();
        }

        private void QuanLiLoaiPhong_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadData();
        }

        private void SetupDataGridView()
        {
            dgvLoaiPhong.AutoGenerateColumns = false;
            dgvLoaiPhong.Columns.Clear();

            dgvLoaiPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaLoai",
                HeaderText = "Mã Loại",
                Name = "MaLoai",
                Width = 80
            });

            dgvLoaiPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenLoai",
                HeaderText = "Tên Loại Phòng",
                Name = "TenLoai",
                Width = 180
            });

            dgvLoaiPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GiaMoiDem",
                HeaderText = "Giá/Đêm (VNĐ)",
                Name = "GiaMoiDem",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                Width = 140
            });

            dgvLoaiPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MoTa",
                HeaderText = "Mô Tả",
                Name = "MoTa",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void LoadData()
        {
            try
            {
                var list = _context.LoaiPhongs
                    .Select(lp => new
                    {
                        lp.MaLoai,
                        lp.TenLoai,
                        lp.GiaMoiDem,
                        lp.MoTa
                    })
                    .ToList();

                dgvLoaiPhong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            _selectedMaLoai = 0;
            txtTenLoai.Clear();
            numGiaMoiDem.Value = 0;
            txtMoTa.Clear();
            txtTenLoai.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var loaiPhong = new LoaiPhong
                {
                    TenLoai = txtTenLoai.Text.Trim(),
                    GiaMoiDem = numGiaMoiDem.Value,
                    MoTa = txtMoTa.Text.Trim()
                };

                _context.LoaiPhongs.Add(loaiPhong);
                _context.SaveChanges();

                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
                DataChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaLoai == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var loaiPhong = _context.LoaiPhongs.Find(_selectedMaLoai);
                if (loaiPhong != null)
                {
                    loaiPhong.TenLoai = txtTenLoai.Text.Trim();
                    loaiPhong.GiaMoiDem = numGiaMoiDem.Value;
                    loaiPhong.MoTa = txtMoTa.Text.Trim();

                    _context.SaveChanges();

                    MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                    DataChanged?.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaLoai == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                "Bạn có chắc muốn xóa loại phòng này? Tất cả các phòng thuộc loại này cũng sẽ bị xóa!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    var loaiPhong = _context.LoaiPhongs.Find(_selectedMaLoai);
                    if (loaiPhong != null)
                    {
                        _context.LoaiPhongs.Remove(loaiPhong);
                        _context.SaveChanges();

                        MessageBox.Show("Đã xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearInputs();
                        DataChanged?.Invoke();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLoaiPhong.Rows[e.RowIndex];
                _selectedMaLoai = Convert.ToInt32(row.Cells["MaLoai"].Value);
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
                numGiaMoiDem.Value = Convert.ToDecimal(row.Cells["GiaMoiDem"].Value ?? 0);
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DataChanged?.Invoke();
            _context.Dispose();
            base.OnFormClosed(e);
        }
    }
}
