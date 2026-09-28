using System;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    public partial class FormBanVe : Form
    {
        private const string GiaVe = "75.000đ";

        public FormBanVe()
        {
            InitializeComponent();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                CanhBao("Vui lòng nhập tên khách!", txtTenKhach);
                return;
            }
            if (cboPhim.SelectedIndex < 0)
            {
                CanhBao("Vui lòng chọn phim!", cboPhim);
                return;
            }
            if (cboSuatChieu.SelectedIndex < 0)
            {
                CanhBao("Vui lòng chọn suất chiếu!", cboSuatChieu);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                CanhBao("Vui lòng chọn ghế!", btnChonGhe);
                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n\n" +
                "Khách hàng: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.SelectedItem + "\n" +
                "Suất chiếu: " + cboSuatChieu.SelectedItem + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá: " + GiaVe + "/vé",
                "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CanhBao(string noiDung, Control canFocus)
        {
            MessageBox.Show(noiDung, "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            canFocus.Focus();
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
