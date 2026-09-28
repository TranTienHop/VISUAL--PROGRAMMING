namespace Cau06
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            label1 = new Label();
            txtTieuDe = new TextBox();
            label2 = new Label();
            cboMucDoUuTien = new ComboBox();
            label3 = new Label();
            txtNoiDung = new TextBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Dock = DockStyle.Top;
            lblTieuDeForm.Location = new Point(0, 0);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(430, 20);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC (Đúp chuột vào đây để Thu nhỏ/Phóng to)";
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tiêu đề ghi chú";
            label1.Click += label1_Click;
            label1.Validated += label1_Validated;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(128, 31);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(151, 27);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.Validating += txtTieuDe_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 3;
            label2.Text = "Mức độ ưu tiên";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(128, 71);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(151, 28);
            cboMucDoUuTien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Nội dung ghi chú";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(39, 141);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(375, 117);
            txtNoiDung.TabIndex = 6;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(320, 271);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(94, 29);
            btnLuuGhiChu.TabIndex = 7;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = false;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 312);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(txtNoiDung);
            Controls.Add(label3);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(label2);
            Controls.Add(txtTieuDe);
            Controls.Add(label1);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "Ghi Chú Mới";
            Load += FormGhiChu_Load;
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label label1;
        private TextBox txtTieuDe;
        private Label label2;
        private ComboBox cboMucDoUuTien;
        private Label label3;
        private TextBox txtNoiDung;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}