namespace Bai03
{
    partial class Form1
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
            btnHo = new Button();
            btnTen = new Button();
            txtHoTen = new Button();
            btnThoat = new Button();
            lblHoLot = new Label();
            Ten = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // btnHo
            // 
            btnHo.Location = new Point(48, 254);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(104, 49);
            btnHo.TabIndex = 0;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(224, 254);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(109, 49);
            btnTen.TabIndex = 1;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(395, 254);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(117, 49);
            txtHoTen.TabIndex = 2;
            txtHoTen.Text = "Họ và Tên";
            txtHoTen.UseVisualStyleBackColor = true;
            txtHoTen.Click += txtHoTen_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(157, 315);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(244, 60);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát Chương Trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblHoLot
            // 
            lblHoLot.AutoSize = true;
            lblHoLot.Location = new Point(76, 115);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(51, 20);
            lblHoLot.TabIndex = 4;
            lblHoLot.Text = "Họ lót";
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(76, 174);
            Ten.Name = "Ten";
            Ten.Size = new Size(32, 20);
            Ten.TabIndex = 5;
            Ten.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(177, 112);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(326, 27);
            txtHo.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(177, 171);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(326, 27);
            txtTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.Cyan;
            lblHoTen.Location = new Point(-25, -5);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(582, 87);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 387);
            Controls.Add(lblHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(Ten);
            Controls.Add(lblHoLot);
            Controls.Add(btnThoat);
            Controls.Add(txtHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHo;
        private Button btnTen;
        private Button txtHoTen;
        private Button btnThoat;
        private Label lblHoLot;
        private Label Ten;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label lblHoTen;
    }
}
