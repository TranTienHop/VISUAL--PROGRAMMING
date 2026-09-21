namespace BTCh4_Bai4
{
    partial class frmBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nudTuoi = new NumericUpDown();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstDanhSach = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudTuoi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(155, 46);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(284, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 103);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Tuổi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 149);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 3;
            label3.Text = "Triệu chứng:";
            // 
            // nudTuoi
            // 
            nudTuoi.Location = new Point(155, 96);
            nudTuoi.Name = "nudTuoi";
            nudTuoi.Size = new Size(284, 27);
            nudTuoi.TabIndex = 4;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(155, 142);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(284, 27);
            txtTrieuChung.TabIndex = 5;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(227, 207);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(123, 38);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(42, 292);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(579, 124);
            lstDanhSach.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDanhSach);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(nudTuoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            ((System.ComponentModel.ISupportInitialize)nudTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private NumericUpDown nudTuoi;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstDanhSach;
    }
}