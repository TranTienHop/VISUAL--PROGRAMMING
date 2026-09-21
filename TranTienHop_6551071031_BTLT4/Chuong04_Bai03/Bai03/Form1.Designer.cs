namespace ToDoListDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtCongViecMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.ContextMenuStrip cmsCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuHoanThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaMotCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaTatCa;

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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtCongViecMoi = new System.Windows.Forms.TextBox();
            this.lstCongViec = new System.Windows.Forms.ListBox();
            this.cmsCongViec = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaMotCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.cmsCongViec.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Controls.Add(this.btnThem);
            this.pnlTop.Controls.Add(this.txtCongViecMoi);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(500, 50);
            this.pnlTop.TabIndex = 0;

            // txtCongViecMoi
            this.txtCongViecMoi.Location = new System.Drawing.Point(10, 14);
            this.txtCongViecMoi.Name = "txtCongViecMoi";
            this.txtCongViecMoi.Size = new System.Drawing.Size(370, 23);
            this.txtCongViecMoi.TabIndex = 0;

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(390, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 25);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // lstCongViec
            this.lstCongViec.ContextMenuStrip = this.cmsCongViec;
            this.lstCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCongViec.ItemHeight = 15;
            this.lstCongViec.Location = new System.Drawing.Point(0, 50);
            this.lstCongViec.Name = "lstCongViec";
            this.lstCongViec.Size = new System.Drawing.Size(500, 300);
            this.lstCongViec.TabIndex = 1;

            // cmsCongViec
            this.cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuHoanThanh,
                this.mnuXoaMotCongViec,
                this.mnuXoaTatCa});
            this.cmsCongViec.Name = "cmsCongViec";
            this.cmsCongViec.Size = new System.Drawing.Size(220, 70);

            // mnuHoanThanh
            this.mnuHoanThanh.Name = "mnuHoanThanh";
            this.mnuHoanThanh.Text = "Đánh dấu hoàn thành";
            this.mnuHoanThanh.Click += new System.EventHandler(this.mnuHoanThanh_Click);

            // mnuXoaMotCongViec
            this.mnuXoaMotCongViec.Name = "mnuXoaMotCongViec";
            this.mnuXoaMotCongViec.Text = "Xóa công việc này";
            this.mnuXoaMotCongViec.Click += new System.EventHandler(this.mnuXoaMotCongViec_Click);

            // mnuXoaTatCa
            this.mnuXoaTatCa.Name = "mnuXoaTatCa";
            this.mnuXoaTatCa.Text = "Xóa tất cả";
            this.mnuXoaTatCa.Click += new System.EventHandler(this.mnuXoaTatCa_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lstCongViec);
            this.Controls.Add(this.pnlTop);
            this.Name = "Form1";
            this.Text = "Danh sách việc cần làm hằng ngày";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.cmsCongViec.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
