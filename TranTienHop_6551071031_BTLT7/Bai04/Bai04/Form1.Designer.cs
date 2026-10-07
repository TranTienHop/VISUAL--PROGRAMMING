namespace Bai04
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
            this.components = new System.ComponentModel.Container();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.lblGioKham = new System.Windows.Forms.Label();
            this.dtpGioKham = new System.Windows.Forms.DateTimePicker();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.btnQuanLyBacSi = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.cboLocBacSi = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvLichKham = new System.Windows.Forms.DataGridView();
            this.colMaLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Location = new System.Drawing.Point(12, 15);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(84, 15);
            this.lblTenBenhNhan.TabIndex = 0;
            this.lblTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Location = new System.Drawing.Point(110, 12);
            this.txtTenBenhNhan.MaxLength = 100;
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(200, 23);
            this.txtTenBenhNhan.TabIndex = 1;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(12, 61);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(76, 15);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(110, 58);
            this.txtSdt.MaxLength = 15;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(200, 23);
            this.txtSdt.TabIndex = 3;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Location = new System.Drawing.Point(12, 91);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(65, 15);
            this.lblNgayKham.TabIndex = 4;
            this.lblNgayKham.Text = "Ngày khám";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.Location = new System.Drawing.Point(110, 87);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayKham.TabIndex = 5;
            // 
            // lblGioKham
            // 
            this.lblGioKham.AutoSize = true;
            this.lblGioKham.Location = new System.Drawing.Point(330, 61);
            this.lblGioKham.Name = "lblGioKham";
            this.lblGioKham.Size = new System.Drawing.Size(55, 15);
            this.lblGioKham.TabIndex = 6;
            this.lblGioKham.Text = "Giờ khám";
            // 
            // dtpGioKham
            // 
            this.dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKham.Location = new System.Drawing.Point(330, 87);
            this.dtpGioKham.Name = "dtpGioKham";
            this.dtpGioKham.ShowUpDown = true;
            this.dtpGioKham.Size = new System.Drawing.Size(110, 23);
            this.dtpGioKham.TabIndex = 7;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(470, 44);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(38, 15);
            this.lblBacSi.TabIndex = 8;
            this.lblBacSi.Text = "Bác sĩ";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(470, 64);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(260, 23);
            this.cboBacSi.TabIndex = 9;
            // 
            // btnQuanLyBacSi
            // 
            this.btnQuanLyBacSi.Location = new System.Drawing.Point(733, 63);
            this.btnQuanLyBacSi.Name = "btnQuanLyBacSi";
            this.btnQuanLyBacSi.Size = new System.Drawing.Size(28, 25);
            this.btnQuanLyBacSi.TabIndex = 10;
            this.btnQuanLyBacSi.Text = "...";
            this.toolTip1.SetToolTip(this.btnQuanLyBacSi, "Quản lý Bác sĩ");
            this.btnQuanLyBacSi.UseVisualStyleBackColor = true;
            this.btnQuanLyBacSi.Click += new System.EventHandler(this.btnQuanLyBacSi_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(790, 44);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(60, 15);
            this.lblTrangThai.TabIndex = 11;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(790, 64);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(150, 23);
            this.cboTrangThai.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(640, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(725, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(810, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(895, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 27);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(12, 138);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(48, 15);
            this.lblTuNgay.TabIndex = 17;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(66, 134);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpTuNgay.TabIndex = 18;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(200, 138);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(56, 15);
            this.lblDenNgay.TabIndex = 19;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(262, 134);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpDenNgay.TabIndex = 20;
            // 
            // cboLocBacSi
            // 
            this.cboLocBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocBacSi.FormattingEnabled = true;
            this.cboLocBacSi.Location = new System.Drawing.Point(395, 134);
            this.cboLocBacSi.Name = "cboLocBacSi";
            this.cboLocBacSi.Size = new System.Drawing.Size(260, 23);
            this.cboLocBacSi.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(665, 132);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 27);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatCa.Location = new System.Drawing.Point(895, 132);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 27);
            this.btnTatCa.TabIndex = 23;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // dgvLichKham
            // 
            this.dgvLichKham.AllowUserToAddRows = false;
            this.dgvLichKham.AllowUserToDeleteRows = false;
            this.dgvLichKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLich,
            this.colTenBenhNhan,
            this.colSdt,
            this.colNgayKham,
            this.colGioKham,
            this.colTenBacSi,
            this.colChuyenKhoa,
            this.colTrangThai});
            this.dgvLichKham.Location = new System.Drawing.Point(12, 172);
            this.dgvLichKham.MultiSelect = false;
            this.dgvLichKham.Name = "dgvLichKham";
            this.dgvLichKham.ReadOnly = true;
            this.dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichKham.Size = new System.Drawing.Size(958, 376);
            this.dgvLichKham.TabIndex = 24;
            this.dgvLichKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichKham_CellClick);
            // 
            // colMaLich
            // 
            this.colMaLich.DataPropertyName = "MaLich";
            this.colMaLich.HeaderText = "Mã lịch";
            this.colMaLich.Name = "colMaLich";
            this.colMaLich.ReadOnly = true;
            this.colMaLich.Width = 70;
            // 
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.DataPropertyName = "TenBenhNhan";
            this.colTenBenhNhan.HeaderText = "Tên bệnh nhân";
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.ReadOnly = true;
            this.colTenBenhNhan.Width = 140;
            // 
            // colSdt
            // 
            this.colSdt.DataPropertyName = "Sdt";
            this.colSdt.HeaderText = "SĐT";
            this.colSdt.Name = "colSdt";
            this.colSdt.ReadOnly = true;
            // 
            // colNgayKham
            // 
            this.colNgayKham.DataPropertyName = "NgayKhamText";
            this.colNgayKham.HeaderText = "Ngày khám";
            this.colNgayKham.Name = "colNgayKham";
            this.colNgayKham.ReadOnly = true;
            // 
            // colGioKham
            // 
            this.colGioKham.DataPropertyName = "GioKhamText";
            this.colGioKham.HeaderText = "Giờ khám";
            this.colGioKham.Name = "colGioKham";
            this.colGioKham.ReadOnly = true;
            this.colGioKham.Width = 80;
            // 
            // colTenBacSi
            // 
            this.colTenBacSi.DataPropertyName = "TenBacSi";
            this.colTenBacSi.HeaderText = "Bác sĩ";
            this.colTenBacSi.Name = "colTenBacSi";
            this.colTenBacSi.ReadOnly = true;
            this.colTenBacSi.Width = 220;
            // 
            // colChuyenKhoa
            // 
            this.colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            this.colChuyenKhoa.HeaderText = "Chuyên khoa";
            this.colChuyenKhoa.Name = "colChuyenKhoa";
            this.colChuyenKhoa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgvLichKham);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboLocBacSi);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnQuanLyBacSi);
            this.Controls.Add(this.cboBacSi);
            this.Controls.Add(this.lblBacSi);
            this.Controls.Add(this.dtpGioKham);
            this.Controls.Add(this.lblGioKham);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.lblTenBenhNhan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label lblGioKham;
        private System.Windows.Forms.DateTimePicker dtpGioKham;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Button btnQuanLyBacSi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.ComboBox cboLocBacSi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvLichKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
