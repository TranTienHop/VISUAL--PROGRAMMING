namespace BT6
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mnuMoGhiChuMoi = new ToolStripMenuItem();
            mnuSapXepCuaSo = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuXepNgang = new ToolStripMenuItem();
            mnuXepDoc = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            lblSoGhiChu = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuMoGhiChuMoi, mnuSapXepCuaSo, mnuThoat });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mnuMoGhiChuMoi
            // 
            mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            mnuMoGhiChuMoi.Size = new Size(224, 26);
            mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
            mnuMoGhiChuMoi.Click += mnuMoGhiChuMoi_Click;
            // 
            // mnuSapXepCuaSo
            // 
            mnuSapXepCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc });
            mnuSapXepCuaSo.Name = "mnuSapXepCuaSo";
            mnuSapXepCuaSo.Size = new Size(224, 26);
            mnuSapXepCuaSo.Text = "Sắp xếp cửa sổ";
            // 
            // mnuXepTang
            // 
            mnuXepTang.Name = "mnuXepTang";
            mnuXepTang.Size = new Size(224, 26);
            mnuXepTang.Text = "Xếp tầng";
            mnuXepTang.Click += mnuXepTang_Click;
            // 
            // mnuXepNgang
            // 
            mnuXepNgang.Name = "mnuXepNgang";
            mnuXepNgang.Size = new Size(224, 26);
            mnuXepNgang.Text = "Xếp ngang";
            // 
            // mnuXepDoc
            // 
            mnuXepDoc.Name = "mnuXepDoc";
            mnuXepDoc.Size = new Size(224, 26);
            mnuXepDoc.Text = "Xếp dọc";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.ImageScalingSize = new Size(20, 20);
            lblSoGhiChu.Location = new Point(0, 428);
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(800, 22);
            lblSoGhiChu.TabIndex = 4;
            lblSoGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSoGhiChu);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "FormChinh";
            Text = "Ứng dụng Quản lý Ghi chú Công việc (Note Manager)";
            WindowState = FormWindowState.Maximized;
            Load += FormChinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mnuMoGhiChuMoi;
        private ToolStripMenuItem mnuSapXepCuaSo;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuXepTang;
        private ToolStripMenuItem mnuXepNgang;
        private ToolStripMenuItem mnuXepDoc;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private StatusStrip lblSoGhiChu;
    }
}
