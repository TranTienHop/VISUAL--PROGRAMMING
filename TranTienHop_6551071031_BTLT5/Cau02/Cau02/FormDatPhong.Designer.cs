namespace BaiTapChuong5
{
    partial class FormDatPhong
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
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblSoNguoiLon = new System.Windows.Forms.Label();
            this.lblSoTreEm = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtSoNguoiLon = new System.Windows.Forms.TextBox();
            this.txtSoTreEm = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(60, 15);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            //
            // lblCCCD
            //
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(60, 75);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.TabIndex = 1;
            this.lblCCCD.Text = "Số CCCD";
            //
            // lblNgayNhan
            //
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Location = new System.Drawing.Point(60, 135);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.TabIndex = 2;
            this.lblNgayNhan.Text = "Ngày nhận phòng (dd/MM/yyyy)";
            //
            // lblNgayTra
            //
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(60, 195);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.TabIndex = 3;
            this.lblNgayTra.Text = "Ngày trả phòng (dd/MM/yyyy)";
            //
            // lblSoNguoiLon
            //
            this.lblSoNguoiLon.AutoSize = true;
            this.lblSoNguoiLon.Location = new System.Drawing.Point(60, 255);
            this.lblSoNguoiLon.Name = "lblSoNguoiLon";
            this.lblSoNguoiLon.TabIndex = 4;
            this.lblSoNguoiLon.Text = "Số người lớn (1 - 4)";
            //
            // lblSoTreEm
            //
            this.lblSoTreEm.AutoSize = true;
            this.lblSoTreEm.Location = new System.Drawing.Point(60, 315);
            this.lblSoTreEm.Name = "lblSoTreEm";
            this.lblSoTreEm.TabIndex = 5;
            this.lblSoTreEm.Text = "Số trẻ em (0 - 3)";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(60, 35);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 23);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            this.txtHoTen.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // txtCCCD
            //
            this.txtCCCD.Location = new System.Drawing.Point(60, 95);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(300, 23);
            this.txtCCCD.TabIndex = 1;
            this.txtCCCD.Validating += new System.ComponentModel.CancelEventHandler(this.txtCCCD_Validating);
            this.txtCCCD.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // txtNgayNhan
            //
            this.txtNgayNhan.Location = new System.Drawing.Point(60, 155);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(300, 23);
            this.txtNgayNhan.TabIndex = 2;
            this.txtNgayNhan.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayNhan_Validating);
            this.txtNgayNhan.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // txtNgayTra
            //
            this.txtNgayTra.Location = new System.Drawing.Point(60, 215);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(300, 23);
            this.txtNgayTra.TabIndex = 3;
            this.txtNgayTra.Validating += new System.ComponentModel.CancelEventHandler(this.txtNgayTra_Validating);
            this.txtNgayTra.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // txtSoNguoiLon
            //
            this.txtSoNguoiLon.Location = new System.Drawing.Point(60, 275);
            this.txtSoNguoiLon.Name = "txtSoNguoiLon";
            this.txtSoNguoiLon.Size = new System.Drawing.Size(300, 23);
            this.txtSoNguoiLon.TabIndex = 4;
            this.txtSoNguoiLon.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoNguoiLon_Validating);
            this.txtSoNguoiLon.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // txtSoTreEm
            //
            this.txtSoTreEm.Location = new System.Drawing.Point(60, 335);
            this.txtSoTreEm.Name = "txtSoTreEm";
            this.txtSoTreEm.Size = new System.Drawing.Size(300, 23);
            this.txtSoTreEm.TabIndex = 5;
            this.txtSoTreEm.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoTreEm_Validating);
            this.txtSoTreEm.Validated += new System.EventHandler(this.TextBox_Validated);
            //
            // btnDatPhong
            //
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(60, 385);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(300, 38);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // FormDatPhong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblNgayNhan);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblSoNguoiLon);
            this.Controls.Add(this.lblSoTreEm);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.txtSoNguoiLon);
            this.Controls.Add(this.txtSoTreEm);
            this.Controls.Add(this.btnDatPhong);
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
