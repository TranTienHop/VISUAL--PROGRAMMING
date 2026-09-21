using System;
using System.Windows.Forms;

namespace ToDoListDemo
{
    public partial class Form1 : Form
    {
        private const string TIEN_TO_HOAN_THANH = "[Hoàn thành] ";

        public Form1()
        {
            InitializeComponent();
        }

        // Thêm công việc mới vào danh sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            string noiDung = txtCongViecMoi.Text.Trim();

            if (!string.IsNullOrEmpty(noiDung))
            {
                lstCongViec.Items.Add(noiDung);
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung công việc.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Đánh dấu công việc đang chọn là đã hoàn thành
        private void mnuHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một công việc trước khi đánh dấu hoàn thành.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int chiSo = lstCongViec.SelectedIndex;
            string noiDung = lstCongViec.Items[chiSo].ToString();

            if (!noiDung.StartsWith(TIEN_TO_HOAN_THANH))
            {
                lstCongViec.Items[chiSo] = TIEN_TO_HOAN_THANH + noiDung;
            }
        }

        // Xóa công việc đang được chọn
        private void mnuXoaMotCongViec_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một công việc trước khi xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa toàn bộ danh sách công việc (có xác nhận)
        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tất cả công việc trong danh sách không?",
                "Xác nhận xóa tất cả",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
