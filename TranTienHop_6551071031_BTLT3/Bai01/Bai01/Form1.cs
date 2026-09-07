namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtHienThi.Clear();
            txtPassword.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            txtHienThi.Text = txtPassword.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thật sự muốn đóng chương trình không?",
                "Thông báo",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
