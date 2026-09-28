namespace Câu4
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(1, 2);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(363, 329);
            lstLienHe.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(370, 2);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(38, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            lblTen.Click += lblTen_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(370, 30);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(310, 31);
            txtTen.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(370, 73);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(117, 25);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            lblSDT.Click += lblSDT_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(370, 101);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(310, 31);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(568, 147);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(568, 227);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(568, 286);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(568, 187);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button4_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 332);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
    }
}
