namespace BaiTapChuong5
{
    partial class FormVeTay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (butVe != null) butVe.Dispose();
                if (gVe != null) gVe.Dispose();
                if (bmpVe != null) bmpVe.Dispose();

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.pnlCanvas = new BaiTapChuong5.CanvasPanel();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblHuongDan
            //
            this.lblHuongDan.AutoSize = false;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(20, 15);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(600, 22);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Giữ chuột TRÁI và kéo để vẽ  |  Chuột PHẢI để xóa trắng bảng vẽ";
            //
            // pnlCanvas
            //
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlCanvas.Location = new System.Drawing.Point(20, 45);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(760, 440);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            //
            // lblViTri
            //
            this.lblViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblViTri.ForeColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.lblViTri.Location = new System.Drawing.Point(20, 498);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(260, 25);
            this.lblViTri.TabIndex = 2;
            this.lblViTri.Text = "Tọa độ: X = 0, Y = 0";
            //
            // lblTrangThai
            //
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Green;
            this.lblTrangThai.Location = new System.Drawing.Point(300, 498);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(200, 25);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Sẵn sàng";
            //
            // FormVeTay
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.lblHuongDan);
            this.Name = "FormVeTay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng vẽ mini - Ghi chú nhanh bằng tay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHuongDan;
        private BaiTapChuong5.CanvasPanel pnlCanvas;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
