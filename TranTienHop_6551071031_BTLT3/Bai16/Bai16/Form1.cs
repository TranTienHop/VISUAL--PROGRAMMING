namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            txtNoiDung.Focus();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Mở file (demo Menu).", "Thông báo");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            txtNoiDung.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            txtNoiDung.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtNoiDung.Paste();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSSV: 6551071031\nBài 16 - MainMenu và ContextMenu", "Thông tin");
        }

        private void ctxClear_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
        }

        private void ctxSelectAll_Click(object sender, EventArgs e)
        {
            txtNoiDung.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
