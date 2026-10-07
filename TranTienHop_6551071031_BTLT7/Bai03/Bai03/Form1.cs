using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai03;
using Bai03.Models;

namespace day_5_10
{
    public partial class Form1 : Form
    {
        private SunriseHomestayDBContext _context;
        private readonly string _imageFolder;
        private string _currentImageFileName = "";
        private int _selectedMaPhong = 0;

        public Form1()
        {
            InitializeComponent();
            _context = new SunriseHomestayDBContext();

            _imageFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(_imageFolder))
            {
                Directory.CreateDirectory(_imageFolder);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadComboBoxLoaiPhong();
            LoadComboBoxTinhTrang();
            LoadDanhSachPhong();
        }

        private void SetupDataGridView()
        {
            dgvPhong.AutoGenerateColumns = false;
            dgvPhong.Columns.Clear();
            dgvPhong.RowTemplate.Height = 60;

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaPhong",
                HeaderText = "Mã phòng",
                Name = "MaPhong",
                Width = 120
            });

            var imgCol = new DataGridViewImageColumn
            {
                DataPropertyName = "Thumbnail",
                HeaderText = "Ảnh",
                Name = "Thumbnail",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            };
            dgvPhong.Columns.Add(imgCol);

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoPhong",
                HeaderText = "Số phòng",
                Name = "SoPhong",
                Width = 120
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TangSo",
                HeaderText = "Tầng",
                Name = "TangSo",
                Width = 120
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenLoai",
                HeaderText = "Loại phòng",
                Name = "TenLoai",
                Width = 120
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GiaMoiDem",
                HeaderText = "Giá/đêm",
                Name = "GiaMoiDem",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    FormatProvider = new CultureInfo("vi-VN")
                },
                Width = 120
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TinhTrang",
                HeaderText = "Tình trạng",
                Name = "TinhTrang",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HinhAnh",
                HeaderText = "HinhAnh",
                Name = "HinhAnh",
                Visible = false
            });

            dgvPhong.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaLoai",
                HeaderText = "MaLoai",
                Name = "MaLoai",
                Visible = false
            });
        }

        public void LoadComboBoxLoaiPhong()
        {
            try
            {
                var dsLoai = _context.LoaiPhongs
                    .OrderBy(x => x.TenLoai)
                    .ToList();

                cboLoaiPhong.DataSource = null;
                cboLoaiPhong.DataSource = dsLoai;
                cboLoaiPhong.DisplayMember = "TenLoai";
                cboLoaiPhong.ValueMember = "MaLoai";

                var dsTimKiem = dsLoai.ToList();
                dsTimKiem.Insert(0, new LoaiPhong { MaLoai = 0, TenLoai = "Lọc theo loại phòng" });

                cboTimLoaiPhong.DataSource = null;
                cboTimLoaiPhong.DataSource = dsTimKiem;
                cboTimLoaiPhong.DisplayMember = "TenLoai";
                cboTimLoaiPhong.ValueMember = "MaLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxTinhTrang()
        {
            string[] tinhTrangList = { "Trống", "Đang ở", "Đang dọn" };

            cboTinhTrang.Items.Clear();
            cboTinhTrang.Items.AddRange(tinhTrangList);
            cboTinhTrang.SelectedIndex = 0;

            cboTimTinhTrang.Items.Clear();
            cboTimTinhTrang.Items.Add("Lọc theo tình trạng");
            cboTimTinhTrang.Items.AddRange(tinhTrangList);
            cboTimTinhTrang.SelectedIndex = 0;
        }

        private Image? LoadImageSafe(string? fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return null;

            string filePath = Path.Combine(_imageFolder, fileName);
            if (!File.Exists(filePath)) return null;

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    return Image.FromStream(memoryStream);
                }
            }
            catch
            {
                return null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.webp;*.bmp)|*.jpg;*.jpeg;*.png;*.webp;*.bmp";
                ofd.Title = "Chọn hình ảnh phòng";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string ext = Path.GetExtension(ofd.FileName);
                        string newFileName = $"{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 6)}{ext}";
                        string destPath = Path.Combine(_imageFolder, newFileName);

                        File.Copy(ofd.FileName, destPath, true);

                        _currentImageFileName = newFileName;

                        picHinhAnh.Image?.Dispose();
                        picHinhAnh.Image = LoadImageSafe(_currentImageFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadDanhSachPhong()
        {
            try
            {
                var phongs = _context.Phongs
                    .Include(p => p.MaLoaiNavigation)
                    .AsNoTracking()
                    .ToList();

                var list = phongs.Select(p => new
                {
                    p.MaPhong,
                    Thumbnail = LoadImageSafe(p.HinhAnh),
                    p.SoPhong,
                    p.TangSo,
                    TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "",
                    GiaMoiDem = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.GiaMoiDem : 0,
                    p.TinhTrang,
                    p.HinhAnh,
                    p.MaLoai
                }).ToList();

                dgvPhong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            _selectedMaPhong = 0;
            txtSoPhong.Clear();
            numTangSo.Value = 1;
            if (cboLoaiPhong.Items.Count > 0) cboLoaiPhong.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            _currentImageFileName = "";

            picHinhAnh.Image?.Dispose();
            picHinhAnh.Image = null;
            txtSoPhong.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadDanhSachPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhongMoi = txtSoPhong.Text.Trim();
            if (_context.Phongs.Any(p => p.SoPhong == soPhongMoi))
            {
                MessageBox.Show("Số phòng này đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var phongMoi = new Phong
                {
                    SoPhong = soPhongMoi,
                    TangSo = (int)numTangSo.Value,
                    MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue),
                    TinhTrang = cboTinhTrang.SelectedItem?.ToString() ?? "Trống",
                    HinhAnh = _currentImageFileName
                };

                _context.Phongs.Add(phongMoi);
                _context.SaveChanges();

                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhongMoi = txtSoPhong.Text.Trim();
            if (_context.Phongs.Any(p => p.SoPhong == soPhongMoi && p.MaPhong != _selectedMaPhong))
            {
                MessageBox.Show("Số phòng này đã bị trùng với một phòng khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var phong = _context.Phongs.Find(_selectedMaPhong);
                if (phong != null)
                {
                    phong.SoPhong = soPhongMoi;
                    phong.TangSo = (int)numTangSo.Value;
                    phong.MaLoai = Convert.ToInt32(cboLoaiPhong.SelectedValue);
                    phong.TinhTrang = cboTinhTrang.SelectedItem?.ToString();
                    phong.HinhAnh = _currentImageFileName;

                    _context.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachPhong();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phòng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    var phong = _context.Phongs.Find(_selectedMaPhong);
                    if (phong != null)
                    {
                        _context.Phongs.Remove(phong);
                        _context.SaveChanges();

                        MessageBox.Show("Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachPhong();
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPhong.Rows[e.RowIndex];
                _selectedMaPhong = Convert.ToInt32(row.Cells["MaPhong"].Value);
                txtSoPhong.Text = row.Cells["SoPhong"].Value?.ToString();
                numTangSo.Value = Convert.ToInt32(row.Cells["TangSo"].Value ?? 1);

                if (row.Cells["MaLoai"].Value != null)
                {
                    cboLoaiPhong.SelectedValue = Convert.ToInt32(row.Cells["MaLoai"].Value);
                }

                if (row.Cells["TinhTrang"].Value != null)
                {
                    cboTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value?.ToString();
                }

                _currentImageFileName = row.Cells["HinhAnh"].Value?.ToString() ?? "";

                picHinhAnh.Image?.Dispose();
                picHinhAnh.Image = LoadImageSafe(_currentImageFileName);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int maLoaiTim = 0;
                if (cboTimLoaiPhong.SelectedValue != null)
                {
                    int.TryParse(cboTimLoaiPhong.SelectedValue.ToString(), out maLoaiTim);
                }

                string? tinhTrangTim = cboTimTinhTrang.SelectedIndex > 0
                    ? cboTimTinhTrang.SelectedItem?.ToString()
                    : null;

                var query = _context.Phongs
                    .Include(p => p.MaLoaiNavigation)
                    .AsNoTracking()
                    .AsQueryable();

                if (maLoaiTim > 0)
                {
                    query = query.Where(p => p.MaLoai == maLoaiTim);
                }

                if (!string.IsNullOrEmpty(tinhTrangTim))
                {
                    query = query.Where(p => p.TinhTrang == tinhTrangTim);
                }

                var listDb = query.ToList();

                var ketQua = listDb.Select(p => new
                {
                    p.MaPhong,
                    Thumbnail = LoadImageSafe(p.HinhAnh),
                    p.SoPhong,
                    p.TangSo,
                    TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "",
                    GiaMoiDem = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.GiaMoiDem : 0,
                    p.TinhTrang,
                    p.HinhAnh,
                    p.MaLoai
                }).ToList();

                dgvPhong.DataSource = ketQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
        {
            using (var formLoai = new QuanLiLoaiPhong())
            {
                formLoai.DataChanged += () =>
                {
                    LoadComboBoxLoaiPhong();
                    LoadDanhSachPhong();
                };

                formLoai.ShowDialog();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }
    }
}
