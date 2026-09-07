namespace Cau5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.lblLapTrinhCaption = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            //
            // lblNhapTen
            //
            this.lblNhapTen.BackColor = System.Drawing.Color.Black;
            this.lblNhapTen.ForeColor = System.Drawing.Color.Lime;
            this.lblNhapTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhapTen.Location = new System.Drawing.Point(20, 20);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(90, 23);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập Tên:";
            this.lblNhapTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtNhapTen
            //
            this.txtNhapTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapTen.Location = new System.Drawing.Point(115, 20);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(300, 23);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            //
            // grpColor
            //
            this.grpColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpColor.Controls.Add(this.radBlack);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Location = new System.Drawing.Point(20, 60);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(190, 180);
            this.grpColor.TabIndex = 2;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            //
            // radRed
            //
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radRed.Location = new System.Drawing.Point(20, 30);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(46, 19);
            this.radRed.TabIndex = 0;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            //
            // radGreen
            //
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radGreen.Location = new System.Drawing.Point(20, 70);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(60, 19);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            //
            // radBlue
            //
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radBlue.Location = new System.Drawing.Point(20, 110);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(50, 19);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            //
            // radBlack
            //
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radBlack.Location = new System.Drawing.Point(20, 150);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(56, 19);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            //
            // grpFont
            //
            this.grpFont.BackColor = System.Drawing.Color.PeachPuff;
            this.grpFont.Controls.Add(this.chkUnderline);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Location = new System.Drawing.Point(225, 60);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(190, 180);
            this.grpFont.TabIndex = 3;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font";
            //
            // chkBold
            //
            this.chkBold.AutoSize = true;
            this.chkBold.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkBold.Location = new System.Drawing.Point(20, 30);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(87, 19);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            //
            // chkItalic
            //
            this.chkItalic.AutoSize = true;
            this.chkItalic.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.chkItalic.Location = new System.Drawing.Point(20, 70);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(101, 19);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            //
            // chkUnderline
            //
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.chkUnderline.Location = new System.Drawing.Point(20, 110);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(96, 19);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Gạch Chân";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            //
            // lblLapTrinhCaption
            //
            this.lblLapTrinhCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLapTrinhCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLapTrinhCaption.Location = new System.Drawing.Point(20, 260);
            this.lblLapTrinhCaption.Name = "lblLapTrinhCaption";
            this.lblLapTrinhCaption.Size = new System.Drawing.Size(100, 23);
            this.lblLapTrinhCaption.TabIndex = 4;
            this.lblLapTrinhCaption.Text = "Lập Trình Bởi:";
            this.lblLapTrinhCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblLapTrinh
            //
            this.lblLapTrinh.BackColor = System.Drawing.SystemColors.Control;
            this.lblLapTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLapTrinh.ForeColor = System.Drawing.Color.Red;
            this.lblLapTrinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLapTrinh.Location = new System.Drawing.Point(125, 258);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(180, 25);
            this.lblLapTrinh.TabIndex = 5;
            this.lblLapTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(330, 257);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.lblLapTrinhCaption);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblNhapTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định Dạng (Formater)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label lblLapTrinhCaption;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.Button btnThoat;
    }
}
