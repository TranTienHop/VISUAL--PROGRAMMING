namespace Bai02
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            grpTimKiem = new GroupBox();
            tlpTimKiem = new TableLayoutPanel();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            lblLocBan = new Label();
            cboLocBan = new ComboBox();
            lblLocHinhThuc = new Label();
            cboLocHinhThuc = new ComboBox();
            lblTenMonLoc = new Label();
            txtTenMon = new TextBox();
            btnTim = new Button();
            btnBoLoc = new Button();
            lblTongDoanhThu = new Label();
            splitMain = new SplitContainer();
            grpHoaDon = new GroupBox();
            dgvHoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colSoBan = new DataGridViewTextBoxColumn();
            colHinhThucTT = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            pnlRight = new Panel();
            grpChiTiet = new GroupBox();
            dgvChiTiet = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblTongCong = new Label();
            grpThongTin = new GroupBox();
            tlpThongTin = new TableLayoutPanel();
            lblNgayLap = new Label();
            dtpNgayLap = new DateTimePicker();
            lblSoBan = new Label();
            cboSoBan = new ComboBox();
            lblHinhThuc = new Label();
            pnlHinhThuc = new Panel();
            rdoTienMat = new RadioButton();
            rdoChuyenKhoan = new RadioButton();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            lblMon = new Label();
            cboMon = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            pnlBottom = new Panel();
            flpButtons = new FlowLayoutPanel();
            btnHoaDonMoi = new Button();
            btnSuaHoaDon = new Button();
            btnXoaHoaDon = new Button();
            btnThemMon = new Button();
            btnSuaSL = new Button();
            btnXoaMon = new Button();
            btnXemHoaDon = new Button();
            btnXuatPdf = new Button();
            btnIn = new Button();
            grpTimKiem.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            pnlRight.SuspendLayout();
            grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            grpThongTin.SuspendLayout();
            tlpThongTin.SuspendLayout();
            pnlHinhThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            pnlBottom.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(tlpTimKiem);
            grpTimKiem.Dock = DockStyle.Top;
            grpTimKiem.Font = new Font("Segoe UI", 9F);
            grpTimKiem.Location = new Point(10, 10);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Padding = new Padding(8, 4, 8, 4);
            grpTimKiem.Size = new Size(1180, 88);
            grpTimKiem.TabIndex = 0;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm / Lọc";
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 12;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpTimKiem.Controls.Add(lblTuNgay, 0, 0);
            tlpTimKiem.Controls.Add(dtpTuNgay, 1, 0);
            tlpTimKiem.Controls.Add(lblDenNgay, 2, 0);
            tlpTimKiem.Controls.Add(dtpDenNgay, 3, 0);
            tlpTimKiem.Controls.Add(lblLocBan, 4, 0);
            tlpTimKiem.Controls.Add(cboLocBan, 5, 0);
            tlpTimKiem.Controls.Add(lblLocHinhThuc, 6, 0);
            tlpTimKiem.Controls.Add(cboLocHinhThuc, 7, 0);
            tlpTimKiem.Controls.Add(lblTenMonLoc, 8, 0);
            tlpTimKiem.Controls.Add(txtTenMon, 9, 0);
            tlpTimKiem.Controls.Add(btnTim, 10, 0);
            tlpTimKiem.Controls.Add(btnBoLoc, 11, 0);
            tlpTimKiem.Controls.Add(lblTongDoanhThu, 0, 1);
            tlpTimKiem.Dock = DockStyle.Fill;
            tlpTimKiem.Location = new Point(8, 24);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 2;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpTimKiem.Size = new Size(1164, 60);
            tlpTimKiem.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            lblTuNgay.Anchor = AnchorStyles.Left;
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(3, 7);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(62, 20);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Dock = DockStyle.Fill;
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(73, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(124, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.Anchor = AnchorStyles.Left;
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(203, 7);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(69, 20);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Dock = DockStyle.Fill;
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(278, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(124, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblLocBan
            // 
            lblLocBan.Anchor = AnchorStyles.Left;
            lblLocBan.AutoSize = true;
            lblLocBan.Location = new Point(408, 7);
            lblLocBan.Name = "lblLocBan";
            lblLocBan.Size = new Size(34, 20);
            lblLocBan.TabIndex = 4;
            lblLocBan.Text = "Bàn:";
            // 
            // cboLocBan
            // 
            cboLocBan.Dock = DockStyle.Fill;
            cboLocBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocBan.FormattingEnabled = true;
            cboLocBan.Location = new Point(448, 3);
            cboLocBan.Name = "cboLocBan";
            cboLocBan.Size = new Size(84, 28);
            cboLocBan.TabIndex = 5;
            // 
            // lblLocHinhThuc
            // 
            lblLocHinhThuc.Anchor = AnchorStyles.Left;
            lblLocHinhThuc.AutoSize = true;
            lblLocHinhThuc.Location = new Point(538, 7);
            lblLocHinhThuc.Name = "lblLocHinhThuc";
            lblLocHinhThuc.Size = new Size(71, 20);
            lblLocHinhThuc.TabIndex = 6;
            lblLocHinhThuc.Text = "Hình thức:";
            // 
            // cboLocHinhThuc
            // 
            cboLocHinhThuc.Dock = DockStyle.Fill;
            cboLocHinhThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocHinhThuc.FormattingEnabled = true;
            cboLocHinhThuc.Location = new Point(618, 3);
            cboLocHinhThuc.Name = "cboLocHinhThuc";
            cboLocHinhThuc.Size = new Size(114, 28);
            cboLocHinhThuc.TabIndex = 7;
            // 
            // lblTenMonLoc
            // 
            lblTenMonLoc.Anchor = AnchorStyles.Left;
            lblTenMonLoc.AutoSize = true;
            lblTenMonLoc.Location = new Point(738, 7);
            lblTenMonLoc.Name = "lblTenMonLoc";
            lblTenMonLoc.Size = new Size(64, 20);
            lblTenMonLoc.TabIndex = 8;
            lblTenMonLoc.Text = "Tên món:";
            // 
            // txtTenMon
            // 
            txtTenMon.Dock = DockStyle.Fill;
            txtTenMon.Location = new Point(808, 3);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.PlaceholderText = "Lọc theo tên món...";
            txtTenMon.Size = new Size(173, 27);
            txtTenMon.TabIndex = 9;
            // 
            // btnTim
            // 
            btnTim.Dock = DockStyle.Fill;
            btnTim.Location = new Point(987, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(84, 28);
            btnTim.TabIndex = 10;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnBoLoc
            // 
            btnBoLoc.Dock = DockStyle.Fill;
            btnBoLoc.Location = new Point(1077, 3);
            btnBoLoc.Name = "btnBoLoc";
            btnBoLoc.Size = new Size(84, 28);
            btnBoLoc.TabIndex = 11;
            btnBoLoc.Text = "Bỏ lọc";
            btnBoLoc.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhThu
            // 
            tlpTimKiem.SetColumnSpan(lblTongDoanhThu, 12);
            lblTongDoanhThu.Dock = DockStyle.Fill;
            lblTongDoanhThu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongDoanhThu.ForeColor = Color.DarkGreen;
            lblTongDoanhThu.Location = new Point(3, 34);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(1158, 26);
            lblTongDoanhThu.TabIndex = 12;
            lblTongDoanhThu.Text = "Tổng doanh thu: 0 đ";
            lblTongDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(10, 98);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpHoaDon);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlRight);
            splitMain.Size = new Size(1180, 360);
            splitMain.SplitterDistance = 620;
            splitMain.TabIndex = 1;
            // 
            // grpHoaDon
            // 
            grpHoaDon.Controls.Add(dgvHoaDon);
            grpHoaDon.Dock = DockStyle.Fill;
            grpHoaDon.Font = new Font("Segoe UI", 9F);
            grpHoaDon.Location = new Point(0, 0);
            grpHoaDon.Name = "grpHoaDon";
            grpHoaDon.Padding = new Padding(6);
            grpHoaDon.Size = new Size(620, 360);
            grpHoaDon.TabIndex = 0;
            grpHoaDon.TabStop = false;
            grpHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.ColumnHeadersHeight = 28;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colNgayLap, colSoBan, colHinhThucTT, colTongTien });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(6, 26);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 24;
            dgvHoaDon.RowTemplate.Height = 26;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(608, 328);
            dgvHoaDon.TabIndex = 0;
            // 
            // colMaHD
            // 
            colMaHD.DataPropertyName = "MaHDText";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaHD.DefaultCellStyle = dataGridViewCellStyle3;
            colMaHD.FillWeight = 80F;
            colMaHD.HeaderText = "Mã HĐ";
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colNgayLap
            // 
            colNgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm";
            colNgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            colNgayLap.FillWeight = 120F;
            colNgayLap.HeaderText = "Ngày lập";
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            // 
            // colSoBan
            // 
            colSoBan.DataPropertyName = "SoBan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoBan.DefaultCellStyle = dataGridViewCellStyle5;
            colSoBan.FillWeight = 45F;
            colSoBan.HeaderText = "Bàn";
            colSoBan.Name = "colSoBan";
            colSoBan.ReadOnly = true;
            // 
            // colHinhThucTT
            // 
            colHinhThucTT.DataPropertyName = "HinhThucTT";
            colHinhThucTT.FillWeight = 90F;
            colHinhThucTT.HeaderText = "Hình thức TT";
            colHinhThucTT.Name = "colHinhThucTT";
            colHinhThucTT.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            colTongTien.DefaultCellStyle = dataGridViewCellStyle6;
            colTongTien.FillWeight = 80F;
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpChiTiet);
            pnlRight.Controls.Add(lblTongCong);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(0, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(556, 360);
            pnlRight.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(dgvChiTiet);
            grpChiTiet.Dock = DockStyle.Fill;
            grpChiTiet.Font = new Font("Segoe UI", 9F);
            grpChiTiet.Location = new Point(0, 0);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Padding = new Padding(6);
            grpChiTiet.Size = new Size(556, 310);
            grpChiTiet.TabIndex = 0;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AllowUserToResizeRows = false;
            dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.Fixed3D;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTiet.ColumnHeadersHeight = 28;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colSTT, colTenMon, colSL, colDonGia, colThanhTien });
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(6, 26);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 24;
            dgvChiTiet.RowTemplate.Height = 26;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(544, 278);
            dgvChiTiet.TabIndex = 0;
            // 
            // colSTT
            // 
            colSTT.DataPropertyName = "STT";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSTT.DefaultCellStyle = dataGridViewCellStyle7;
            colSTT.FillWeight = 40F;
            colSTT.HeaderText = "STT";
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colTenMon
            // 
            colTenMon.DataPropertyName = "TenMon";
            colTenMon.FillWeight = 140F;
            colTenMon.HeaderText = "Tên món";
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            // 
            // colSL
            // 
            colSL.DataPropertyName = "SoLuong";
            colSL.DefaultCellStyle = dataGridViewCellStyle7;
            colSL.FillWeight = 40F;
            colSL.HeaderText = "SL";
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle8;
            colDonGia.FillWeight = 70F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle8;
            colThanhTien.FillWeight = 80F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblTongCong
            // 
            lblTongCong.Dock = DockStyle.Bottom;
            lblTongCong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongCong.ForeColor = Color.Firebrick;
            lblTongCong.Location = new Point(0, 310);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Padding = new Padding(8, 0, 8, 0);
            lblTongCong.Size = new Size(556, 50);
            lblTongCong.TabIndex = 1;
            lblTongCong.Text = "Tổng cộng: 0 đ";
            lblTongCong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tlpThongTin);
            grpThongTin.Dock = DockStyle.Bottom;
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(10, 458);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(8, 4, 8, 4);
            grpThongTin.Size = new Size(1180, 150);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hóa đơn / Món";
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 6;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpThongTin.Controls.Add(lblNgayLap, 0, 0);
            tlpThongTin.Controls.Add(dtpNgayLap, 1, 0);
            tlpThongTin.Controls.Add(lblSoBan, 2, 0);
            tlpThongTin.Controls.Add(cboSoBan, 3, 0);
            tlpThongTin.Controls.Add(lblHinhThuc, 4, 0);
            tlpThongTin.Controls.Add(pnlHinhThuc, 5, 0);
            tlpThongTin.Controls.Add(lblGhiChu, 0, 1);
            tlpThongTin.Controls.Add(txtGhiChu, 1, 1);
            tlpThongTin.Controls.Add(lblMon, 0, 2);
            tlpThongTin.Controls.Add(cboMon, 1, 2);
            tlpThongTin.Controls.Add(lblSoLuong, 4, 2);
            tlpThongTin.Controls.Add(nudSoLuong, 5, 2);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(8, 24);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 3;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpThongTin.Size = new Size(1164, 122);
            tlpThongTin.TabIndex = 0;
            // 
            // lblNgayLap
            // 
            lblNgayLap.Anchor = AnchorStyles.Left;
            lblNgayLap.AutoSize = true;
            lblNgayLap.Location = new Point(3, 9);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(68, 20);
            lblNgayLap.TabIndex = 0;
            lblNgayLap.Text = "Ngày lập:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayLap.Dock = DockStyle.Fill;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(93, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.ShowUpDown = true;
            dtpNgayLap.Size = new Size(292, 27);
            dtpNgayLap.TabIndex = 1;
            // 
            // lblSoBan
            // 
            lblSoBan.Anchor = AnchorStyles.Left;
            lblSoBan.AutoSize = true;
            lblSoBan.Location = new Point(391, 9);
            lblSoBan.Name = "lblSoBan";
            lblSoBan.Size = new Size(52, 20);
            lblSoBan.TabIndex = 2;
            lblSoBan.Text = "Số bàn:";
            // 
            // cboSoBan
            // 
            cboSoBan.Dock = DockStyle.Fill;
            cboSoBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSoBan.FormattingEnabled = true;
            cboSoBan.Location = new Point(481, 3);
            cboSoBan.Name = "cboSoBan";
            cboSoBan.Size = new Size(292, 28);
            cboSoBan.TabIndex = 3;
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.Anchor = AnchorStyles.Left;
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Location = new Point(779, 9);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(71, 20);
            lblHinhThuc.TabIndex = 4;
            lblHinhThuc.Text = "Hình thức:";
            // 
            // pnlHinhThuc
            // 
            pnlHinhThuc.Controls.Add(rdoTienMat);
            pnlHinhThuc.Controls.Add(rdoChuyenKhoan);
            pnlHinhThuc.Dock = DockStyle.Fill;
            pnlHinhThuc.Location = new Point(869, 3);
            pnlHinhThuc.Name = "pnlHinhThuc";
            pnlHinhThuc.Size = new Size(292, 32);
            pnlHinhThuc.TabIndex = 5;
            // 
            // rdoTienMat
            // 
            rdoTienMat.AutoSize = true;
            rdoTienMat.Checked = true;
            rdoTienMat.Location = new Point(3, 4);
            rdoTienMat.Name = "rdoTienMat";
            rdoTienMat.Size = new Size(90, 24);
            rdoTienMat.TabIndex = 0;
            rdoTienMat.TabStop = true;
            rdoTienMat.Text = "Tiền mặt";
            rdoTienMat.UseVisualStyleBackColor = true;
            // 
            // rdoChuyenKhoan
            // 
            rdoChuyenKhoan.AutoSize = true;
            rdoChuyenKhoan.Location = new Point(110, 4);
            rdoChuyenKhoan.Name = "rdoChuyenKhoan";
            rdoChuyenKhoan.Size = new Size(126, 24);
            rdoChuyenKhoan.TabIndex = 1;
            rdoChuyenKhoan.Text = "Chuyển khoản";
            rdoChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Anchor = AnchorStyles.Left;
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(3, 52);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(58, 20);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            tlpThongTin.SetColumnSpan(txtGhiChu, 5);
            txtGhiChu.Dock = DockStyle.Fill;
            txtGhiChu.Location = new Point(93, 41);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(1068, 42);
            txtGhiChu.TabIndex = 7;
            // 
            // lblMon
            // 
            lblMon.Anchor = AnchorStyles.Left;
            lblMon.AutoSize = true;
            lblMon.Location = new Point(3, 96);
            lblMon.Name = "lblMon";
            lblMon.Size = new Size(40, 20);
            lblMon.TabIndex = 8;
            lblMon.Text = "Món:";
            // 
            // cboMon
            // 
            tlpThongTin.SetColumnSpan(cboMon, 3);
            cboMon.Dock = DockStyle.Fill;
            cboMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMon.FormattingEnabled = true;
            cboMon.Location = new Point(93, 89);
            cboMon.Name = "cboMon";
            cboMon.Size = new Size(680, 28);
            cboMon.TabIndex = 9;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Anchor = AnchorStyles.Left;
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(779, 96);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(70, 20);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Dock = DockStyle.Fill;
            nudSoLuong.Location = new Point(869, 89);
            nudSoLuong.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(292, 27);
            nudSoLuong.TabIndex = 11;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(flpButtons);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(10, 608);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1180, 52);
            pnlBottom.TabIndex = 3;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnHoaDonMoi);
            flpButtons.Controls.Add(btnSuaHoaDon);
            flpButtons.Controls.Add(btnXoaHoaDon);
            flpButtons.Controls.Add(btnThemMon);
            flpButtons.Controls.Add(btnSuaSL);
            flpButtons.Controls.Add(btnXoaMon);
            flpButtons.Controls.Add(btnXemHoaDon);
            flpButtons.Controls.Add(btnXuatPdf);
            flpButtons.Controls.Add(btnIn);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.Location = new Point(0, 0);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 6, 0, 0);
            flpButtons.Size = new Size(1180, 52);
            flpButtons.TabIndex = 0;
            // 
            // btnHoaDonMoi
            // 
            btnHoaDonMoi.Location = new Point(3, 9);
            btnHoaDonMoi.Name = "btnHoaDonMoi";
            btnHoaDonMoi.Size = new Size(110, 36);
            btnHoaDonMoi.TabIndex = 0;
            btnHoaDonMoi.Text = "Hóa đơn mới";
            btnHoaDonMoi.UseVisualStyleBackColor = true;
            // 
            // btnSuaHoaDon
            // 
            btnSuaHoaDon.Location = new Point(119, 9);
            btnSuaHoaDon.Name = "btnSuaHoaDon";
            btnSuaHoaDon.Size = new Size(110, 36);
            btnSuaHoaDon.TabIndex = 1;
            btnSuaHoaDon.Text = "Sửa hóa đơn";
            btnSuaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.Location = new Point(235, 9);
            btnXoaHoaDon.Margin = new Padding(3, 3, 14, 3);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(110, 36);
            btnXoaHoaDon.TabIndex = 2;
            btnXoaHoaDon.Text = "Xóa hóa đơn";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(362, 9);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(100, 36);
            btnThemMon.TabIndex = 3;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            // 
            // btnSuaSL
            // 
            btnSuaSL.Location = new Point(468, 9);
            btnSuaSL.Name = "btnSuaSL";
            btnSuaSL.Size = new Size(90, 36);
            btnSuaSL.TabIndex = 4;
            btnSuaSL.Text = "Sửa SL";
            btnSuaSL.UseVisualStyleBackColor = true;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(564, 9);
            btnXoaMon.Margin = new Padding(3, 3, 14, 3);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(90, 36);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = true;
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.Location = new Point(671, 9);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(110, 36);
            btnXemHoaDon.TabIndex = 6;
            btnXemHoaDon.Text = "Xem hóa đơn";
            btnXemHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.Location = new Point(787, 9);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(90, 36);
            btnXuatPdf.TabIndex = 7;
            btnXuatPdf.Text = "Xuất PDF";
            btnXuatPdf.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(883, 9);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(80, 36);
            btnIn.TabIndex = 8;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 670);
            Controls.Add(splitMain);
            Controls.Add(grpThongTin);
            Controls.Add(pnlBottom);
            Controls.Add(grpTimKiem);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 650);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hóa đơn - Quán cà phê Góc Phố";
            grpTimKiem.ResumeLayout(false);
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            pnlRight.ResumeLayout(false);
            grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            grpThongTin.ResumeLayout(false);
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            pnlHinhThuc.ResumeLayout(false);
            pnlHinhThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            pnlBottom.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTimKiem;
        private TableLayoutPanel tlpTimKiem;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Label lblLocBan;
        private ComboBox cboLocBan;
        private Label lblLocHinhThuc;
        private ComboBox cboLocHinhThuc;
        private Label lblTenMonLoc;
        private TextBox txtTenMon;
        private Button btnTim;
        private Button btnBoLoc;
        private Label lblTongDoanhThu;
        private SplitContainer splitMain;
        private GroupBox grpHoaDon;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colSoBan;
        private DataGridViewTextBoxColumn colHinhThucTT;
        private DataGridViewTextBoxColumn colTongTien;
        private Panel pnlRight;
        private GroupBox grpChiTiet;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Label lblTongCong;
        private GroupBox grpThongTin;
        private TableLayoutPanel tlpThongTin;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private Label lblSoBan;
        private ComboBox cboSoBan;
        private Label lblHinhThuc;
        private Panel pnlHinhThuc;
        private RadioButton rdoTienMat;
        private RadioButton rdoChuyenKhoan;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Label lblMon;
        private ComboBox cboMon;
        private Label lblSoLuong;
        private NumericUpDown nudSoLuong;
        private Panel pnlBottom;
        private FlowLayoutPanel flpButtons;
        private Button btnHoaDonMoi;
        private Button btnSuaHoaDon;
        private Button btnXoaHoaDon;
        private Button btnThemMon;
        private Button btnSuaSL;
        private Button btnXoaMon;
        private Button btnXemHoaDon;
        private Button btnXuatPdf;
        private Button btnIn;
    }
}
