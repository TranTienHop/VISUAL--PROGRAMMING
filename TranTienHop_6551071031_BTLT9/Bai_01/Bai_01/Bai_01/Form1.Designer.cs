namespace Bai_01
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
            groupBox1 = new GroupBox();
            cboLoaiChi = new ComboBox();
            txtNoiDung = new TextBox();
            dtpNgayChi = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtGhiChu = new TextBox();
            nudSoTien = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTimKiem = new TextBox();
            cboTimLoaiChi = new ComboBox();
            dtpTuNgay = new DateTimePicker();
            dtpNgayDen = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            dgvChiTieu = new DataGridView();
            lblTongChi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudSoTien);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(cboLoaiChi);
            groupBox1.Controls.Add(txtNoiDung);
            groupBox1.Controls.Add(dtpNgayChi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiêu";
            // 
            // cboLoaiChi
            // 
            cboLoaiChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiChi.FormattingEnabled = true;
            cboLoaiChi.Items.AddRange(new object[] { "Ăn uống", "Đi chơi", "Giải trí", "Học tập", "Đi lại", "Khác" });
            cboLoaiChi.Location = new Point(367, 26);
            cboLoaiChi.Name = "cboLoaiChi";
            cboLoaiChi.Size = new Size(139, 28);
            cboLoaiChi.TabIndex = 8;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(98, 63);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(163, 27);
            txtNoiDung.TabIndex = 7;
            // 
            // dtpNgayChi
            // 
            dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            dtpNgayChi.Format = DateTimePickerFormat.Custom;
            dtpNgayChi.Location = new Point(98, 23);
            dtpNgayChi.Name = "dtpNgayChi";
            dtpNgayChi.Size = new Size(163, 27);
            dtpNgayChi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 66);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 5;
            label6.Text = "Số tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 23);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 112);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 29);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Loại chi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nội dung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày chi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpNgayDen);
            groupBox2.Controls.Add(dtpTuNgay);
            groupBox2.Controls.Add(cboTimLoaiChi);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(602, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 223);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(98, 109);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(408, 96);
            txtGhiChu.TabIndex = 9;
            // 
            // nudSoTien
            // 
            nudSoTien.Location = new Point(367, 64);
            nudSoTien.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new Size(139, 27);
            nudSoTien.TabIndex = 10;
            nudSoTien.ThousandsSeparator = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 71);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 3;
            label7.Text = "Loại chi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 114);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 4;
            label8.Text = "Từ ngày";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 161);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 5;
            label9.Text = "Đến ngày";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(26, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập nội dung tìm kiếm";
            txtTimKiem.Size = new Size(249, 27);
            txtTimKiem.TabIndex = 8;
            // 
            // cboTimLoaiChi
            // 
            cboTimLoaiChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimLoaiChi.FormattingEnabled = true;
            cboTimLoaiChi.Items.AddRange(new object[] { "Ăn uống", "Đi chơi", "Giải trí", "Học tập", "Đi lại", "Khác", "Tất cả" });
            cboTimLoaiChi.Location = new Point(121, 66);
            cboTimLoaiChi.Name = "cboTimLoaiChi";
            cboTimLoaiChi.Size = new Size(154, 28);
            cboTimLoaiChi.TabIndex = 9;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(121, 112);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(154, 27);
            dtpTuNgay.TabIndex = 10;
            // 
            // dtpNgayDen
            // 
            dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            dtpNgayDen.Format = DateTimePickerFormat.Custom;
            dtpNgayDen.Location = new Point(121, 156);
            dtpNgayDen.Name = "dtpNgayDen";
            dtpNgayDen.Size = new Size(154, 27);
            dtpNgayDen.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(155, 265);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(290, 265);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(430, 265);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(573, 265);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvChiTieu
            // 
            dgvChiTieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTieu.Location = new Point(30, 310);
            dgvChiTieu.Name = "dgvChiTieu";
            dgvChiTieu.ReadOnly = true;
            dgvChiTieu.RowHeadersWidth = 51;
            dgvChiTieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTieu.Size = new Size(874, 188);
            dgvChiTieu.TabIndex = 6;
            // 
            // lblTongChi
            // 
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongChi.Location = new Point(747, 512);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(147, 31);
            lblTongChi.TabIndex = 7;
            lblTongChi.Text = "Tổng chi: 0đ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 552);
            Controls.Add(lblTongChi);
            Controls.Add(dgvChiTieu);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sổ chi tiêu cá nhân";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtNoiDung;
        private DateTimePicker dtpNgayChi;
        private Label label6;
        private ComboBox cboLoaiChi;
        private NumericUpDown nudSoTien;
        private TextBox txtGhiChu;
        private TextBox txtTimKiem;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cboTimLoaiChi;
        private DateTimePicker dtpNgayDen;
        private DateTimePicker dtpTuNgay;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private DataGridView dgvChiTieu;
        private Label lblTongChi;
    }
}
