namespace BTCh4_Bai4
{
    partial class frmLichHen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnDatLich = new Button();
            lstLichHen = new ListBox();
            dtpNgayHen = new DateTimePicker();
            txtTenBenhNhan = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 49);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày giờ hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên bệnh nhân:";
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(176, 191);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(137, 44);
            btnDatLich.TabIndex = 2;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(46, 309);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(458, 84);
            lstLichHen.TabIndex = 3;
            // 
            // dtpNgayHen
            // 
            dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayHen.Format = DateTimePickerFormat.Custom;
            dtpNgayHen.Location = new Point(176, 42);
            dtpNgayHen.Name = "dtpNgayHen";
            dtpNgayHen.Size = new Size(244, 27);
            dtpNgayHen.TabIndex = 4;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(176, 106);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(303, 27);
            txtTenBenhNhan.TabIndex = 5;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(dtpNgayHen);
            Controls.Add(lstLichHen);
            Controls.Add(btnDatLich);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLichHen";
            Text = "frmLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDatLich;
        private ListBox lstLichHen;
        private DateTimePicker dtpNgayHen;
        private TextBox txtTenBenhNhan;
    }
}