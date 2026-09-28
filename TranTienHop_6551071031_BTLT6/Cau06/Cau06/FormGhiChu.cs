using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cau06
{
    public partial class FormGhiChu : Form
    {
        public FormGhiChu()
        {
            InitializeComponent();
        }

        private void FormGhiChu_Load(object sender, EventArgs e)
        {
            if (cboMucDoUuTien.Items.Count > 0)
            {
                cboMucDoUuTien.SelectedIndex = 0;
            }
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (!string.IsNullOrEmpty(txtNoiDung.Text) || !string.IsNullOrEmpty(txtTieuDe.Text))
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn đóng ghi chú này không?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            }
        

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;


            if (txtNoiDung.Text.Length >= 500)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightGreen;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightGray;
        }

        private void label1_Validated(object sender, EventArgs e)
        {

        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrEmpty(tieuDe) || tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được bỏ trống và tối đa 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim(); 
            MessageBox.Show("Đã lưu ghi chú thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}