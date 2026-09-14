namespace Bai18
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            frmChild f = new frmChild();
            f.MdiParent = this;
            f.Text = "Form con - " + (MdiChildren.Length + 1);
            f.Show();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSSV: 6551071031\nBài 18 - Ứng dụng MDI", "Thông tin");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thật sự muốn đóng chương trình không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
