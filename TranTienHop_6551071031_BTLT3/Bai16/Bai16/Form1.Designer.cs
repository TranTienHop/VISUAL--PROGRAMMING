namespace Bai16
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuCut = new ToolStripMenuItem();
            mnuCopy = new ToolStripMenuItem();
            mnuPaste = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            lblMssv = new Label();
            txtNoiDung = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ctxCut = new ToolStripMenuItem();
            ctxCopy = new ToolStripMenuItem();
            ctxPaste = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ctxSelectAll = new ToolStripMenuItem();
            ctxClear = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(600, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new Size(128, 26);
            mnuNew.Text = "New";
            mnuNew.Click += mnuNew_Click;
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(128, 26);
            mnuOpen.Text = "Open";
            mnuOpen.Click += mnuOpen_Click;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(128, 26);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuCut, mnuCopy, mnuPaste });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(49, 24);
            mnuEdit.Text = "Edit";
            mnuCut.Name = "mnuCut";
            mnuCut.Size = new Size(128, 26);
            mnuCut.Text = "Cut";
            mnuCut.Click += mnuCut_Click;
            mnuCopy.Name = "mnuCopy";
            mnuCopy.Size = new Size(128, 26);
            mnuCopy.Text = "Copy";
            mnuCopy.Click += mnuCopy_Click;
            mnuPaste.Name = "mnuPaste";
            mnuPaste.Size = new Size(128, 26);
            mnuPaste.Text = "Paste";
            mnuPaste.Click += mnuPaste_Click;
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(133, 26);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMssv.Location = new Point(20, 45);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(130, 23);
            lblMssv.TabIndex = 1;
            lblMssv.Text = "MSSV: 6551071031";
            txtNoiDung.ContextMenuStrip = contextMenuStrip1;
            txtNoiDung.Location = new Point(20, 80);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(550, 280);
            txtNoiDung.TabIndex = 2;
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ctxCut, ctxCopy, ctxPaste, toolStripSeparator2, ctxSelectAll, ctxClear });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 130);
            ctxCut.Name = "ctxCut";
            ctxCut.Size = new Size(154, 24);
            ctxCut.Text = "Cut";
            ctxCut.Click += mnuCut_Click;
            ctxCopy.Name = "ctxCopy";
            ctxCopy.Size = new Size(154, 24);
            ctxCopy.Text = "Copy";
            ctxCopy.Click += mnuCopy_Click;
            ctxPaste.Name = "ctxPaste";
            ctxPaste.Size = new Size(154, 24);
            ctxPaste.Text = "Paste";
            ctxPaste.Click += mnuPaste_Click;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(151, 6);
            ctxSelectAll.Name = "ctxSelectAll";
            ctxSelectAll.Size = new Size(154, 24);
            ctxSelectAll.Text = "Select All";
            ctxSelectAll.Click += ctxSelectAll_Click;
            ctxClear.Name = "ctxClear";
            ctxClear.Size = new Size(154, 24);
            ctxClear.Text = "Clear";
            ctxClear.Click += ctxClear_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 390);
            Controls.Add(txtNoiDung);
            Controls.Add(lblMssv);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 16 - Main Menu và Context Menu";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuCut;
        private ToolStripMenuItem mnuCopy;
        private ToolStripMenuItem mnuPaste;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private Label lblMssv;
        private TextBox txtNoiDung;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ctxCut;
        private ToolStripMenuItem ctxCopy;
        private ToolStripMenuItem ctxPaste;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ctxSelectAll;
        private ToolStripMenuItem ctxClear;
    }
}
