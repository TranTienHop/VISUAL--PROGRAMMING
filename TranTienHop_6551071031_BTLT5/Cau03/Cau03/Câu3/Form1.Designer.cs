namespace Câu3
{
    partial class FormNhapDiem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblAnh;

        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtAnh;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();

            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();

            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();

            this.lstDanhSach = new System.Windows.Forms.ListBox();

            this.errorProvider1 =
                new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1))
                .BeginInit();

            this.SuspendLayout();

            // =====================================================
            // LABEL MÃ HS
            // =====================================================

            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaHS.Location =
                new System.Drawing.Point(12, 18);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size =
                new System.Drawing.Size(42, 15);
            this.lblMaHS.Text = "Mã HS";

            // =====================================================
            // LABEL HỌ TÊN
            // =====================================================

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location =
                new System.Drawing.Point(123, 18);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size =
                new System.Drawing.Size(44, 15);
            this.lblHoTen.Text = "Họ tên";

            // =====================================================
            // LABEL ĐIỂM TOÁN
            // =====================================================

            this.lblToan.AutoSize = true;
            this.lblToan.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblToan.Location =
                new System.Drawing.Point(224, 18);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size =
                new System.Drawing.Size(62, 15);
            this.lblToan.Text = "Điểm Toán";

            // =====================================================
            // LABEL ĐIỂM VĂN
            // =====================================================

            this.lblVan.AutoSize = true;
            this.lblVan.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblVan.Location =
                new System.Drawing.Point(325, 18);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size =
                new System.Drawing.Size(57, 15);
            this.lblVan.Text = "Điểm Văn";

            // =====================================================
            // LABEL ĐIỂM ANH
            // =====================================================

            this.lblAnh.AutoSize = true;
            this.lblAnh.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnh.Location =
                new System.Drawing.Point(425, 18);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size =
                new System.Drawing.Size(59, 15);
            this.lblAnh.Text = "Điểm Anh";

            // =====================================================
            // TEXTBOX MÃ HS
            // =====================================================

            this.txtMaHS.Location =
                new System.Drawing.Point(12, 42);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size =
                new System.Drawing.Size(90, 23);
            this.txtMaHS.TabIndex = 0;

            // =====================================================
            // TEXTBOX HỌ TÊN
            // =====================================================

            this.txtHoTen.Location =
                new System.Drawing.Point(123, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size =
                new System.Drawing.Size(90, 23);
            this.txtHoTen.TabIndex = 1;

            // =====================================================
            // TEXTBOX ĐIỂM TOÁN
            // =====================================================

            this.txtToan.Location =
                new System.Drawing.Point(224, 42);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size =
                new System.Drawing.Size(85, 23);
            this.txtToan.TabIndex = 2;

            // =====================================================
            // TEXTBOX ĐIỂM VĂN
            // =====================================================

            this.txtVan.Location =
                new System.Drawing.Point(325, 42);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size =
                new System.Drawing.Size(85, 23);
            this.txtVan.TabIndex = 3;

            // =====================================================
            // TEXTBOX ĐIỂM ANH
            // =====================================================

            this.txtAnh.Location =
                new System.Drawing.Point(425, 42);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size =
                new System.Drawing.Size(85, 23);
            this.txtAnh.TabIndex = 4;

            // =====================================================
            // BUTTON LƯU
            // =====================================================

            this.btnLuu.BackColor =
                System.Drawing.Color.FromArgb(92, 173, 94);

            this.btnLuu.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLuu.FlatAppearance.BorderSize = 0;

            this.btnLuu.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.btnLuu.ForeColor =
                System.Drawing.Color.Black;

            this.btnLuu.Location =
                new System.Drawing.Point(12, 72);

            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size =
                new System.Drawing.Size(82, 28);

            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;

            // =====================================================
            // BUTTON XÓA TRẮNG
            // =====================================================

            this.btnXoaTrang.BackColor =
                System.Drawing.Color.FromArgb(210, 210, 210);

            this.btnXoaTrang.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnXoaTrang.FlatAppearance.BorderSize = 0;

            this.btnXoaTrang.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.btnXoaTrang.ForeColor =
                System.Drawing.Color.Black;

            this.btnXoaTrang.Location =
                new System.Drawing.Point(100, 72);

            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size =
                new System.Drawing.Size(94, 28);

            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa Trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = false;

            // =====================================================
            // LISTBOX
            // =====================================================

            this.lstDanhSach.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.HorizontalScrollbar = true;
            this.lstDanhSach.ItemHeight = 16;

            this.lstDanhSach.Location =
                new System.Drawing.Point(12, 106);

            this.lstDanhSach.Name = "lstDanhSach";

            this.lstDanhSach.Size =
                new System.Drawing.Size(498, 164);

            this.lstDanhSach.TabIndex = 7;

            // =====================================================
            // ERROR PROVIDER
            // =====================================================

            this.errorProvider1.ContainerControl = this;

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(522, 290);

            this.Controls.Add(this.lstDanhSach);

            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnLuu);

            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaHS);

            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaHS);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = true;

            this.Name = "FormNhapDiem";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Nhập điểm học sinh";

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1))
                .EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}