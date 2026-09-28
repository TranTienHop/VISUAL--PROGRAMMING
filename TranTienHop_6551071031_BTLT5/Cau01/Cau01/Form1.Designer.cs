namespace BT5
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
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            txtXacNhanMK = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 89);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(238, 89);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 126);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(238, 126);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 158);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 193);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(238, 193);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 7;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(101, 275);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(118, 29);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(238, 275);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 29);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 229);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 10;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(238, 226);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(125, 27);
            txtXacNhanMK.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 18);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 12;
            label6.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 38);
            label7.Name = "label7";
            label7.Size = new Size(214, 20);
            label7.TabIndex = 13;
            label7.Text = "Vui lòng nhập đầy đủ thông tin";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 382);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtXacNhanMK);
            Controls.Add(label5);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtMatKhau);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSDT);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đăng Ký Tài Khoản";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtMatKhau;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
        private TextBox txtXacNhanMK;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}
