using System;
using System.Globalization;
using System.Windows.Forms;

namespace Câu3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();

            // Đăng ký sự kiện Enter cho tất cả TextBox
            DangKyEnterChuyenField();

            // Khi focus vào ô điểm thì bôi đen toàn bộ
            txtToan.Enter += txtDiem_Enter;
            txtVan.Enter += txtDiem_Enter;
            txtAnh.Enter += txtDiem_Enter;

            // Đặt thứ tự Tab
            txtMaHS.TabIndex = 0;
            txtHoTen.TabIndex = 1;
            txtToan.TabIndex = 2;
            txtVan.TabIndex = 3;
            txtAnh.TabIndex = 4;
            btnLuu.TabIndex = 5;
            btnXoaTrang.TabIndex = 6;

            // Sự kiện nút
            btnLuu.Click += btnLuu_Click;
            btnXoaTrang.Click += btnXoaTrang_Click;

            // Focus vào Mã HS
            this.Shown += FormNhapDiem_Shown;
        }

        // =========================================================
        // FOCUS VÀO Ô MÃ HS KHI FORM HIỆN
        // =========================================================
        private void FormNhapDiem_Shown(object? sender, EventArgs e)
        {
            txtMaHS.Focus();
        }

        // =========================================================
        // ĐĂNG KÝ ENTER CHUYỂN FIELD
        // =========================================================
        private void DangKyEnterChuyenField()
        {
            TextBox[] textBoxes =
            {
                txtMaHS,
                txtHoTen,
                txtToan,
                txtVan,
                txtAnh
            };

            foreach (TextBox txt in textBoxes)
            {
                txt.KeyPress += TextBox_KeyPress;
            }
        }

        // =========================================================
        // XỬ LÝ PHÍM ENTER
        // =========================================================
        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // Nếu đang ở Điểm Anh -> Lưu
                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else if (sender is Control control)
                {
                    // Chuyển sang ô tiếp theo
                    SelectNextControl(
                        control,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        // =========================================================
        // KHI VÀO Ô ĐIỂM -> BÔI ĐEN TOÀN BỘ
        // =========================================================
        private void txtDiem_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        // =========================================================
        // HÀM ĐỔI CHUỖI THÀNH DECIMAL
        // Hỗ trợ cả 8.5 và 8,5
        // =========================================================
        private bool TryParseDiem(string text, out decimal diem)
        {
            text = text.Trim().Replace(',', '.');

            return decimal.TryParse(
                text,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out diem
            );
        }

        // =========================================================
        // NÚT LƯU
        // =========================================================
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            decimal toan;
            decimal van;
            decimal anh;

            // -----------------------------------------------------
            // KIỂM TRA ĐIỂM TOÁN
            // -----------------------------------------------------
            if (!TryParseDiem(txtToan.Text, out toan))
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải là số."
                );

                hopLe = false;
            }
            else if (toan < 0 || toan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải từ 0.0 đến 10.0."
                );

                hopLe = false;
            }

            // -----------------------------------------------------
            // KIỂM TRA ĐIỂM VĂN
            // -----------------------------------------------------
            if (!TryParseDiem(txtVan.Text, out van))
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải là số."
                );

                hopLe = false;
            }
            else if (van < 0 || van > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải từ 0.0 đến 10.0."
                );

                hopLe = false;
            }

            // -----------------------------------------------------
            // KIỂM TRA ĐIỂM ANH
            // -----------------------------------------------------
            if (!TryParseDiem(txtAnh.Text, out anh))
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải là số."
                );

                hopLe = false;
            }
            else if (anh < 0 || anh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải từ 0.0 đến 10.0."
                );

                hopLe = false;
            }

            // Có lỗi -> không lưu
            if (!hopLe)
            {
                return;
            }

            // -----------------------------------------------------
            // TẠO DÒNG DỮ LIỆU
            // -----------------------------------------------------
            string dong =
                $"{txtMaHS.Text} | {txtHoTen.Text} | " +
                $"T:{toan:0.0} V:{van:0.0} A:{anh:0.0}";

            // Thêm vào ListBox
            lstDanhSach.Items.Add(dong);

            // Xóa trắng
            XoaTrang();

            // Quay về Mã HS
            txtMaHS.Focus();
        }

        // =========================================================
        // NÚT XÓA TRẮNG
        // =========================================================
        private void btnXoaTrang_Click(object? sender, EventArgs e)
        {
            XoaTrang();
            txtMaHS.Focus();
        }

        // =========================================================
        // HÀM XÓA TRẮNG
        // =========================================================
        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();
        }
    }
}