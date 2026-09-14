namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dudColor.Items.Clear();
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Orange");
            dudColor.Items.Add("Purple");
            dudColor.Items.Add("Black");
            dudColor.SelectedIndex = 0;
            nudSize.Minimum = 8;
            nudSize.Maximum = 72;
            nudSize.Value = 16;
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown dud = (DomainUpDown)sender;
            lblSampleText.ForeColor = Color.FromName(dud.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            lblSampleText.Font = new Font(lblSampleText.Font.FontFamily, (float)nud.Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lblSampleText_Click(object sender, EventArgs e)
        {

        }
    }
}
