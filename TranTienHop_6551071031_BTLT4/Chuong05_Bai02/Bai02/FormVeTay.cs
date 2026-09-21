using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaiTapChuong5
{
    public partial class FormVeTay : Form
    {
        private Bitmap bmpVe;
        private Graphics gVe;
        private bool dangVe = false;
        private Point diemTruoc;
        private Pen butVe;

        public FormVeTay()
        {
            InitializeComponent();
            KhoiTaoBoVe();
        }

        private void KhoiTaoBoVe()
        {
            bmpVe = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);
            gVe = Graphics.FromImage(bmpVe);
            gVe.Clear(Color.White);
            gVe.SmoothingMode = SmoothingMode.AntiAlias;

            butVe = new Pen(Color.Black, 2.5F);
            butVe.StartCap = LineCap.Round;
            butVe.EndCap = LineCap.Round;
            butVe.LineJoin = LineJoin.Round;
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmpVe, 0, 0);
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemTruoc = e.Location;

                gVe.FillEllipse(Brushes.Black, e.X - 1, e.Y - 1, 2.5F, 2.5F);
                pnlCanvas.Invalidate();

                lblTrangThai.Text = "Đang vẽ...";
                lblTrangThai.ForeColor = Color.OrangeRed;
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = string.Format("Tọa độ: X = {0}, Y = {1}", e.X, e.Y);

            if (dangVe)
            {
                gVe.DrawLine(butVe, diemTruoc, e.Location);
                diemTruoc = e.Location;
                pnlCanvas.Invalidate();
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;
                lblTrangThai.Text = "Sẵn sàng";
                lblTrangThai.ForeColor = Color.Green;
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                gVe.Clear(Color.White);
                pnlCanvas.Invalidate();

                dangVe = false;
                lblTrangThai.Text = "Sẵn sàng";
                lblTrangThai.ForeColor = Color.Green;
            }
        }
    }
}
