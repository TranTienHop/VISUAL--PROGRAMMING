namespace Bai14
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
            lblMssv = new Label();
            lblTen = new Label();
            txtTen = new TextBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            lblLopA = new Label();
            lblLopB = new Label();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnPhai1 = new Button();
            btnPhaiAll = new Button();
            btnTrai1 = new Button();
            btnTraiAll = new Button();
            btnXoaA = new Button();
            btnXoaB = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // lblMssv
            // 
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMssv.Location = new Point(25, 19);
            lblMssv.Margin = new Padding(4, 0, 4, 0);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(197, 28);
            lblMssv.TabIndex = 0;
            lblMssv.Text = "MSSV: 6551071031";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(25, 69);
            lblTen.Margin = new Padding(4, 0, 4, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(89, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(138, 65);
            txtTen.Margin = new Padding(4, 4, 4, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(249, 31);
            txtTen.TabIndex = 2;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(412, 69);
            lblLop.Margin = new Padding(4, 0, 4, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(42, 25);
            lblLop.TabIndex = 3;
            lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(475, 65);
            cboLop.Margin = new Padding(4, 4, 4, 4);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(149, 33);
            cboLop.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(650, 62);
            btnCapNhat.Margin = new Padding(4, 4, 4, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(125, 38);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lblLopA
            // 
            lblLopA.AutoSize = true;
            lblLopA.Location = new Point(25, 125);
            lblLopA.Margin = new Padding(4, 0, 4, 0);
            lblLopA.Name = "lblLopA";
            lblLopA.Size = new Size(59, 25);
            lblLopA.TabIndex = 6;
            lblLopA.Text = "Lớp A";
            // 
            // lblLopB
            // 
            lblLopB.AutoSize = true;
            lblLopB.Location = new Point(525, 125);
            lblLopB.Margin = new Padding(4, 0, 4, 0);
            lblLopB.Name = "lblLopB";
            lblLopB.Size = new Size(57, 25);
            lblLopB.TabIndex = 7;
            lblLopB.Text = "Lớp B";
            // 
            // lstLopA
            // 
            lstLopA.Location = new Point(25, 156);
            lstLopA.Margin = new Padding(4, 4, 4, 4);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(274, 304);
            lstLopA.TabIndex = 8;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.Location = new Point(525, 156);
            lstLopB.Margin = new Padding(4, 4, 4, 4);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(274, 304);
            lstLopB.TabIndex = 9;
            // 
            // btnPhai1
            // 
            btnPhai1.Location = new Point(338, 188);
            btnPhai1.Margin = new Padding(4, 4, 4, 4);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(150, 44);
            btnPhai1.TabIndex = 10;
            btnPhai1.Text = ">";
            btnPhai1.UseVisualStyleBackColor = true;
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnPhaiAll
            // 
            btnPhaiAll.Location = new Point(338, 250);
            btnPhaiAll.Margin = new Padding(4, 4, 4, 4);
            btnPhaiAll.Name = "btnPhaiAll";
            btnPhaiAll.Size = new Size(150, 44);
            btnPhaiAll.TabIndex = 11;
            btnPhaiAll.Text = ">>";
            btnPhaiAll.UseVisualStyleBackColor = true;
            btnPhaiAll.Click += btnPhaiAll_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.Location = new Point(338, 312);
            btnTrai1.Margin = new Padding(4, 4, 4, 4);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(150, 44);
            btnTrai1.TabIndex = 12;
            btnTrai1.Text = "<";
            btnTrai1.UseVisualStyleBackColor = true;
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnTraiAll
            // 
            btnTraiAll.Location = new Point(338, 375);
            btnTraiAll.Margin = new Padding(4, 4, 4, 4);
            btnTraiAll.Name = "btnTraiAll";
            btnTraiAll.Size = new Size(150, 44);
            btnTraiAll.TabIndex = 13;
            btnTraiAll.Text = "<<";
            btnTraiAll.UseVisualStyleBackColor = true;
            btnTraiAll.Click += btnTraiAll_Click;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(25, 488);
            btnXoaA.Margin = new Padding(4, 4, 4, 4);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(150, 44);
            btnXoaA.TabIndex = 14;
            btnXoaA.Text = "Xóa lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(525, 488);
            btnXoaB.Margin = new Padding(4, 4, 4, 4);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(150, 44);
            btnXoaB.TabIndex = 15;
            btnXoaB.Text = "Xóa lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(650, 488);
            btnKetThuc.Margin = new Padding(4, 4, 4, 4);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(150, 44);
            btnKetThuc.TabIndex = 16;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 562);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaB);
            Controls.Add(btnXoaA);
            Controls.Add(btnTraiAll);
            Controls.Add(btnTrai1);
            Controls.Add(btnPhaiAll);
            Controls.Add(btnPhai1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(lblLopB);
            Controls.Add(lblLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLop);
            Controls.Add(lblLop);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lblMssv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 14 - Quản lý danh sách lớp";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMssv;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblLop;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Label lblLopA;
        private Label lblLopB;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnPhai1;
        private Button btnPhaiAll;
        private Button btnTrai1;
        private Button btnTraiAll;
        private Button btnXoaA;
        private Button btnXoaB;
        private Button btnKetThuc;
    }
}
