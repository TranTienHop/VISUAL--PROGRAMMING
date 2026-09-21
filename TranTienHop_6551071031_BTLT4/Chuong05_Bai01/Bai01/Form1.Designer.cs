namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 74);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 112);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 150);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn Giá";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(166, 71);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(216, 27);
            txtMaSP.TabIndex = 3;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(166, 145);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(216, 27);
            txtDonGia.TabIndex = 4;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(166, 109);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(216, 27);
            txtSoLuong.TabIndex = 5;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 249);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(224, 249);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(136, 29);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(440, 12);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(319, 404);
            lstKetQua.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 318);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 9;
            label4.Text = "6551071031 Trần Tiến Hợp";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Quan Ly Ban Hang";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSP;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private Label label4;
    }
}
