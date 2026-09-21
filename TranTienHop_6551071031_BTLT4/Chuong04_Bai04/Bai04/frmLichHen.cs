using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTCh4_Bai4
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân hẹn lịch!");
                return;
            }

            string thongTinHen = $"{txtTenBenhNhan.Text} - Hẹn lúc: {dtpNgayHen.Value:dd/MM/yyyy HH:mm}";

            // Lưu vào List và hiển thị ListBox
            danhSachLichHen.Add(thongTinHen);
            lstLichHen.Items.Add(thongTinHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
