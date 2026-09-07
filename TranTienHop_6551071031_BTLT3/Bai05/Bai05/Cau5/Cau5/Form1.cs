using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ===== 1. Khi Form load =====
        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;     // a. Radio Red mặc định
            txtNhapTen.Focus();        // b. Con trỏ ở ô Nhập tên
        }

        // ===== 2. Gõ tên -> label chạy song song =====
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        // ===== 3. Đổi màu theo Radiobutton =====
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        // ===== 4. Đổi font theo CheckBox (dùng Xor) =====
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style ^ FontStyle.Bold);
            txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style ^ FontStyle.Italic);
            txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font, lblLapTrinh.Font.Style ^ FontStyle.Underline);
            txtNhapTen.Font = new Font(txtNhapTen.Font, txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        // ===== 5. Nút Thoát =====
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
