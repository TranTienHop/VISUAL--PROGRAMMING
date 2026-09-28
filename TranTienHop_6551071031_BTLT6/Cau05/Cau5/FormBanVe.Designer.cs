namespace BaiTapChuong5
{
    partial class FormBanVe
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
            lblTenKhach = new System.Windows.Forms.Label();
            lblPhim = new System.Windows.Forms.Label();
            lblSuatChieu = new System.Windows.Forms.Label();
            lblGheDaChon = new System.Windows.Forms.Label();
            txtTenKhach = new System.Windows.Forms.TextBox();
            cboPhim = new System.Windows.Forms.ComboBox();
            cboSuatChieu = new System.Windows.Forms.ComboBox();
            txtGheDaChon = new System.Windows.Forms.TextBox();
            btnChonGhe = new System.Windows.Forms.Button();
            btnDatVe = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new System.Drawing.Point(34, 27);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new System.Drawing.Size(77, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new System.Drawing.Point(34, 107);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new System.Drawing.Size(45, 20);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "Phim:";
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new System.Drawing.Point(34, 187);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new System.Drawing.Size(80, 20);
            lblSuatChieu.TabIndex = 2;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new System.Drawing.Point(34, 267);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new System.Drawing.Size(95, 20);
            lblGheDaChon.TabIndex = 3;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new System.Drawing.Point(34, 53);
            txtTenKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new System.Drawing.Size(411, 27);
            txtTenKhach.TabIndex = 0;
            txtTenKhach.TextChanged += txtTenKhach_TextChanged;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Mưa Đỏ", "Địa Đạo", "Tử Chiến Trên Không", "Nghỉ Hè Sợ Nghỉ Hưu", "Lên Hương" });
            cboPhim.Location = new System.Drawing.Point(34, 133);
            cboPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new System.Drawing.Size(411, 28);
            cboPhim.TabIndex = 1;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00", "13:30", "16:00", "19:00", "21:30" });
            cboSuatChieu.Location = new System.Drawing.Point(34, 213);
            cboSuatChieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new System.Drawing.Size(411, 28);
            cboSuatChieu.TabIndex = 2;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new System.Drawing.Point(34, 293);
            txtGheDaChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new System.Drawing.Size(411, 27);
            txtGheDaChon.TabIndex = 3;
            txtGheDaChon.TabStop = false;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new System.Drawing.Point(34, 373);
            btnChonGhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new System.Drawing.Size(126, 47);
            btnChonGhe.TabIndex = 4;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new System.Drawing.Point(177, 373);
            btnDatVe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new System.Drawing.Size(126, 47);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new System.Drawing.Point(320, 373);
            btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(126, 47);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 460);
            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);
            Controls.Add(lblPhim);
            Controls.Add(cboPhim);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblGheDaChon);
            Controls.Add(txtGheDaChon);
            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(btnHuy);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}
