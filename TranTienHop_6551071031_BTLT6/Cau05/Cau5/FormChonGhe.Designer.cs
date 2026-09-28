namespace BaiTapChuong5
{
    partial class FormChonGhe
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
            this.lstGhe = new System.Windows.Forms.ListBox();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lstGhe
            //
            this.lstGhe.ColumnWidth = 60;
            this.lstGhe.FormattingEnabled = true;
            this.lstGhe.Items.AddRange(new object[] {
            "A1", "A2", "A3", "A4", "A5",
            "B1", "B2", "B3", "B4", "B5",
            "C1", "C2", "C3", "C4", "C5"});
            this.lstGhe.Location = new System.Drawing.Point(20, 20);
            this.lstGhe.MultiColumn = true;
            this.lstGhe.Name = "lstGhe";
            this.lstGhe.Size = new System.Drawing.Size(260, 94);
            this.lstGhe.TabIndex = 0;
            this.lstGhe.SelectedIndexChanged += new System.EventHandler(this.lstGhe_SelectedIndexChanged);
            //
            // lblGheDaChon
            //
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Location = new System.Drawing.Point(20, 128);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.TabIndex = 1;
            this.lblGheDaChon.Text = "Đang chọn: (chưa chọn)";
            //
            // btnXacNhan
            //
            this.btnXacNhan.Location = new System.Drawing.Point(60, 165);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(90, 30);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            //
            // btnBoQua
            //
            this.btnBoQua.Location = new System.Drawing.Point(160, 165);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(90, 30);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            //
            // FormChonGhe
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(300, 215);
            this.Controls.Add(this.lstGhe);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnBoQua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonGhe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn ghế";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstGhe;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;
    }
}
