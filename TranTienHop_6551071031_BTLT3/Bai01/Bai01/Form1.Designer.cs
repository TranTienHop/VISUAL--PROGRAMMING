namespace Bai01
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
            btnHienThi = new Button();
            lblPassword = new Label();
            lblHienThi = new Label();
            txtPassword = new TextBox();
            txtHienThi = new TextBox();
            btbTiep = new Button();
            btnDong = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(118, 305);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển Thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(179, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Nhập Password";
            // 
            // lblHienThi
            // 
            lblHienThi.AutoSize = true;
            lblHienThi.Location = new Point(225, 172);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(64, 20);
            lblHienThi.TabIndex = 2;
            lblHienThi.Text = "Hiển Thị";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(335, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(335, 165);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.ReadOnly = true;
            txtHienThi.Size = new Size(125, 27);
            txtHienThi.TabIndex = 4;
            txtHienThi.TextChanged += textBox1_TextChanged;
            // 
            // btbTiep
            // 
            btbTiep.Location = new Point(315, 305);
            btbTiep.Name = "btbTiep";
            btbTiep.Size = new Size(94, 29);
            btbTiep.TabIndex = 5;
            btbTiep.Text = "Tiếp";
            btbTiep.UseVisualStyleBackColor = true;
            btbTiep.Click += button1_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(537, 305);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 229);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "6551071031";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDong);
            Controls.Add(btbTiep);
            Controls.Add(txtHienThi);
            Controls.Add(txtPassword);
            Controls.Add(lblHienThi);
            Controls.Add(lblPassword);
            Controls.Add(btnHienThi);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHienThi;
        private Label lblPassword;
        private Label lblHienThi;
        private TextBox txtPassword;
        private TextBox txtHienThi;
        private Button btbTiep;
        private Button btnDong;
        private Label label1;
    }
}
