using System;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            GheChon = gheHienTai ?? "";

            if (!string.IsNullOrEmpty(gheHienTai))
            {
                int index = lstGhe.Items.IndexOf(gheHienTai);
                if (index >= 0)
                    lstGhe.SelectedIndex = index; 
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
                lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem;
            else
                lblGheDaChon.Text = "Đang chọn: (chưa chọn)";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                        
            }

            GheChon = lstGhe.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
