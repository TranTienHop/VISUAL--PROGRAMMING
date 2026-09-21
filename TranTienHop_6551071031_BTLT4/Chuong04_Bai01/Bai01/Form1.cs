namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CapNhatTrangThai(); // hiển thị ngay, không chờ 1s đầu
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            DateTime now = DateTime.Now;
            lblGioHienTai.Text = now.ToString("HH:mm:ss");

            if (now.Hour >= 6 && now.Hour < 22)   // 6h00 -> 21h59
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void mnuDoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    this.BackColor = dlg.Color;
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTenQuan_Click(object sender, EventArgs e)
        {

        }
    }
}
