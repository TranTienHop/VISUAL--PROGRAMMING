using Bai_01.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai_01
{
    public partial class Form1 : Form
    {
        // Đang tải dữ liệu thì không cho SelectionChanged
        // đổ dữ liệu lên các ô nhập.
        private bool dangLoadDuLieu = false;

        public Form1()
        {
            InitializeComponent();

            // Form Load
            Load -= Form1_Load;
            Load += Form1_Load;

            // DataGridView
            dgvTheLoai.SelectionChanged -= dgvTheLoai_SelectionChanged;
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;

            // Tự tìm và gắn 5 nút theo Text
            GanSuKienButton();
        }

        // =========================================================
        // TÌM BUTTON THEO TEXT
        // =========================================================
        private Button? TimButton(Control parent, string text)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button &&
                    button.Text.Trim() == text)
                {
                    return button;
                }

                if (control.HasChildren)
                {
                    Button? result = TimButton(control, text);

                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        // =========================================================
        // GẮN SỰ KIỆN CHO BUTTON
        // =========================================================
        private void GanSuKienButton()
        {
            Button? btnThem = TimButton(this, "Thêm");
            Button? btnSua = TimButton(this, "Sửa");
            Button? btnXoa = TimButton(this, "Xóa");
            Button? btnLamMoi = TimButton(this, "Làm mới");
            Button? btnTimKiem = TimButton(this, "Tìm kiếm");

            if (btnThem != null)
            {
                btnThem.Click -= button1_Click;
                btnThem.Click += button1_Click;
            }

            if (btnSua != null)
            {
                btnSua.Click -= button2_Click;
                btnSua.Click += button2_Click;
            }

            if (btnXoa != null)
            {
                btnXoa.Click -= button3_Click;
                btnXoa.Click += button3_Click;
            }

            if (btnLamMoi != null)
            {
                btnLamMoi.Click -= button4_Click;
                btnLamMoi.Click += button4_Click;
            }

            if (btnTimKiem != null)
            {
                btnTimKiem.Click -= button5_Click;
                btnTimKiem.Click += button5_Click;
            }
        }

        // =========================================================
        // LOAD FORM
        // =========================================================
        private async void Form1_Load(object? sender, EventArgs e)
        {
            // Mã tự sinh -> chỉ đọc
            txtMaTL.ReadOnly = true;

            // Cấu hình DataGridView
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AutoGenerateColumns = true;
            dgvTheLoai.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            await LoadDataAsync();

            // Khi mở Form: không chọn dòng
            ClearInput();
            BoChonDong();
        }

        // =========================================================
        // LOAD DỮ LIỆU
        // =========================================================
        private async Task LoadDataAsync()
        {
            try
            {
                dangLoadDuLieu = true;

                using var context = new TriThucBooksContext();

                var data = await context.TheLoaiSach
                    .AsNoTracking()
                    .OrderBy(x => x.MaTL)
                    .ToListAsync();

                dgvTheLoai.DataSource = data;

                // Đổi tên cột
                if (dgvTheLoai.Columns["MaTL"] != null)
                {
                    dgvTheLoai.Columns["MaTL"]!
                        .HeaderText = "Mã TL";
                }

                if (dgvTheLoai.Columns["TenTheLoai"] != null)
                {
                    dgvTheLoai.Columns["TenTheLoai"]!
                        .HeaderText = "Tên thể loại";
                }

                if (dgvTheLoai.Columns["MoTa"] != null)
                {
                    dgvTheLoai.Columns["MoTa"]!
                        .HeaderText = "Mô tả";
                }

                if (dgvTheLoai.Columns["SoLuongSach"] != null)
                {
                    dgvTheLoai.Columns["SoLuongSach"]!
                        .HeaderText = "Số lượng sách";
                }

                if (dgvTheLoai.Columns["NgayTao"] != null)
                {
                    dgvTheLoai.Columns["NgayTao"]!
                        .HeaderText = "Ngày tạo";

                    dgvTheLoai.Columns["NgayTao"]!
                        .DefaultCellStyle.Format =
                        "dd/MM/yyyy HH:mm:ss";
                }

                var fillWeights = new Dictionary<string, float>
                {
                    ["MaTL"] = 40,
                    ["TenTheLoai"] = 90,
                    ["MoTa"] = 220,
                    ["SoLuongSach"] = 80,
                    ["NgayTao"] = 100
                };

                foreach (var (name, weight) in fillWeights)
                {
                    if (dgvTheLoai.Columns[name] != null)
                        dgvTheLoai.Columns[name]!.FillWeight = weight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu!\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangLoadDuLieu = false;
            }
        }

        // =========================================================
        // CHỌN DÒNG -> ĐỔ DỮ LIỆU LÊN FORM
        // =========================================================
        private void dgvTheLoai_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            // Đang load lại DataGridView
            if (dangLoadDuLieu)
                return;

            if (dgvTheLoai.CurrentRow?.DataBoundItem
                is TheLoaiSach item)
            {
                txtMaTL.Text =
                    item.MaTL.ToString();

                txtTenTheLoai.Text =
                    item.TenTheLoai;

                txtMoTa.Text =
                    item.MoTa ?? "";

                lblNgayTaoValue.Text =
                    item.NgayTao.ToString(
                        "dd/MM/yyyy HH:mm:ss");
            }
        }

        // =========================================================
        // THÊM
        // =========================================================
        private async void button1_Click(
            object? sender,
            EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(
                txtTenTheLoai.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên thể loại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();
                return;
            }

            string ten =
                txtTenTheLoai.Text.Trim();

            string moTa =
                txtMoTa.Text.Trim();

            try
            {
                using var context =
                    new TriThucBooksContext();

                // Kiểm tra trùng
                bool tonTai =
                    await context.TheLoaiSach
                    .AnyAsync(x =>
                        x.TenTheLoai == ten);

                if (tonTai)
                {
                    MessageBox.Show(
                        "Tên thể loại đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTenTheLoai.Focus();
                    return;
                }

                // Tạo mới
                var item = new TheLoaiSach
                {
                    TenTheLoai = ten,

                    MoTa =
                        string.IsNullOrWhiteSpace(moTa)
                            ? null
                            : moTa,

                    SoLuongSach = 0
                };

                // Add
                context.TheLoaiSach.Add(item);

                // Save
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Thêm thể loại thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Load lại
                await LoadDataAsync();

                // Xóa ô nhập
                ClearInput();

                // Không chọn dòng
                BoChonDong();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể thêm dữ liệu!\n"
                    + "Có thể tên thể loại đã tồn tại.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SỬA
        // =========================================================
        private async void button2_Click(
            object? sender,
            EventArgs e)
        {
            // Kiểm tra mã
            if (!int.TryParse(
                txtMaTL.Text,
                out int maTL))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Kiểm tra tên
            if (string.IsNullOrWhiteSpace(
                txtTenTheLoai.Text))
            {
                MessageBox.Show(
                    "Tên thể loại không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenTheLoai.Focus();
                return;
            }

            string tenMoi =
                txtTenTheLoai.Text.Trim();

            string moTaMoi =
                txtMoTa.Text.Trim();

            try
            {
                using var context =
                    new TriThucBooksContext();

                // Tìm bản ghi
                var item =
                    await context.TheLoaiSach
                    .FirstOrDefaultAsync(
                        x => x.MaTL == maTL);

                if (item == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thể loại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Kiểm tra trùng tên
                bool trungTen =
                    await context.TheLoaiSach
                    .AnyAsync(x =>
                        x.TenTheLoai == tenMoi
                        && x.MaTL != maTL);

                if (trungTen)
                {
                    MessageBox.Show(
                        "Tên thể loại đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTenTheLoai.Focus();
                    return;
                }

                // Cập nhật
                item.TenTheLoai =
                    tenMoi;

                item.MoTa =
                    string.IsNullOrWhiteSpace(moTaMoi)
                        ? null
                        : moTaMoi;

                // Save
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Cập nhật thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Load lại
                await LoadDataAsync();

                ClearInput();
                BoChonDong();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể cập nhật dữ liệu!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra!\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // XÓA
        // =========================================================
        private async void button3_Click(
            object? sender,
            EventArgs e)
        {
            // Kiểm tra đã chọn
            if (!int.TryParse(
                txtMaTL.Text,
                out int maTL))
            {
                MessageBox.Show(
                    "Vui lòng chọn thể loại cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Xác nhận
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa "
                    + "thể loại này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using var context =
                    new TriThucBooksContext();

                // Tìm bản ghi
                var item =
                    await context.TheLoaiSach
                    .FirstOrDefaultAsync(
                        x => x.MaTL == maTL);

                if (item == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy thể loại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Xóa
                context.TheLoaiSach.Remove(item);

                // Save
                await context.SaveChangesAsync();

                MessageBox.Show(
                    "Xóa thể loại thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Load lại
                await LoadDataAsync();

                ClearInput();
                BoChonDong();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa thể loại này "
                    + "vì đang được sách khác tham chiếu!",
                    "Lỗi ràng buộc",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra khi xóa!\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LÀM MỚI
        // =========================================================
        private async void button4_Click(
            object? sender,
            EventArgs e)
        {
            txtTimKiem.Clear();

            await LoadDataAsync();

            ClearInput();

            BoChonDong();
        }

        // =========================================================
        // TÌM KIẾM
        // =========================================================
        private async void button5_Click(
            object? sender,
            EventArgs e)
        {
            string keyword =
                txtTimKiem.Text.Trim();

            try
            {
                // Nếu rỗng -> hiện toàn bộ
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    await LoadDataAsync();

                    ClearInput();
                    BoChonDong();

                    return;
                }

                using var context =
                    new TriThucBooksContext();

                var data =
                    await context.TheLoaiSach
                    .AsNoTracking()
                    .Where(x =>
                        x.TenTheLoai.Contains(keyword))
                    .OrderBy(x => x.MaTL)
                    .ToListAsync();

                dangLoadDuLieu = true;

                dgvTheLoai.DataSource = data;

                dangLoadDuLieu = false;

                if (data.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy thể loại phù hợp!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                ClearInput();
                BoChonDong();
            }
            catch (Exception ex)
            {
                dangLoadDuLieu = false;

                MessageBox.Show(
                    "Lỗi tìm kiếm!\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // XÓA TRẮNG CÁC Ô
        // =========================================================
        private void ClearInput()
        {
            txtMaTL.Clear();
            txtTenTheLoai.Clear();
            txtMoTa.Clear();

            lblNgayTaoValue.Text = "";
        }

        // =========================================================
        // BỎ CHỌN DÒNG TRÊN DATAGRIDVIEW
        // =========================================================
        private void BoChonDong()
        {
            try
            {
                dgvTheLoai.CurrentCell = null;
                dgvTheLoai.ClearSelection();
            }
            catch
            {
                // Không làm gì nếu DataGridView chưa sẵn sàng
            }
        }
    }
}