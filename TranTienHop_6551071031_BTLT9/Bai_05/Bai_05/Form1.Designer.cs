namespace Bai_05
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTour = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabDatTour = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            // ===== TAB TOUR =====
            this.grpTourThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.lblNgoaiTe = new System.Windows.Forms.Label();
            this.cboNgoaiTe = new System.Windows.Forms.ComboBox();
            this.lblGiaNgoaiTe = new System.Windows.Forms.Label();
            this.nudGiaNgoaiTe = new System.Windows.Forms.NumericUpDown();
            this.lblNgayKhoiHanh = new System.Windows.Forms.Label();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lblSoChoToiDa = new System.Windows.Forms.Label();
            this.nudSoChoToiDa = new System.Windows.Forms.NumericUpDown();
            this.btnTourThem = new System.Windows.Forms.Button();
            this.btnTourSua = new System.Windows.Forms.Button();
            this.btnTourXoa = new System.Windows.Forms.Button();
            this.btnTourLamMoi = new System.Windows.Forms.Button();
            this.txtTourTim = new System.Windows.Forms.TextBox();
            this.btnTourTim = new System.Windows.Forms.Button();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.colTourMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourNgoaiTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTourSoCho = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ===== TAB KHÁCH HÀNG =====
            this.grpKhThongTin = new System.Windows.Forms.GroupBox();
            this.lblKhHoTen = new System.Windows.Forms.Label();
            this.txtKhHoTen = new System.Windows.Forms.TextBox();
            this.lblKhSdt = new System.Windows.Forms.Label();
            this.txtKhSdt = new System.Windows.Forms.TextBox();
            this.lblKhEmail = new System.Windows.Forms.Label();
            this.txtKhEmail = new System.Windows.Forms.TextBox();
            this.btnKhThem = new System.Windows.Forms.Button();
            this.btnKhSua = new System.Windows.Forms.Button();
            this.btnKhXoa = new System.Windows.Forms.Button();
            this.btnKhLamMoi = new System.Windows.Forms.Button();
            this.txtKhTim = new System.Windows.Forms.TextBox();
            this.btnKhTim = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colKhMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ===== TAB ĐẶT TOUR =====
            this.grpDatThongTin = new System.Windows.Forms.GroupBox();
            this.lblDatKhach = new System.Windows.Forms.Label();
            this.cboDatKhach = new System.Windows.Forms.ComboBox();
            this.lblDatTour = new System.Windows.Forms.Label();
            this.cboDatTour = new System.Windows.Forms.ComboBox();
            this.lblDatSoNguoi = new System.Windows.Forms.Label();
            this.nudDatSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblGiaNguoi = new System.Windows.Forms.Label();
            this.lblGiaNguoiValue = new System.Windows.Forms.Label();
            this.lblTyGia = new System.Windows.Forms.Label();
            this.lblTyGiaValue = new System.Windows.Forms.Label();
            this.lblTyGiaNguon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienValue = new System.Windows.Forms.Label();
            this.btnDatTour = new System.Windows.Forms.Button();
            this.txtDatTim = new System.Windows.Forms.TextBox();
            this.cboDatThang = new System.Windows.Forms.ComboBox();
            this.btnDatTim = new System.Windows.Forms.Button();
            this.btnDatBoLoc = new System.Windows.Forms.Button();
            this.dgvDatTour = new System.Windows.Forms.DataGridView();
            this.colDatMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatTenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatSoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatTyGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDoanhThu = new System.Windows.Forms.Label();

            this.tabMain.SuspendLayout();
            this.tabTour.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.tabDatTour.SuspendLayout();
            this.grpTourThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNgoaiTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.grpKhThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grpDatThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTour)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTour);
            this.tabMain.Controls.Add(this.tabKhachHang);
            this.tabMain.Controls.Add(this.tabDatTour);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1100, 640);
            this.tabMain.TabIndex = 0;

            // 
            // tabTour
            // 
            this.tabTour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTour.Controls.Add(this.dgvTour);
            this.tabTour.Controls.Add(this.btnTourTim);
            this.tabTour.Controls.Add(this.txtTourTim);
            this.tabTour.Controls.Add(this.grpTourThongTin);
            this.tabTour.Location = new System.Drawing.Point(4, 34);
            this.tabTour.Name = "tabTour";
            this.tabTour.Padding = new System.Windows.Forms.Padding(8);
            this.tabTour.Size = new System.Drawing.Size(1092, 602);
            this.tabTour.TabIndex = 0;
            this.tabTour.Text = "Tour";

            // 
            // grpTourThongTin
            // 
            this.grpTourThongTin.Controls.Add(this.btnTourLamMoi);
            this.grpTourThongTin.Controls.Add(this.btnTourXoa);
            this.grpTourThongTin.Controls.Add(this.btnTourSua);
            this.grpTourThongTin.Controls.Add(this.btnTourThem);
            this.grpTourThongTin.Controls.Add(this.nudSoChoToiDa);
            this.grpTourThongTin.Controls.Add(this.lblSoChoToiDa);
            this.grpTourThongTin.Controls.Add(this.dtpNgayKhoiHanh);
            this.grpTourThongTin.Controls.Add(this.lblNgayKhoiHanh);
            this.grpTourThongTin.Controls.Add(this.nudGiaNgoaiTe);
            this.grpTourThongTin.Controls.Add(this.lblGiaNgoaiTe);
            this.grpTourThongTin.Controls.Add(this.cboNgoaiTe);
            this.grpTourThongTin.Controls.Add(this.lblNgoaiTe);
            this.grpTourThongTin.Controls.Add(this.txtDiemDen);
            this.grpTourThongTin.Controls.Add(this.lblDiemDen);
            this.grpTourThongTin.Controls.Add(this.txtTenTour);
            this.grpTourThongTin.Controls.Add(this.lblTenTour);
            this.grpTourThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTourThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTourThongTin.Location = new System.Drawing.Point(8, 8);
            this.grpTourThongTin.Name = "grpTourThongTin";
            this.grpTourThongTin.Size = new System.Drawing.Size(1076, 150);
            this.grpTourThongTin.TabIndex = 0;
            this.grpTourThongTin.TabStop = false;
            this.grpTourThongTin.Text = "Thông tin tour";

            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenTour.Location = new System.Drawing.Point(16, 32);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(62, 17);
            this.lblTenTour.Text = "Tên tour";

            this.txtTenTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenTour.Location = new System.Drawing.Point(100, 29);
            this.txtTenTour.MaxLength = 100;
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(280, 24);
            this.txtTenTour.TabIndex = 1;

            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiemDen.Location = new System.Drawing.Point(400, 32);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(64, 17);
            this.lblDiemDen.Text = "Điểm đến";

            this.txtDiemDen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiemDen.Location = new System.Drawing.Point(480, 29);
            this.txtDiemDen.MaxLength = 50;
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(180, 24);
            this.txtDiemDen.TabIndex = 2;

            this.lblNgoaiTe.AutoSize = true;
            this.lblNgoaiTe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgoaiTe.Location = new System.Drawing.Point(680, 32);
            this.lblNgoaiTe.Name = "lblNgoaiTe";
            this.lblNgoaiTe.Size = new System.Drawing.Size(58, 17);
            this.lblNgoaiTe.Text = "Ngoại tệ";

            this.cboNgoaiTe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgoaiTe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNgoaiTe.FormattingEnabled = true;
            this.cboNgoaiTe.Items.AddRange(new object[] { "THB", "KRW", "JPY", "USD" });
            this.cboNgoaiTe.Location = new System.Drawing.Point(750, 29);
            this.cboNgoaiTe.Name = "cboNgoaiTe";
            this.cboNgoaiTe.Size = new System.Drawing.Size(90, 25);
            this.cboNgoaiTe.TabIndex = 3;

            this.lblGiaNgoaiTe.AutoSize = true;
            this.lblGiaNgoaiTe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGiaNgoaiTe.Location = new System.Drawing.Point(16, 72);
            this.lblGiaNgoaiTe.Name = "lblGiaNgoaiTe";
            this.lblGiaNgoaiTe.Size = new System.Drawing.Size(78, 17);
            this.lblGiaNgoaiTe.Text = "Giá ngoại tệ";

            this.nudGiaNgoaiTe.DecimalPlaces = 2;
            this.nudGiaNgoaiTe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudGiaNgoaiTe.Location = new System.Drawing.Point(100, 69);
            this.nudGiaNgoaiTe.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudGiaNgoaiTe.Name = "nudGiaNgoaiTe";
            this.nudGiaNgoaiTe.Size = new System.Drawing.Size(140, 24);
            this.nudGiaNgoaiTe.TabIndex = 4;
            this.nudGiaNgoaiTe.ThousandsSeparator = true;

            this.lblNgayKhoiHanh.AutoSize = true;
            this.lblNgayKhoiHanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayKhoiHanh.Location = new System.Drawing.Point(270, 72);
            this.lblNgayKhoiHanh.Name = "lblNgayKhoiHanh";
            this.lblNgayKhoiHanh.Size = new System.Drawing.Size(95, 17);
            this.lblNgayKhoiHanh.Text = "Ngày khởi hành";

            this.dtpNgayKhoiHanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(380, 69);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayKhoiHanh.TabIndex = 5;

            this.lblSoChoToiDa.AutoSize = true;
            this.lblSoChoToiDa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoChoToiDa.Location = new System.Drawing.Point(530, 72);
            this.lblSoChoToiDa.Name = "lblSoChoToiDa";
            this.lblSoChoToiDa.Size = new System.Drawing.Size(88, 17);
            this.lblSoChoToiDa.Text = "Số chỗ tối đa";

            this.nudSoChoToiDa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudSoChoToiDa.Location = new System.Drawing.Point(630, 69);
            this.nudSoChoToiDa.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.nudSoChoToiDa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoChoToiDa.Name = "nudSoChoToiDa";
            this.nudSoChoToiDa.Size = new System.Drawing.Size(80, 24);
            this.nudSoChoToiDa.TabIndex = 6;
            this.nudSoChoToiDa.Value = new decimal(new int[] { 20, 0, 0, 0 });

            this.btnTourThem.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnTourThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTourThem.ForeColor = System.Drawing.Color.White;
            this.btnTourThem.Location = new System.Drawing.Point(100, 108);
            this.btnTourThem.Name = "btnTourThem";
            this.btnTourThem.Size = new System.Drawing.Size(90, 30);
            this.btnTourThem.TabIndex = 7;
            this.btnTourThem.Text = "Thêm";
            this.btnTourThem.UseVisualStyleBackColor = false;
            this.btnTourThem.Click += new System.EventHandler(this.btnTourThem_Click);

            this.btnTourSua.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            this.btnTourSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTourSua.ForeColor = System.Drawing.Color.White;
            this.btnTourSua.Location = new System.Drawing.Point(200, 108);
            this.btnTourSua.Name = "btnTourSua";
            this.btnTourSua.Size = new System.Drawing.Size(90, 30);
            this.btnTourSua.TabIndex = 8;
            this.btnTourSua.Text = "Sửa";
            this.btnTourSua.UseVisualStyleBackColor = false;
            this.btnTourSua.Click += new System.EventHandler(this.btnTourSua_Click);

            this.btnTourXoa.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnTourXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTourXoa.ForeColor = System.Drawing.Color.White;
            this.btnTourXoa.Location = new System.Drawing.Point(300, 108);
            this.btnTourXoa.Name = "btnTourXoa";
            this.btnTourXoa.Size = new System.Drawing.Size(90, 30);
            this.btnTourXoa.TabIndex = 9;
            this.btnTourXoa.Text = "Xóa";
            this.btnTourXoa.UseVisualStyleBackColor = false;
            this.btnTourXoa.Click += new System.EventHandler(this.btnTourXoa_Click);

            this.btnTourLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnTourLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTourLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnTourLamMoi.Location = new System.Drawing.Point(400, 108);
            this.btnTourLamMoi.Name = "btnTourLamMoi";
            this.btnTourLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnTourLamMoi.TabIndex = 10;
            this.btnTourLamMoi.Text = "Làm mới";
            this.btnTourLamMoi.UseVisualStyleBackColor = false;
            this.btnTourLamMoi.Click += new System.EventHandler(this.btnTourLamMoi_Click);

            this.txtTourTim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTourTim.Location = new System.Drawing.Point(16, 170);
            this.txtTourTim.Name = "txtTourTim";
            this.txtTourTim.PlaceholderText = "Tìm theo tên tour hoặc điểm đến...";
            this.txtTourTim.Size = new System.Drawing.Size(320, 24);
            this.txtTourTim.TabIndex = 1;

            this.btnTourTim.Location = new System.Drawing.Point(350, 168);
            this.btnTourTim.Name = "btnTourTim";
            this.btnTourTim.Size = new System.Drawing.Size(80, 28);
            this.btnTourTim.TabIndex = 2;
            this.btnTourTim.Text = "Tìm";
            this.btnTourTim.UseVisualStyleBackColor = true;
            this.btnTourTim.Click += new System.EventHandler(this.btnTourTim_Click);

            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTourMa, this.colTourTen, this.colTourDiemDen, this.colTourNgoaiTe,
                this.colTourGia, this.colTourNgay, this.colTourSoCho });
            this.dgvTour.Location = new System.Drawing.Point(16, 205);
            this.dgvTour.MultiSelect = false;
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(1060, 380);
            this.dgvTour.TabIndex = 3;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);

            this.colTourMa.DataPropertyName = "MaTour";
            this.colTourMa.HeaderText = "Mã";
            this.colTourMa.Name = "colTourMa";
            this.colTourMa.ReadOnly = true;
            this.colTourMa.FillWeight = 40F;

            this.colTourTen.DataPropertyName = "TenTour";
            this.colTourTen.HeaderText = "Tên tour";
            this.colTourTen.Name = "colTourTen";
            this.colTourTen.ReadOnly = true;
            this.colTourTen.FillWeight = 160F;

            this.colTourDiemDen.DataPropertyName = "DiemDen";
            this.colTourDiemDen.HeaderText = "Điểm đến";
            this.colTourDiemDen.Name = "colTourDiemDen";
            this.colTourDiemDen.ReadOnly = true;

            this.colTourNgoaiTe.DataPropertyName = "NgoaiTe";
            this.colTourNgoaiTe.HeaderText = "Ngoại tệ";
            this.colTourNgoaiTe.Name = "colTourNgoaiTe";
            this.colTourNgoaiTe.ReadOnly = true;
            this.colTourNgoaiTe.FillWeight = 50F;

            this.colTourGia.DataPropertyName = "GiaHienThi";
            this.colTourGia.HeaderText = "Giá";
            this.colTourGia.Name = "colTourGia";
            this.colTourGia.ReadOnly = true;

            this.colTourNgay.DataPropertyName = "NgayKhoiHanhText";
            this.colTourNgay.HeaderText = "Khởi hành";
            this.colTourNgay.Name = "colTourNgay";
            this.colTourNgay.ReadOnly = true;

            this.colTourSoCho.DataPropertyName = "SoChoToiDa";
            this.colTourSoCho.HeaderText = "Số chỗ";
            this.colTourSoCho.Name = "colTourSoCho";
            this.colTourSoCho.ReadOnly = true;
            this.colTourSoCho.FillWeight = 50F;

            // 
            // tabKhachHang
            // 
            this.tabKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Controls.Add(this.btnKhTim);
            this.tabKhachHang.Controls.Add(this.txtKhTim);
            this.tabKhachHang.Controls.Add(this.grpKhThongTin);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 34);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(8);
            this.tabKhachHang.Size = new System.Drawing.Size(1092, 602);
            this.tabKhachHang.TabIndex = 1;
            this.tabKhachHang.Text = "Khách hàng";

            this.grpKhThongTin.Controls.Add(this.btnKhLamMoi);
            this.grpKhThongTin.Controls.Add(this.btnKhXoa);
            this.grpKhThongTin.Controls.Add(this.btnKhSua);
            this.grpKhThongTin.Controls.Add(this.btnKhThem);
            this.grpKhThongTin.Controls.Add(this.txtKhEmail);
            this.grpKhThongTin.Controls.Add(this.lblKhEmail);
            this.grpKhThongTin.Controls.Add(this.txtKhSdt);
            this.grpKhThongTin.Controls.Add(this.lblKhSdt);
            this.grpKhThongTin.Controls.Add(this.txtKhHoTen);
            this.grpKhThongTin.Controls.Add(this.lblKhHoTen);
            this.grpKhThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKhThongTin.Location = new System.Drawing.Point(8, 8);
            this.grpKhThongTin.Name = "grpKhThongTin";
            this.grpKhThongTin.Size = new System.Drawing.Size(1076, 120);
            this.grpKhThongTin.TabIndex = 0;
            this.grpKhThongTin.TabStop = false;
            this.grpKhThongTin.Text = "Thông tin khách hàng";

            this.lblKhHoTen.AutoSize = true;
            this.lblKhHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhHoTen.Location = new System.Drawing.Point(16, 35);
            this.lblKhHoTen.Name = "lblKhHoTen";
            this.lblKhHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblKhHoTen.Text = "Họ tên";

            this.txtKhHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhHoTen.Location = new System.Drawing.Point(80, 32);
            this.txtKhHoTen.MaxLength = 100;
            this.txtKhHoTen.Name = "txtKhHoTen";
            this.txtKhHoTen.Size = new System.Drawing.Size(240, 24);
            this.txtKhHoTen.TabIndex = 1;

            this.lblKhSdt.AutoSize = true;
            this.lblKhSdt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhSdt.Location = new System.Drawing.Point(350, 35);
            this.lblKhSdt.Name = "lblKhSdt";
            this.lblKhSdt.Size = new System.Drawing.Size(88, 17);
            this.lblKhSdt.Text = "Số điện thoại";

            this.txtKhSdt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhSdt.Location = new System.Drawing.Point(450, 32);
            this.txtKhSdt.MaxLength = 15;
            this.txtKhSdt.Name = "txtKhSdt";
            this.txtKhSdt.Size = new System.Drawing.Size(160, 24);
            this.txtKhSdt.TabIndex = 2;

            this.lblKhEmail.AutoSize = true;
            this.lblKhEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhEmail.Location = new System.Drawing.Point(640, 35);
            this.lblKhEmail.Name = "lblKhEmail";
            this.lblKhEmail.Size = new System.Drawing.Size(41, 17);
            this.lblKhEmail.Text = "Email";

            this.txtKhEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhEmail.Location = new System.Drawing.Point(695, 32);
            this.txtKhEmail.MaxLength = 100;
            this.txtKhEmail.Name = "txtKhEmail";
            this.txtKhEmail.Size = new System.Drawing.Size(220, 24);
            this.txtKhEmail.TabIndex = 3;

            this.btnKhThem.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnKhThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhThem.ForeColor = System.Drawing.Color.White;
            this.btnKhThem.Location = new System.Drawing.Point(80, 72);
            this.btnKhThem.Name = "btnKhThem";
            this.btnKhThem.Size = new System.Drawing.Size(90, 30);
            this.btnKhThem.TabIndex = 4;
            this.btnKhThem.Text = "Thêm";
            this.btnKhThem.UseVisualStyleBackColor = false;
            this.btnKhThem.Click += new System.EventHandler(this.btnKhThem_Click);

            this.btnKhSua.BackColor = System.Drawing.Color.FromArgb(2, 132, 199);
            this.btnKhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhSua.ForeColor = System.Drawing.Color.White;
            this.btnKhSua.Location = new System.Drawing.Point(180, 72);
            this.btnKhSua.Name = "btnKhSua";
            this.btnKhSua.Size = new System.Drawing.Size(90, 30);
            this.btnKhSua.TabIndex = 5;
            this.btnKhSua.Text = "Sửa";
            this.btnKhSua.UseVisualStyleBackColor = false;
            this.btnKhSua.Click += new System.EventHandler(this.btnKhSua_Click);

            this.btnKhXoa.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnKhXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhXoa.ForeColor = System.Drawing.Color.White;
            this.btnKhXoa.Location = new System.Drawing.Point(280, 72);
            this.btnKhXoa.Name = "btnKhXoa";
            this.btnKhXoa.Size = new System.Drawing.Size(90, 30);
            this.btnKhXoa.TabIndex = 6;
            this.btnKhXoa.Text = "Xóa";
            this.btnKhXoa.UseVisualStyleBackColor = false;
            this.btnKhXoa.Click += new System.EventHandler(this.btnKhXoa_Click);

            this.btnKhLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnKhLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKhLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnKhLamMoi.Location = new System.Drawing.Point(380, 72);
            this.btnKhLamMoi.Name = "btnKhLamMoi";
            this.btnKhLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnKhLamMoi.TabIndex = 7;
            this.btnKhLamMoi.Text = "Làm mới";
            this.btnKhLamMoi.UseVisualStyleBackColor = false;
            this.btnKhLamMoi.Click += new System.EventHandler(this.btnKhLamMoi_Click);

            this.txtKhTim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhTim.Location = new System.Drawing.Point(16, 140);
            this.txtKhTim.Name = "txtKhTim";
            this.txtKhTim.PlaceholderText = "Tìm theo họ tên hoặc SĐT...";
            this.txtKhTim.Size = new System.Drawing.Size(320, 24);
            this.txtKhTim.TabIndex = 1;

            this.btnKhTim.Location = new System.Drawing.Point(350, 138);
            this.btnKhTim.Name = "btnKhTim";
            this.btnKhTim.Size = new System.Drawing.Size(80, 28);
            this.btnKhTim.TabIndex = 2;
            this.btnKhTim.Text = "Tìm";
            this.btnKhTim.UseVisualStyleBackColor = true;
            this.btnKhTim.Click += new System.EventHandler(this.btnKhTim_Click);

            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colKhMa, this.colKhHoTen, this.colKhSdt, this.colKhEmail });
            this.dgvKhachHang.Location = new System.Drawing.Point(16, 175);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1060, 410);
            this.dgvKhachHang.TabIndex = 3;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);

            this.colKhMa.DataPropertyName = "MaKh";
            this.colKhMa.HeaderText = "Mã KH";
            this.colKhMa.Name = "colKhMa";
            this.colKhMa.ReadOnly = true;
            this.colKhMa.FillWeight = 50F;

            this.colKhHoTen.DataPropertyName = "HoTen";
            this.colKhHoTen.HeaderText = "Họ tên";
            this.colKhHoTen.Name = "colKhHoTen";
            this.colKhHoTen.ReadOnly = true;

            this.colKhSdt.DataPropertyName = "SoDienThoai";
            this.colKhSdt.HeaderText = "SĐT";
            this.colKhSdt.Name = "colKhSdt";
            this.colKhSdt.ReadOnly = true;

            this.colKhEmail.DataPropertyName = "Email";
            this.colKhEmail.HeaderText = "Email";
            this.colKhEmail.Name = "colKhEmail";
            this.colKhEmail.ReadOnly = true;

            // 
            // tabDatTour
            // 
            this.tabDatTour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDatTour.Controls.Add(this.lblDoanhThu);
            this.tabDatTour.Controls.Add(this.dgvDatTour);
            this.tabDatTour.Controls.Add(this.btnDatBoLoc);
            this.tabDatTour.Controls.Add(this.btnDatTim);
            this.tabDatTour.Controls.Add(this.cboDatThang);
            this.tabDatTour.Controls.Add(this.txtDatTim);
            this.tabDatTour.Controls.Add(this.grpDatThongTin);
            this.tabDatTour.Location = new System.Drawing.Point(4, 34);
            this.tabDatTour.Name = "tabDatTour";
            this.tabDatTour.Padding = new System.Windows.Forms.Padding(8);
            this.tabDatTour.Size = new System.Drawing.Size(1092, 602);
            this.tabDatTour.TabIndex = 2;
            this.tabDatTour.Text = "Đặt tour";

            this.grpDatThongTin.Controls.Add(this.btnDatTour);
            this.grpDatThongTin.Controls.Add(this.lblTongTienValue);
            this.grpDatThongTin.Controls.Add(this.lblTongTien);
            this.grpDatThongTin.Controls.Add(this.lblTyGiaNguon);
            this.grpDatThongTin.Controls.Add(this.lblTyGiaValue);
            this.grpDatThongTin.Controls.Add(this.lblTyGia);
            this.grpDatThongTin.Controls.Add(this.lblGiaNguoiValue);
            this.grpDatThongTin.Controls.Add(this.lblGiaNguoi);
            this.grpDatThongTin.Controls.Add(this.nudDatSoNguoi);
            this.grpDatThongTin.Controls.Add(this.lblDatSoNguoi);
            this.grpDatThongTin.Controls.Add(this.cboDatTour);
            this.grpDatThongTin.Controls.Add(this.lblDatTour);
            this.grpDatThongTin.Controls.Add(this.cboDatKhach);
            this.grpDatThongTin.Controls.Add(this.lblDatKhach);
            this.grpDatThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDatThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDatThongTin.Location = new System.Drawing.Point(8, 8);
            this.grpDatThongTin.Name = "grpDatThongTin";
            this.grpDatThongTin.Size = new System.Drawing.Size(1076, 175);
            this.grpDatThongTin.TabIndex = 0;
            this.grpDatThongTin.TabStop = false;
            this.grpDatThongTin.Text = "Thông tin đặt tour";

            this.lblDatKhach.AutoSize = true;
            this.lblDatKhach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDatKhach.Location = new System.Drawing.Point(16, 35);
            this.lblDatKhach.Name = "lblDatKhach";
            this.lblDatKhach.Size = new System.Drawing.Size(80, 17);
            this.lblDatKhach.Text = "Khách hàng";

            this.cboDatKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatKhach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDatKhach.FormattingEnabled = true;
            this.cboDatKhach.Location = new System.Drawing.Point(110, 32);
            this.cboDatKhach.Name = "cboDatKhach";
            this.cboDatKhach.Size = new System.Drawing.Size(280, 25);
            this.cboDatKhach.TabIndex = 1;

            this.lblDatTour.AutoSize = true;
            this.lblDatTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDatTour.Location = new System.Drawing.Point(420, 35);
            this.lblDatTour.Name = "lblDatTour";
            this.lblDatTour.Size = new System.Drawing.Size(35, 17);
            this.lblDatTour.Text = "Tour";

            this.cboDatTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDatTour.FormattingEnabled = true;
            this.cboDatTour.Location = new System.Drawing.Point(470, 32);
            this.cboDatTour.Name = "cboDatTour";
            this.cboDatTour.Size = new System.Drawing.Size(280, 25);
            this.cboDatTour.TabIndex = 2;
            this.cboDatTour.SelectedIndexChanged += new System.EventHandler(this.cboDatTour_SelectedIndexChanged);

            this.lblDatSoNguoi.AutoSize = true;
            this.lblDatSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDatSoNguoi.Location = new System.Drawing.Point(780, 35);
            this.lblDatSoNguoi.Name = "lblDatSoNguoi";
            this.lblDatSoNguoi.Size = new System.Drawing.Size(64, 17);
            this.lblDatSoNguoi.Text = "Số người";

            this.nudDatSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudDatSoNguoi.Location = new System.Drawing.Point(860, 32);
            this.nudDatSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDatSoNguoi.Name = "nudDatSoNguoi";
            this.nudDatSoNguoi.Size = new System.Drawing.Size(70, 24);
            this.nudDatSoNguoi.TabIndex = 3;
            this.nudDatSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDatSoNguoi.ValueChanged += new System.EventHandler(this.nudDatSoNguoi_ValueChanged);

            this.lblGiaNguoi.AutoSize = true;
            this.lblGiaNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGiaNguoi.Location = new System.Drawing.Point(16, 75);
            this.lblGiaNguoi.Name = "lblGiaNguoi";
            this.lblGiaNguoi.Size = new System.Drawing.Size(78, 17);
            this.lblGiaNguoi.Text = "Giá / người";

            this.lblGiaNguoiValue.AutoSize = true;
            this.lblGiaNguoiValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaNguoiValue.Location = new System.Drawing.Point(110, 75);
            this.lblGiaNguoiValue.Name = "lblGiaNguoiValue";
            this.lblGiaNguoiValue.Size = new System.Drawing.Size(40, 17);
            this.lblGiaNguoiValue.Text = "---";

            this.lblTyGia.AutoSize = true;
            this.lblTyGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTyGia.Location = new System.Drawing.Point(300, 75);
            this.lblTyGia.Name = "lblTyGia";
            this.lblTyGia.Size = new System.Drawing.Size(100, 17);
            this.lblTyGia.Text = "Tỷ giá hôm nay";

            this.lblTyGiaValue.AutoSize = true;
            this.lblTyGiaValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTyGiaValue.Location = new System.Drawing.Point(420, 75);
            this.lblTyGiaValue.Name = "lblTyGiaValue";
            this.lblTyGiaValue.Size = new System.Drawing.Size(40, 17);
            this.lblTyGiaValue.Text = "---";

            this.lblTyGiaNguon.AutoSize = true;
            this.lblTyGiaNguon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblTyGiaNguon.ForeColor = System.Drawing.Color.Gray;
            this.lblTyGiaNguon.Location = new System.Drawing.Point(420, 95);
            this.lblTyGiaNguon.Name = "lblTyGiaNguon";
            this.lblTyGiaNguon.Size = new System.Drawing.Size(0, 15);
            this.lblTyGiaNguon.Text = "";

            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTongTien.Location = new System.Drawing.Point(650, 75);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(65, 17);
            this.lblTongTien.Text = "Tổng tiền";

            this.lblTongTienValue.AutoSize = true;
            this.lblTongTienValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTienValue.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.lblTongTienValue.Location = new System.Drawing.Point(730, 70);
            this.lblTongTienValue.Name = "lblTongTienValue";
            this.lblTongTienValue.Size = new System.Drawing.Size(50, 25);
            this.lblTongTienValue.Text = "0 đ";

            this.btnDatTour.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDatTour.ForeColor = System.Drawing.Color.White;
            this.btnDatTour.Location = new System.Drawing.Point(110, 125);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(140, 36);
            this.btnDatTour.TabIndex = 4;
            this.btnDatTour.Text = "Đặt tour";
            this.btnDatTour.UseVisualStyleBackColor = false;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click);

            this.txtDatTim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDatTim.Location = new System.Drawing.Point(16, 195);
            this.txtDatTim.Name = "txtDatTim";
            this.txtDatTim.PlaceholderText = "Tìm theo tên khách hoặc tên tour...";
            this.txtDatTim.Size = new System.Drawing.Size(280, 24);
            this.txtDatTim.TabIndex = 1;

            this.cboDatThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatThang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDatThang.FormattingEnabled = true;
            this.cboDatThang.Location = new System.Drawing.Point(310, 195);
            this.cboDatThang.Name = "cboDatThang";
            this.cboDatThang.Size = new System.Drawing.Size(160, 25);
            this.cboDatThang.TabIndex = 2;

            this.btnDatTim.Location = new System.Drawing.Point(485, 193);
            this.btnDatTim.Name = "btnDatTim";
            this.btnDatTim.Size = new System.Drawing.Size(80, 28);
            this.btnDatTim.TabIndex = 3;
            this.btnDatTim.Text = "Tìm";
            this.btnDatTim.UseVisualStyleBackColor = true;
            this.btnDatTim.Click += new System.EventHandler(this.btnDatTim_Click);

            this.btnDatBoLoc.Location = new System.Drawing.Point(575, 193);
            this.btnDatBoLoc.Name = "btnDatBoLoc";
            this.btnDatBoLoc.Size = new System.Drawing.Size(90, 28);
            this.btnDatBoLoc.TabIndex = 4;
            this.btnDatBoLoc.Text = "Bỏ lọc";
            this.btnDatBoLoc.UseVisualStyleBackColor = true;
            this.btnDatBoLoc.Click += new System.EventHandler(this.btnDatBoLoc_Click);

            this.dgvDatTour.AllowUserToAddRows = false;
            this.dgvDatTour.AllowUserToDeleteRows = false;
            this.dgvDatTour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDatMa, this.colDatKhach, this.colDatTenTour, this.colDatSoNguoi,
                this.colDatTyGia, this.colDatTongTien, this.colDatNgay });
            this.dgvDatTour.Location = new System.Drawing.Point(16, 235);
            this.dgvDatTour.MultiSelect = false;
            this.dgvDatTour.Name = "dgvDatTour";
            this.dgvDatTour.ReadOnly = true;
            this.dgvDatTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatTour.Size = new System.Drawing.Size(1060, 320);
            this.dgvDatTour.TabIndex = 5;

            this.colDatMa.DataPropertyName = "MaDatHienThi";
            this.colDatMa.HeaderText = "Mã";
            this.colDatMa.Name = "colDatMa";
            this.colDatMa.ReadOnly = true;
            this.colDatMa.FillWeight = 50F;

            this.colDatKhach.DataPropertyName = "HoTenKhach";
            this.colDatKhach.HeaderText = "Khách hàng";
            this.colDatKhach.Name = "colDatKhach";
            this.colDatKhach.ReadOnly = true;

            this.colDatTenTour.DataPropertyName = "TenTour";
            this.colDatTenTour.HeaderText = "Tour";
            this.colDatTenTour.Name = "colDatTenTour";
            this.colDatTenTour.ReadOnly = true;
            this.colDatTenTour.FillWeight = 140F;

            this.colDatSoNguoi.DataPropertyName = "SoNguoi";
            this.colDatSoNguoi.HeaderText = "Số người";
            this.colDatSoNguoi.Name = "colDatSoNguoi";
            this.colDatSoNguoi.ReadOnly = true;
            this.colDatSoNguoi.FillWeight = 55F;

            this.colDatTyGia.DataPropertyName = "TyGiaHienThi";
            this.colDatTyGia.HeaderText = "Tỷ giá";
            this.colDatTyGia.Name = "colDatTyGia";
            this.colDatTyGia.ReadOnly = true;

            this.colDatTongTien.DataPropertyName = "TongTienHienThi";
            this.colDatTongTien.HeaderText = "Tổng tiền (VNĐ)";
            this.colDatTongTien.Name = "colDatTongTien";
            this.colDatTongTien.ReadOnly = true;

            this.colDatNgay.DataPropertyName = "NgayDatHienThi";
            this.colDatNgay.HeaderText = "Ngày đặt";
            this.colDatNgay.Name = "colDatNgay";
            this.colDatNgay.ReadOnly = true;

            this.lblDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblDoanhThu.Location = new System.Drawing.Point(650, 560);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(426, 28);
            this.lblDoanhThu.TabIndex = 6;
            this.lblDoanhThu.Text = "Tổng doanh thu: 0 đ";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 17);
            this.lblStatus.Text = "Quản lý đặt tour - Bình An v1.0.0";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 662);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(1110, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đặt tour - Bình An v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTour.ResumeLayout(false);
            this.tabTour.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.tabDatTour.ResumeLayout(false);
            this.tabDatTour.PerformLayout();
            this.grpTourThongTin.ResumeLayout(false);
            this.grpTourThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNgoaiTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChoToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.grpKhThongTin.ResumeLayout(false);
            this.grpKhThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grpDatThongTin.ResumeLayout(false);
            this.grpDatThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatTour)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTour;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabDatTour;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.GroupBox grpTourThongTin;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.Label lblNgoaiTe;
        private System.Windows.Forms.ComboBox cboNgoaiTe;
        private System.Windows.Forms.Label lblGiaNgoaiTe;
        private System.Windows.Forms.NumericUpDown nudGiaNgoaiTe;
        private System.Windows.Forms.Label lblNgayKhoiHanh;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.Label lblSoChoToiDa;
        private System.Windows.Forms.NumericUpDown nudSoChoToiDa;
        private System.Windows.Forms.Button btnTourThem;
        private System.Windows.Forms.Button btnTourSua;
        private System.Windows.Forms.Button btnTourXoa;
        private System.Windows.Forms.Button btnTourLamMoi;
        private System.Windows.Forms.TextBox txtTourTim;
        private System.Windows.Forms.Button btnTourTim;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourNgoaiTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTourSoCho;

        private System.Windows.Forms.GroupBox grpKhThongTin;
        private System.Windows.Forms.Label lblKhHoTen;
        private System.Windows.Forms.TextBox txtKhHoTen;
        private System.Windows.Forms.Label lblKhSdt;
        private System.Windows.Forms.TextBox txtKhSdt;
        private System.Windows.Forms.Label lblKhEmail;
        private System.Windows.Forms.TextBox txtKhEmail;
        private System.Windows.Forms.Button btnKhThem;
        private System.Windows.Forms.Button btnKhSua;
        private System.Windows.Forms.Button btnKhXoa;
        private System.Windows.Forms.Button btnKhLamMoi;
        private System.Windows.Forms.TextBox txtKhTim;
        private System.Windows.Forms.Button btnKhTim;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhEmail;

        private System.Windows.Forms.GroupBox grpDatThongTin;
        private System.Windows.Forms.Label lblDatKhach;
        private System.Windows.Forms.ComboBox cboDatKhach;
        private System.Windows.Forms.Label lblDatTour;
        private System.Windows.Forms.ComboBox cboDatTour;
        private System.Windows.Forms.Label lblDatSoNguoi;
        private System.Windows.Forms.NumericUpDown nudDatSoNguoi;
        private System.Windows.Forms.Label lblGiaNguoi;
        private System.Windows.Forms.Label lblGiaNguoiValue;
        private System.Windows.Forms.Label lblTyGia;
        private System.Windows.Forms.Label lblTyGiaValue;
        private System.Windows.Forms.Label lblTyGiaNguon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienValue;
        private System.Windows.Forms.Button btnDatTour;
        private System.Windows.Forms.TextBox txtDatTim;
        private System.Windows.Forms.ComboBox cboDatThang;
        private System.Windows.Forms.Button btnDatTim;
        private System.Windows.Forms.Button btnDatBoLoc;
        private System.Windows.Forms.DataGridView dgvDatTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatTenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatSoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatTyGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatNgay;
        private System.Windows.Forms.Label lblDoanhThu;
    }
}
