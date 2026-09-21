namespace Bai02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            btnDangKy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 0;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi\r\n");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(162, 110);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(155, 23);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            txtSDT.TextChanged += textBox2_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(162, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(155, 23);
            txtHoTen.TabIndex = 2;
            toolTip1.SetToolTip(txtHoTen, "Nhập đầy đủ họ và tên tiếng Việt có dấu");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(162, 193);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(155, 23);
            dtpNgaySinh.TabIndex = 3;
            toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");
            dtpNgaySinh.ValueChanged += dtpNgaySinh_ValueChanged;
            // 
            // cboGoiTap
            // 
            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "Vip", "Premium" });
            cboGoiTap.Location = new Point(162, 247);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(155, 23);
            cboGoiTap.TabIndex = 4;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(162, 289);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(155, 23);
            numSoBuoiTuan.TabIndex = 5;
            toolTip1.SetToolTip(numSoBuoiTuan, "Chọn số buổi tập mong muốn trong tuần (từ 1 đến 7 buổi)");
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.ValueChanged += numSoBuoiTuan_ValueChanged;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(174, 355);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(75, 23);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký";
            toolTip1.SetToolTip(btnDangKy, "Nhấn để hoàn tất đăng ký hội viên");
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG KÝ HỘI GYM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 78);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 118);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 159);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 201);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 11;
            label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 255);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 12;
            label6.Text = "Gói tập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 297);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Số buổi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGoiTap;
        private NumericUpDown numSoBuoiTuan;
        private ToolTip toolTip1;
        private Button btnDangKy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
