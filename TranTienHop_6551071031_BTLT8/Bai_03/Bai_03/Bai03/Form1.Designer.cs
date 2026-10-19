namespace Bai03
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
            tlpMain = new TableLayoutPanel();
            pnlLeft = new Panel();
            lstLop = new ListBox();
            lblLop = new Label();
            pnlCenter = new Panel();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            grpThongTinSV = new GroupBox();
            tlpSV = new TableLayoutPanel();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            pnlGioiTinh = new FlowLayoutPanel();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblMaLop = new Label();
            cboLop = new ComboBox();
            flpSVButtons = new FlowLayoutPanel();
            btnThemSV = new Button();
            btnSuaSV = new Button();
            btnXoaSV = new Button();
            grpDiem = new GroupBox();
            tlpDiem = new TableLayoutPanel();
            dgvDiem = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colSoTC = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            pnlDiemInput = new Panel();
            flpPrintButtons = new FlowLayoutPanel();
            btnXemTruoc = new Button();
            btnIn = new Button();
            btnCaiDatTrang = new Button();
            btnXuatExcel = new Button();
            pnlTongKet = new FlowLayoutPanel();
            lblTongTinChi = new Label();
            lblDiemTB = new Label();
            lblXepLoai = new Label();
            flpDiemButtons = new FlowLayoutPanel();
            btnThemMon = new Button();
            btnSuaDiem = new Button();
            btnXoaMon = new Button();
            nudDiem = new NumericUpDown();
            lblDiemNhap = new Label();
            nudTinChi = new NumericUpDown();
            lblTinChi = new Label();
            txtTenMon = new TextBox();
            lblTenMon = new Label();
            tlpMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            grpThongTinSV.SuspendLayout();
            tlpSV.SuspendLayout();
            pnlGioiTinh.SuspendLayout();
            flpSVButtons.SuspendLayout();
            grpDiem.SuspendLayout();
            tlpDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            pnlDiemInput.SuspendLayout();
            flpPrintButtons.SuspendLayout();
            pnlTongKet.SuspendLayout();
            flpDiemButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTinChi).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpMain.Controls.Add(pnlLeft, 0, 0);
            tlpMain.Controls.Add(pnlCenter, 1, 0);
            tlpMain.Controls.Add(grpThongTinSV, 2, 0);
            tlpMain.Controls.Add(grpDiem, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(10, 10);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tlpMain.Size = new Size(1164, 680);
            tlpMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(lstLop);
            pnlLeft.Controls.Add(lblLop);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(3, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(0, 0, 6, 0);
            pnlLeft.Size = new Size(174, 320);
            pnlLeft.TabIndex = 0;
            // 
            // lstLop
            // 
            lstLop.Dock = DockStyle.Fill;
            lstLop.FormattingEnabled = true;
            lstLop.Location = new Point(0, 28);
            lstLop.Name = "lstLop";
            lstLop.Size = new Size(168, 292);
            lstLop.TabIndex = 0;
            // 
            // lblLop
            // 
            lblLop.Dock = DockStyle.Top;
            lblLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLop.Location = new Point(0, 0);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(168, 28);
            lblLop.TabIndex = 1;
            lblLop.Text = "Danh sách lớp";
            lblLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(dgvSinhVien);
            pnlCenter.Controls.Add(txtTimKiem);
            pnlCenter.Controls.Add(lblTimKiem);
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Location = new Point(183, 3);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Padding = new Padding(3, 0, 6, 0);
            pnlCenter.Size = new Size(535, 320);
            pnlCenter.TabIndex = 1;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.ColumnHeadersHeight = 28;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colLop });
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.Location = new Point(3, 51);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 28;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(526, 269);
            dgvSinhVien.TabIndex = 1;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaSV.DefaultCellStyle = dataGridViewCellStyle2;
            colMaSV.FillWeight = 70F;
            colMaSV.HeaderText = "MSSV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 140F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            colNgaySinh.DefaultCellStyle = dataGridViewCellStyle3;
            colNgaySinh.FillWeight = 90F;
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.DefaultCellStyle = dataGridViewCellStyle2;
            colGioiTinh.FillWeight = 55F;
            colGioiTinh.HeaderText = "GT";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colLop
            // 
            colLop.DataPropertyName = "TenLop";
            colLop.FillWeight = 120F;
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 6;
            colLop.Name = "colLop";
            colLop.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Top;
            txtTimKiem.Location = new Point(3, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập MSSV hoặc họ tên...";
            txtTimKiem.Size = new Size(526, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Dock = DockStyle.Top;
            lblTimKiem.Location = new Point(3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(526, 24);
            lblTimKiem.TabIndex = 2;
            lblTimKiem.Text = "Tìm MSSV / Họ tên:";
            // 
            // grpThongTinSV
            // 
            grpThongTinSV.Controls.Add(tlpSV);
            grpThongTinSV.Controls.Add(flpSVButtons);
            grpThongTinSV.Dock = DockStyle.Fill;
            grpThongTinSV.Location = new Point(724, 3);
            grpThongTinSV.Name = "grpThongTinSV";
            grpThongTinSV.Padding = new Padding(8);
            grpThongTinSV.Size = new Size(437, 320);
            grpThongTinSV.TabIndex = 2;
            grpThongTinSV.TabStop = false;
            grpThongTinSV.Text = "Thông tin sinh viên";
            // 
            // tlpSV
            // 
            tlpSV.ColumnCount = 2;
            tlpSV.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpSV.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSV.Controls.Add(lblMaSV, 0, 0);
            tlpSV.Controls.Add(txtMaSV, 1, 0);
            tlpSV.Controls.Add(lblHoTen, 0, 1);
            tlpSV.Controls.Add(txtHoTen, 1, 1);
            tlpSV.Controls.Add(lblNgaySinh, 0, 2);
            tlpSV.Controls.Add(dtpNgaySinh, 1, 2);
            tlpSV.Controls.Add(lblGioiTinh, 0, 3);
            tlpSV.Controls.Add(pnlGioiTinh, 1, 3);
            tlpSV.Controls.Add(lblMaLop, 0, 4);
            tlpSV.Controls.Add(cboLop, 1, 4);
            tlpSV.Dock = DockStyle.Top;
            tlpSV.Location = new Point(8, 28);
            tlpSV.Name = "tlpSV";
            tlpSV.RowCount = 5;
            tlpSV.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpSV.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpSV.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpSV.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpSV.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpSV.Size = new Size(421, 180);
            tlpSV.TabIndex = 0;
            // 
            // lblMaSV
            // 
            lblMaSV.Anchor = AnchorStyles.Left;
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(3, 8);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(50, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "MSSV:";
            // 
            // txtMaSV
            // 
            txtMaSV.Dock = DockStyle.Fill;
            txtMaSV.Location = new Point(93, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(325, 27);
            txtMaSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Left;
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(3, 44);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(57, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(93, 39);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(325, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Left;
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(3, 80);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(93, 75);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(325, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Left;
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(3, 116);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // pnlGioiTinh
            // 
            pnlGioiTinh.Controls.Add(rdoNam);
            pnlGioiTinh.Controls.Add(rdoNu);
            pnlGioiTinh.Dock = DockStyle.Fill;
            pnlGioiTinh.Location = new Point(93, 111);
            pnlGioiTinh.Name = "pnlGioiTinh";
            pnlGioiTinh.Size = new Size(325, 30);
            pnlGioiTinh.TabIndex = 7;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(3, 3);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(71, 3);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 1;
            rdoNu.Text = "Nữ";
            // 
            // lblMaLop
            // 
            lblMaLop.Anchor = AnchorStyles.Left;
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(3, 152);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(37, 20);
            lblMaLop.TabIndex = 8;
            lblMaLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            cboLop.Dock = DockStyle.Fill;
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(93, 147);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(325, 28);
            cboLop.TabIndex = 9;
            // 
            // flpSVButtons
            // 
            flpSVButtons.Controls.Add(btnThemSV);
            flpSVButtons.Controls.Add(btnSuaSV);
            flpSVButtons.Controls.Add(btnXoaSV);
            flpSVButtons.Dock = DockStyle.Bottom;
            flpSVButtons.Location = new Point(8, 260);
            flpSVButtons.Name = "flpSVButtons";
            flpSVButtons.Padding = new Padding(0, 4, 0, 4);
            flpSVButtons.Size = new Size(421, 52);
            flpSVButtons.TabIndex = 1;
            // 
            // btnThemSV
            // 
            btnThemSV.Location = new Point(3, 7);
            btnThemSV.Name = "btnThemSV";
            btnThemSV.Size = new Size(90, 36);
            btnThemSV.TabIndex = 0;
            btnThemSV.Text = "Thêm SV";
            // 
            // btnSuaSV
            // 
            btnSuaSV.Location = new Point(99, 7);
            btnSuaSV.Name = "btnSuaSV";
            btnSuaSV.Size = new Size(90, 36);
            btnSuaSV.TabIndex = 1;
            btnSuaSV.Text = "Sửa SV";
            // 
            // btnXoaSV
            // 
            btnXoaSV.Location = new Point(195, 7);
            btnXoaSV.Name = "btnXoaSV";
            btnXoaSV.Size = new Size(90, 36);
            btnXoaSV.TabIndex = 2;
            btnXoaSV.Text = "Xóa SV";
            // 
            // grpDiem
            // 
            tlpMain.SetColumnSpan(grpDiem, 3);
            grpDiem.Controls.Add(tlpDiem);
            grpDiem.Dock = DockStyle.Fill;
            grpDiem.Location = new Point(3, 329);
            grpDiem.Name = "grpDiem";
            grpDiem.Padding = new Padding(8);
            grpDiem.Size = new Size(1158, 348);
            grpDiem.TabIndex = 3;
            grpDiem.TabStop = false;
            grpDiem.Text = "Điểm môn học";
            // 
            // tlpDiem
            // 
            tlpDiem.ColumnCount = 2;
            tlpDiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDiem.Controls.Add(dgvDiem, 0, 0);
            tlpDiem.Controls.Add(pnlDiemInput, 1, 0);
            tlpDiem.Dock = DockStyle.Fill;
            tlpDiem.Location = new Point(8, 28);
            tlpDiem.Name = "tlpDiem";
            tlpDiem.RowCount = 1;
            tlpDiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDiem.Size = new Size(1142, 312);
            tlpDiem.TabIndex = 0;
            // 
            // dgvDiem
            // 
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.AllowUserToDeleteRows = false;
            dgvDiem.AllowUserToResizeRows = false;
            dgvDiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiem.BackgroundColor = Color.White;
            dgvDiem.ColumnHeadersHeight = 28;
            dgvDiem.Columns.AddRange(new DataGridViewColumn[] { colSTT, colMon, colSoTC, colDiem });
            dgvDiem.Dock = DockStyle.Fill;
            dgvDiem.Location = new Point(3, 3);
            dgvDiem.MultiSelect = false;
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.RowHeadersWidth = 28;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(679, 306);
            dgvDiem.TabIndex = 0;
            // 
            // colSTT
            // 
            colSTT.DataPropertyName = "STT";
            colSTT.DefaultCellStyle = dataGridViewCellStyle2;
            colSTT.FillWeight = 40F;
            colSTT.HeaderText = "STT";
            colSTT.MinimumWidth = 6;
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            // 
            // colMon
            // 
            colMon.DataPropertyName = "TenMon";
            colMon.FillWeight = 160F;
            colMon.HeaderText = "Môn";
            colMon.MinimumWidth = 6;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            // 
            // colSoTC
            // 
            colSoTC.DataPropertyName = "SoTinChi";
            colSoTC.DefaultCellStyle = dataGridViewCellStyle2;
            colSoTC.FillWeight = 50F;
            colSoTC.HeaderText = "Số TC";
            colSoTC.MinimumWidth = 6;
            colSoTC.Name = "colSoTC";
            colSoTC.ReadOnly = true;
            // 
            // colDiem
            // 
            colDiem.DataPropertyName = "Diem";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.0";
            colDiem.DefaultCellStyle = dataGridViewCellStyle4;
            colDiem.FillWeight = 55F;
            colDiem.HeaderText = "Điểm";
            colDiem.MinimumWidth = 6;
            colDiem.Name = "colDiem";
            colDiem.ReadOnly = true;
            // 
            // pnlDiemInput
            // 
            pnlDiemInput.Controls.Add(flpPrintButtons);
            pnlDiemInput.Controls.Add(pnlTongKet);
            pnlDiemInput.Controls.Add(flpDiemButtons);
            pnlDiemInput.Controls.Add(nudDiem);
            pnlDiemInput.Controls.Add(lblDiemNhap);
            pnlDiemInput.Controls.Add(nudTinChi);
            pnlDiemInput.Controls.Add(lblTinChi);
            pnlDiemInput.Controls.Add(txtTenMon);
            pnlDiemInput.Controls.Add(lblTenMon);
            pnlDiemInput.Dock = DockStyle.Fill;
            pnlDiemInput.Location = new Point(688, 3);
            pnlDiemInput.Name = "pnlDiemInput";
            pnlDiemInput.Padding = new Padding(8, 0, 0, 0);
            pnlDiemInput.Size = new Size(451, 306);
            pnlDiemInput.TabIndex = 1;
            // 
            // flpPrintButtons
            // 
            flpPrintButtons.Controls.Add(btnXemTruoc);
            flpPrintButtons.Controls.Add(btnIn);
            flpPrintButtons.Controls.Add(btnCaiDatTrang);
            flpPrintButtons.Controls.Add(btnXuatExcel);
            flpPrintButtons.Location = new Point(8, 250);
            flpPrintButtons.Name = "flpPrintButtons";
            flpPrintButtons.Size = new Size(400, 90);
            flpPrintButtons.TabIndex = 0;
            // 
            // btnXemTruoc
            // 
            btnXemTruoc.Location = new Point(3, 3);
            btnXemTruoc.Name = "btnXemTruoc";
            btnXemTruoc.Size = new Size(140, 36);
            btnXemTruoc.TabIndex = 0;
            btnXemTruoc.Text = "Xem trước phiếu";
            // 
            // btnIn
            // 
            btnIn.Location = new Point(149, 3);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 36);
            btnIn.TabIndex = 1;
            btnIn.Text = "In...";
            // 
            // btnCaiDatTrang
            // 
            btnCaiDatTrang.Location = new Point(245, 3);
            btnCaiDatTrang.Name = "btnCaiDatTrang";
            btnCaiDatTrang.Size = new Size(130, 36);
            btnCaiDatTrang.TabIndex = 2;
            btnCaiDatTrang.Text = "Cài đặt trang...";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(3, 45);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(160, 36);
            btnXuatExcel.TabIndex = 3;
            btnXuatExcel.Text = "Xuất Excel điểm lớp";
            // 
            // pnlTongKet
            // 
            pnlTongKet.Controls.Add(lblTongTinChi);
            pnlTongKet.Controls.Add(lblDiemTB);
            pnlTongKet.Controls.Add(lblXepLoai);
            pnlTongKet.FlowDirection = FlowDirection.TopDown;
            pnlTongKet.Location = new Point(12, 156);
            pnlTongKet.Name = "pnlTongKet";
            pnlTongKet.Size = new Size(360, 90);
            pnlTongKet.TabIndex = 1;
            pnlTongKet.WrapContents = false;
            // 
            // lblTongTinChi
            // 
            lblTongTinChi.AutoSize = true;
            lblTongTinChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongTinChi.Location = new Point(3, 0);
            lblTongTinChi.Name = "lblTongTinChi";
            lblTongTinChi.Size = new Size(109, 20);
            lblTongTinChi.TabIndex = 0;
            lblTongTinChi.Text = "Tổng tín chỉ: 0";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiemTB.Location = new Point(3, 20);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(108, 20);
            lblDiemTB.TabIndex = 1;
            lblDiemTB.Text = "Điểm TB: 0.00";
            // 
            // lblXepLoai
            // 
            lblXepLoai.AutoSize = true;
            lblXepLoai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblXepLoai.Location = new Point(3, 40);
            lblXepLoai.Name = "lblXepLoai";
            lblXepLoai.Size = new Size(168, 20);
            lblXepLoai.TabIndex = 2;
            lblXepLoai.Text = "Xếp loại: Chưa có điểm";
            // 
            // flpDiemButtons
            // 
            flpDiemButtons.Controls.Add(btnThemMon);
            flpDiemButtons.Controls.Add(btnSuaDiem);
            flpDiemButtons.Controls.Add(btnXoaMon);
            flpDiemButtons.Location = new Point(8, 104);
            flpDiemButtons.Name = "flpDiemButtons";
            flpDiemButtons.Size = new Size(360, 44);
            flpDiemButtons.TabIndex = 2;
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(3, 3);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(100, 36);
            btnThemMon.TabIndex = 0;
            btnThemMon.Text = "Thêm môn";
            // 
            // btnSuaDiem
            // 
            btnSuaDiem.Location = new Point(109, 3);
            btnSuaDiem.Name = "btnSuaDiem";
            btnSuaDiem.Size = new Size(100, 36);
            btnSuaDiem.TabIndex = 1;
            btnSuaDiem.Text = "Sửa điểm";
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(215, 3);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(100, 36);
            btnXoaMon.TabIndex = 2;
            btnXoaMon.Text = "Xóa môn";
            // 
            // nudDiem
            // 
            nudDiem.DecimalPlaces = 1;
            nudDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudDiem.Location = new Point(270, 64);
            nudDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDiem.Name = "nudDiem";
            nudDiem.Size = new Size(80, 27);
            nudDiem.TabIndex = 3;
            // 
            // lblDiemNhap
            // 
            lblDiemNhap.AutoSize = true;
            lblDiemNhap.Location = new Point(220, 68);
            lblDiemNhap.Name = "lblDiemNhap";
            lblDiemNhap.Size = new Size(48, 20);
            lblDiemNhap.TabIndex = 4;
            lblDiemNhap.Text = "Điểm:";
            // 
            // nudTinChi
            // 
            nudTinChi.Location = new Point(120, 64);
            nudTinChi.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudTinChi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTinChi.Name = "nudTinChi";
            nudTinChi.Size = new Size(80, 27);
            nudTinChi.TabIndex = 5;
            nudTinChi.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblTinChi
            // 
            lblTinChi.AutoSize = true;
            lblTinChi.Location = new Point(12, 68);
            lblTinChi.Name = "lblTinChi";
            lblTinChi.Size = new Size(85, 20);
            lblTinChi.TabIndex = 6;
            lblTinChi.Text = "Số TC (1-6):";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(12, 32);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(320, 27);
            txtTenMon.TabIndex = 7;
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.Location = new Point(12, 8);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(69, 20);
            lblTenMon.TabIndex = 8;
            lblTenMon.Text = "Tên môn:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 700);
            Controls.Add(tlpMain);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 650);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu báo điểm - Quản lý điểm sinh viên";
            tlpMain.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            grpThongTinSV.ResumeLayout(false);
            tlpSV.ResumeLayout(false);
            tlpSV.PerformLayout();
            pnlGioiTinh.ResumeLayout(false);
            pnlGioiTinh.PerformLayout();
            flpSVButtons.ResumeLayout(false);
            grpDiem.ResumeLayout(false);
            tlpDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            pnlDiemInput.ResumeLayout(false);
            pnlDiemInput.PerformLayout();
            flpPrintButtons.ResumeLayout(false);
            pnlTongKet.ResumeLayout(false);
            pnlTongKet.PerformLayout();
            flpDiemButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudDiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTinChi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlLeft;
        private Label lblLop;
        private ListBox lstLop;
        private Panel pnlCenter;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colLop;
        private GroupBox grpThongTinSV;
        private TableLayoutPanel tlpSV;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private FlowLayoutPanel pnlGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblMaLop;
        private ComboBox cboLop;
        private FlowLayoutPanel flpSVButtons;
        private Button btnThemSV;
        private Button btnSuaSV;
        private Button btnXoaSV;
        private GroupBox grpDiem;
        private TableLayoutPanel tlpDiem;
        private DataGridView dgvDiem;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colSoTC;
        private DataGridViewTextBoxColumn colDiem;
        private Panel pnlDiemInput;
        private Label lblTenMon;
        private TextBox txtTenMon;
        private Label lblTinChi;
        private NumericUpDown nudTinChi;
        private Label lblDiemNhap;
        private NumericUpDown nudDiem;
        private FlowLayoutPanel flpDiemButtons;
        private Button btnThemMon;
        private Button btnSuaDiem;
        private Button btnXoaMon;
        private FlowLayoutPanel pnlTongKet;
        private Label lblTongTinChi;
        private Label lblDiemTB;
        private Label lblXepLoai;
        private FlowLayoutPanel flpPrintButtons;
        private Button btnXemTruoc;
        private Button btnIn;
        private Button btnCaiDatTrang;
        private Button btnXuatExcel;
    }
}
