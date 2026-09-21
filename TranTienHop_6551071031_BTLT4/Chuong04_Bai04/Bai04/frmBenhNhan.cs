using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTCh4_Bai4
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            // Bật thông báo test xem nút có nhận lệnh không
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!");
                return;
            }

            string thongTin = $"{txtHoTen.Text} - {nudTuoi.Value} tuổi - Triệu chứng: {txtTrieuChung.Text}";

            // Lưu vào List
            danhSachBenhNhan.Add(thongTin);

            // Hiển thị ra ListBox
            lstDanhSach.Items.Add(thongTin);

            // Xóa rỗng các ô
            txtHoTen.Clear();
            txtTrieuChung.Clear();
            nudTuoi.Value = 0;
            txtHoTen.Focus();
        }
    }
}