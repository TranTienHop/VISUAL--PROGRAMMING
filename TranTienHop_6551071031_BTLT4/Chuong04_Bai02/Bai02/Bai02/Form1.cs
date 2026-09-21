using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai02

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cấu hình các thuộc tính của ToolTip1 theo yêu cầu bài toán
            ConfigureToolTip();
        }

        private void ConfigureToolTip()
        {
            toolTip1.AutoPopDelay = 5000;  // Hiển thị tối đa 5 giây (5000ms) rồi tự ẩn
            toolTip1.InitialDelay = 500;   // Sau khi rê chuột vào 0.5 giây (500ms) mới hiện ToolTip
            toolTip1.ReshowDelay = 100;    // Thời gian chờ để hiện ToolTip khi di chuyển sang Control khác (100ms)
            toolTip1.ShowAlways = true;    // Luôn hiển thị ToolTip kể cả khi Form không ở trạng thái Active
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                txtSDT.BackColor = SystemColors.Window;
                return;
            }

            txtSDT.BackColor = System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, "^\\d{10}$")
                ? SystemColors.Window
                : Color.MistyRose;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Không cần xử lý bổ sung; giữ lại để tương thích với event đã đăng ký trong Designer.
        }

        // Sự kiện Click cho Button "Đăng ký"
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu và loại bỏ khoảng trắng thừa ở 2 đầu
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra tính hợp lệ của thông tin bắt buộc
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Dừng xử lý nếu thiếu thông tin
            }

            // Lấy thông tin từ các control còn lại
            string goiTap = cboGoiTap.SelectedItem?.ToString() ?? "Chưa chọn";
            int soBuoi = (int)numSoBuoiTuan.Value;

            // Tổng hợp thông tin đăng ký
            string thongTin = $"ĐĂNG KÝ HỘI VIÊN THÀNH CÔNG!\n\n" +
                              $"• Họ tên: {hoTen}\n" +
                              $"• SĐT: {sdt}\n" +
                              $"• Gói tập: {goiTap}\n" +
                              $"• Số buổi/tuần: {soBuoi} buổi";

            // Hiển thị thông báo tóm tắt
            MessageBox.Show(
                thongTin,
                "Xác nhận thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSoBuoiTuan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}