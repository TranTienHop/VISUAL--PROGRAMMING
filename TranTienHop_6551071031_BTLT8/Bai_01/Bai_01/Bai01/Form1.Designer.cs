namespace Bai01
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
            tlpTop = new TableLayoutPanel();
            grpThongTin = new GroupBox();
            tlpThongTin = new TableLayoutPanel();
            lblTenHang = new Label();
            txtTenHang = new TextBox();
            lblLoaiHang = new Label();
            cboLoaiHang = new ComboBox();
            lblSoLuongTon = new Label();
            nudSoLuongTon = new NumericUpDown();
            lblDonVi = new Label();
            cboDonVi = new ComboBox();
            lblNgayNhap = new Label();
            dtpNgayNhap = new DateTimePicker();
            lblGiaBan = new Label();
            nudGiaBan = new NumericUpDown();
            chkConKinhDoanh = new CheckBox();
            grpTimKiem = new GroupBox();
            tlpTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            cboLocLoaiHang = new ComboBox();
            chkChiConKinhDoanh = new CheckBox();
            pnlMain = new Panel();
            dgvHangHoa = new DataGridView();
            colMaHang = new DataGridViewTextBoxColumn();
            colTenHang = new DataGridViewTextBoxColumn();
            colLoaiHang = new DataGridViewTextBoxColumn();
            colDonVi = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colSoLuongTon = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colConKinhDoanh = new DataGridViewCheckBoxColumn();
            pnlBottom = new Panel();
            flpButtons = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnXemBangGia = new Button();
            btnXuatPdf = new Button();
            btnXuatExcelLuoi = new Button();
            btnXuatExcelTonKho = new Button();
            lblTrangThai = new Label();
            tlpTop.SuspendLayout();
            grpThongTin.SuspendLayout();
            tlpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
            grpTimKiem.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            pnlBottom.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpTop
            // 
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            tlpTop.Controls.Add(grpThongTin, 0, 0);
            tlpTop.Controls.Add(grpTimKiem, 1, 0);
            tlpTop.Dock = DockStyle.Top;
            tlpTop.Location = new Point(11, 11);
            tlpTop.Margin = new Padding(3, 4, 3, 4);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(1103, 220);
            tlpTop.TabIndex = 0;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(tlpThongTin);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(3, 4);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(7, 5, 7, 5);
            grpThongTin.Size = new Size(666, 212);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hàng hóa";
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 4;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lblTenHang, 0, 0);
            tlpThongTin.Controls.Add(txtTenHang, 1, 0);
            tlpThongTin.Controls.Add(lblLoaiHang, 0, 1);
            tlpThongTin.Controls.Add(cboLoaiHang, 1, 1);
            tlpThongTin.Controls.Add(lblSoLuongTon, 2, 1);
            tlpThongTin.Controls.Add(nudSoLuongTon, 3, 1);
            tlpThongTin.Controls.Add(lblDonVi, 0, 2);
            tlpThongTin.Controls.Add(cboDonVi, 1, 2);
            tlpThongTin.Controls.Add(lblNgayNhap, 2, 2);
            tlpThongTin.Controls.Add(dtpNgayNhap, 3, 2);
            tlpThongTin.Controls.Add(lblGiaBan, 0, 3);
            tlpThongTin.Controls.Add(nudGiaBan, 1, 3);
            tlpThongTin.Controls.Add(chkConKinhDoanh, 3, 3);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(7, 25);
            tlpThongTin.Margin = new Padding(3, 4, 3, 4);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 4;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpThongTin.Size = new Size(652, 182);
            tlpThongTin.TabIndex = 0;
            // 
            // lblTenHang
            // 
            lblTenHang.Anchor = AnchorStyles.Left;
            lblTenHang.AutoSize = true;
            lblTenHang.Location = new Point(3, 11);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(72, 20);
            lblTenHang.TabIndex = 0;
            lblTenHang.Text = "Tên hàng:";
            // 
            // txtTenHang
            // 
            tlpThongTin.SetColumnSpan(txtTenHang, 3);
            txtTenHang.Dock = DockStyle.Fill;
            txtTenHang.Location = new Point(89, 4);
            txtTenHang.Margin = new Padding(3, 4, 3, 4);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(560, 27);
            txtTenHang.TabIndex = 1;
            // 
            // lblLoaiHang
            // 
            lblLoaiHang.Anchor = AnchorStyles.Left;
            lblLoaiHang.AutoSize = true;
            lblLoaiHang.Location = new Point(3, 54);
            lblLoaiHang.Name = "lblLoaiHang";
            lblLoaiHang.Size = new Size(77, 20);
            lblLoaiHang.TabIndex = 2;
            lblLoaiHang.Text = "Loại hàng:";
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.Dock = DockStyle.Fill;
            cboLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiHang.FormattingEnabled = true;
            cboLoaiHang.Location = new Point(89, 47);
            cboLoaiHang.Margin = new Padding(3, 4, 3, 4);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(225, 28);
            cboLoaiHang.TabIndex = 3;
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.Anchor = AnchorStyles.Left;
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Location = new Point(320, 44);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(73, 40);
            lblSoLuongTon.TabIndex = 4;
            lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // nudSoLuongTon
            // 
            nudSoLuongTon.Dock = DockStyle.Fill;
            nudSoLuongTon.Location = new Point(423, 47);
            nudSoLuongTon.Margin = new Padding(3, 4, 3, 4);
            nudSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSoLuongTon.Name = "nudSoLuongTon";
            nudSoLuongTon.Size = new Size(226, 27);
            nudSoLuongTon.TabIndex = 5;
            nudSoLuongTon.ThousandsSeparator = true;
            // 
            // lblDonVi
            // 
            lblDonVi.Anchor = AnchorStyles.Left;
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(3, 97);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(55, 20);
            lblDonVi.TabIndex = 6;
            lblDonVi.Text = "Đơn vị:";
            // 
            // cboDonVi
            // 
            cboDonVi.Dock = DockStyle.Fill;
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(89, 90);
            cboDonVi.Margin = new Padding(3, 4, 3, 4);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(225, 28);
            cboDonVi.TabIndex = 7;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Anchor = AnchorStyles.Left;
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new Point(320, 97);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(84, 20);
            lblNgayNhap.TabIndex = 8;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Dock = DockStyle.Fill;
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(423, 90);
            dtpNgayNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(226, 27);
            dtpNgayNhap.TabIndex = 9;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Anchor = AnchorStyles.Left;
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(3, 145);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(63, 20);
            lblGiaBan.TabIndex = 10;
            lblGiaBan.Text = "Giá bán:";
            // 
            // nudGiaBan
            // 
            nudGiaBan.Dock = DockStyle.Fill;
            nudGiaBan.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudGiaBan.Location = new Point(89, 133);
            nudGiaBan.Margin = new Padding(3, 4, 3, 4);
            nudGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudGiaBan.Name = "nudGiaBan";
            nudGiaBan.Size = new Size(225, 27);
            nudGiaBan.TabIndex = 11;
            nudGiaBan.ThousandsSeparator = true;
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.Anchor = AnchorStyles.Left;
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(423, 143);
            chkConKinhDoanh.Margin = new Padding(3, 4, 3, 4);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(134, 24);
            chkConKinhDoanh.TabIndex = 12;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(tlpTimKiem);
            grpTimKiem.Dock = DockStyle.Fill;
            grpTimKiem.Font = new Font("Segoe UI", 9F);
            grpTimKiem.Location = new Point(675, 4);
            grpTimKiem.Margin = new Padding(3, 4, 3, 4);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Padding = new Padding(9, 5, 9, 5);
            grpTimKiem.Size = new Size(425, 212);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm";
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 1;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTimKiem.Controls.Add(txtTimKiem, 0, 0);
            tlpTimKiem.Controls.Add(cboLocLoaiHang, 0, 1);
            tlpTimKiem.Controls.Add(chkChiConKinhDoanh, 0, 2);
            tlpTimKiem.Dock = DockStyle.Fill;
            tlpTimKiem.Location = new Point(9, 25);
            tlpTimKiem.Margin = new Padding(3, 4, 3, 4);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 3;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpTimKiem.Size = new Size(407, 182);
            tlpTimKiem.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Location = new Point(3, 4);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hàng cần tìm...";
            txtTimKiem.Size = new Size(401, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // cboLocLoaiHang
            // 
            cboLocLoaiHang.Dock = DockStyle.Fill;
            cboLocLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiHang.FormattingEnabled = true;
            cboLocLoaiHang.Location = new Point(3, 51);
            cboLocLoaiHang.Margin = new Padding(3, 4, 3, 4);
            cboLocLoaiHang.Name = "cboLocLoaiHang";
            cboLocLoaiHang.Size = new Size(401, 28);
            cboLocLoaiHang.TabIndex = 1;
            // 
            // chkChiConKinhDoanh
            // 
            chkChiConKinhDoanh.Anchor = AnchorStyles.Left;
            chkChiConKinhDoanh.AutoSize = true;
            chkChiConKinhDoanh.Location = new Point(3, 126);
            chkChiConKinhDoanh.Margin = new Padding(3, 4, 3, 4);
            chkChiConKinhDoanh.Name = "chkChiConKinhDoanh";
            chkChiConKinhDoanh.Size = new Size(226, 24);
            chkChiConKinhDoanh.TabIndex = 2;
            chkChiConKinhDoanh.Text = "Chỉ hiện hàng còn kinh doanh";
            chkChiConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvHangHoa);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(11, 231);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(3, 8, 3, 8);
            pnlMain.Size = new Size(1103, 406);
            pnlMain.TabIndex = 1;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dgvHangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = Color.White;
            dgvHangHoa.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.ColumnHeadersHeight = 26;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { colMaHang, colTenHang, colLoaiHang, colDonVi, colGiaBan, colSoLuongTon, colNgayNhap, colConKinhDoanh });
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(3, 8);
            dgvHangHoa.Margin = new Padding(3, 4, 3, 4);
            dgvHangHoa.MultiSelect = false;
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.RowHeadersWidth = 24;
            dgvHangHoa.RowTemplate.Height = 24;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(1097, 390);
            dgvHangHoa.TabIndex = 0;
            // 
            // colMaHang
            // 
            colMaHang.DataPropertyName = "MaHang";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaHang.DefaultCellStyle = dataGridViewCellStyle3;
            colMaHang.FillWeight = 45F;
            colMaHang.HeaderText = "Mã";
            colMaHang.MinimumWidth = 6;
            colMaHang.Name = "colMaHang";
            colMaHang.ReadOnly = true;
            // 
            // colTenHang
            // 
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.FillWeight = 170F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            colTenHang.ReadOnly = true;
            // 
            // colLoaiHang
            // 
            colLoaiHang.DataPropertyName = "LoaiHang";
            colLoaiHang.FillWeight = 90F;
            colLoaiHang.HeaderText = "Loại hàng";
            colLoaiHang.MinimumWidth = 6;
            colLoaiHang.Name = "colLoaiHang";
            colLoaiHang.ReadOnly = true;
            // 
            // colDonVi
            // 
            colDonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDonVi.DefaultCellStyle = dataGridViewCellStyle4;
            colDonVi.FillWeight = 55F;
            colDonVi.HeaderText = "Đơn vị";
            colDonVi.MinimumWidth = 6;
            colDonVi.Name = "colDonVi";
            colDonVi.ReadOnly = true;
            // 
            // colGiaBan
            // 
            colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle5;
            colGiaBan.FillWeight = 75F;
            colGiaBan.HeaderText = "Giá bán";
            colGiaBan.MinimumWidth = 6;
            colGiaBan.Name = "colGiaBan";
            colGiaBan.ReadOnly = true;
            // 
            // colSoLuongTon
            // 
            colSoLuongTon.DataPropertyName = "SoLuongTon";
            colSoLuongTon.DefaultCellStyle = dataGridViewCellStyle5;
            colSoLuongTon.FillWeight = 55F;
            colSoLuongTon.HeaderText = "Tồn";
            colSoLuongTon.MinimumWidth = 6;
            colSoLuongTon.Name = "colSoLuongTon";
            colSoLuongTon.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            colNgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            colNgayNhap.DefaultCellStyle = dataGridViewCellStyle6;
            colNgayNhap.FillWeight = 75F;
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            // 
            // colConKinhDoanh
            // 
            colConKinhDoanh.DataPropertyName = "ConKinhDoanh";
            colConKinhDoanh.FillWeight = 65F;
            colConKinhDoanh.HeaderText = "Kinh doanh";
            colConKinhDoanh.MinimumWidth = 6;
            colConKinhDoanh.Name = "colConKinhDoanh";
            colConKinhDoanh.ReadOnly = true;
            colConKinhDoanh.Resizable = DataGridViewTriState.True;
            colConKinhDoanh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(flpButtons);
            pnlBottom.Controls.Add(lblTrangThai);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(11, 637);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1103, 88);
            pnlBottom.TabIndex = 2;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnThem);
            flpButtons.Controls.Add(btnSua);
            flpButtons.Controls.Add(btnXoa);
            flpButtons.Controls.Add(btnLamMoi);
            flpButtons.Controls.Add(btnXemBangGia);
            flpButtons.Controls.Add(btnXuatPdf);
            flpButtons.Controls.Add(btnXuatExcelLuoi);
            flpButtons.Controls.Add(btnXuatExcelTonKho);
            flpButtons.Dock = DockStyle.Top;
            flpButtons.Location = new Point(0, 0);
            flpButtons.Margin = new Padding(3, 4, 3, 4);
            flpButtons.Name = "flpButtons";
            flpButtons.Padding = new Padding(0, 4, 0, 4);
            flpButtons.Size = new Size(1103, 51);
            flpButtons.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 37);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(91, 7);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 37);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(179, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 37);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(267, 7);
            btnLamMoi.Margin = new Padding(3, 3, 14, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(89, 37);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXemBangGia
            // 
            btnXemBangGia.Location = new Point(373, 7);
            btnXemBangGia.Name = "btnXemBangGia";
            btnXemBangGia.Size = new Size(114, 37);
            btnXemBangGia.TabIndex = 4;
            btnXemBangGia.Text = "Xem bảng giá";
            btnXemBangGia.UseVisualStyleBackColor = true;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.Location = new Point(493, 7);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(91, 37);
            btnXuatPdf.TabIndex = 5;
            btnXuatPdf.Text = "Xuất PDF";
            btnXuatPdf.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcelLuoi
            // 
            btnXuatExcelLuoi.Location = new Point(590, 7);
            btnXuatExcelLuoi.Name = "btnXuatExcelLuoi";
            btnXuatExcelLuoi.Size = new Size(131, 37);
            btnXuatExcelLuoi.TabIndex = 6;
            btnXuatExcelLuoi.Text = "Xuất Excel (lưới)";
            btnXuatExcelLuoi.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcelTonKho
            // 
            btnXuatExcelTonKho.Location = new Point(727, 7);
            btnXuatExcelTonKho.Name = "btnXuatExcelTonKho";
            btnXuatExcelTonKho.Size = new Size(143, 37);
            btnXuatExcelTonKho.TabIndex = 7;
            btnXuatExcelTonKho.Text = "Xuất Excel tồn kho";
            btnXuatExcelTonKho.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.Location = new Point(3, 59);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(145, 20);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Tìm thấy 6 mặt hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 736);
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            Controls.Add(tlpTop);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1083, 651);
            Name = "Form1";
            Padding = new Padding(11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hàng hóa - Tạp hóa UTC2";
            tlpTop.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
            grpTimKiem.ResumeLayout(false);
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLocLoaiHang;
        private System.Windows.Forms.CheckBox chkChiConKinhDoanh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhap;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConKinhDoanh;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemBangGia;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Button btnXuatExcelLuoi;
        private System.Windows.Forms.Button btnXuatExcelTonKho;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
