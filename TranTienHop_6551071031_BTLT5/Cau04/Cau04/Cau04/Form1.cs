namespace Câu4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;
        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn liên hệ chưa
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lưu lại vị trí item đang sửa
            _indexDangSua = lstLienHe.SelectedIndex;

            // Lấy liên hệ đang chọn
            string lienHe = lstLienHe.Items[_indexDangSua].ToString();

            // Tìm vị trí của chuỗi " - "
            int viTri = lienHe.IndexOf(" - ");

            // Nếu dữ liệu không đúng định dạng
            if (viTri == -1)
            {
                MessageBox.Show(
                    "Dữ liệu liên hệ không hợp lệ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                _indexDangSua = -1;
                return;
            }

            // Lấy tên
            string ten = lienHe.Substring(0, viTri);

            // Lấy số điện thoại
            string sdt = lienHe.Substring(viTri + 3);

            // Đưa dữ liệu lên TextBox
            txtTen.Text = ten;
            txtSDT.Text = sdt;

            // Focus vào ô Tên
            txtTen.Focus();

            // Bôi đen tên để nhập tên mới
            txtTen.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra tên
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTen.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSDT.Focus();
                return;
            }

            // =====================================================
            // NẾU ĐANG SỬA
            // =====================================================
            if (_indexDangSua >= 0)
            {
                string lienHeMoi = ten + " - " + sdt;

                // Cập nhật lại item cũ
                lstLienHe.Items[_indexDangSua] = lienHeMoi;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Trở lại chế độ thêm mới
                _indexDangSua = -1;

                // Xóa TextBox
                txtTen.Clear();
                txtSDT.Clear();

                txtTen.Focus();

                return;
            }

            // =====================================================
            // NẾU ĐANG THÊM MỚI
            // =====================================================
            string lienHe = ten + " - " + sdt;

            lstLienHe.Items.Add(lienHe);

            MessageBox.Show(
                "Thêm thành công",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Xóa TextBox
            txtTen.Clear();
            txtSDT.Clear();

            txtTen.Focus();
        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn liên hệ chưa
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lấy vị trí dòng đang chọn
            int index = lstLienHe.SelectedIndex;

            // Lấy nội dung liên hệ
            string lienHe = lstLienHe.Items[index].ToString();

            // Tách tên ra khỏi chuỗi
            int viTri = lienHe.IndexOf(" - ");

            string ten;

            if (viTri >= 0)
            {
                ten = lienHe.Substring(0, viTri);
            }
            else
            {
                ten = lienHe;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " +
                ten +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Yes
            if (ketQua == DialogResult.Yes)
            {
                // Xóa khỏi ListBox
                lstLienHe.Items.RemoveAt(index);

                // Nếu đang ở chế độ sửa thì hủy
                _indexDangSua = -1;

                // Xóa dữ liệu trong TextBox
                txtTen.Clear();
                txtSDT.Clear();

                // Thông báo
                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // Nếu chọn No:
            // Không làm gì, liên hệ vẫn giữ nguyên
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem TextBox còn dữ liệu chưa lưu hay không
            bool coDuLieuChuaLuu =
                !string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text);

            // Nếu cả hai ô đều trống thì cho đóng luôn
            if (!coDuLieuChuaLuu)
            {
                return;
            }

            // Hiện hộp thoại xác nhận
            DialogResult ketQua = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                "Cảnh báo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            // ==========================================
            // YES -> cho phép thoát
            // ==========================================
            if (ketQua == DialogResult.Yes)
            {
                return;
            }

            // ==========================================
            // NO -> xóa TextBox rồi cho thoát
            // ==========================================
            if (ketQua == DialogResult.No)
            {
                txtTen.Clear();
                txtSDT.Clear();

                return;
            }

            // ==========================================
            // CANCEL -> không cho Form đóng
            // ==========================================
            if (ketQua == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
