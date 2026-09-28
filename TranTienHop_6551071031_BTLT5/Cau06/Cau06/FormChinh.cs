using Cau06;

namespace BT6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }
        public void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text = "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu f = new FormGhiChu();
            f.MdiParent = this;

            f.FormClosed += (s, args) => { CapNhatSoGhiChu(); };

            f.Show();
            CapNhatSoGhiChu();
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
