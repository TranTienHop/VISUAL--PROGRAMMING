namespace Bai15
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
            lblMssv = new Label();
            lblColor = new Label();
            dudColor = new DomainUpDown();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lblMssv
            // 
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMssv.Location = new Point(25, 19);
            lblMssv.Margin = new Padding(4, 0, 4, 0);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(197, 28);
            lblMssv.TabIndex = 0;
            lblMssv.Text = "MSSV: 6551071031";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(25, 75);
            lblColor.Margin = new Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(47, 25);
            lblColor.TabIndex = 1;
            lblColor.Text = "Màu";
            // 
            // dudColor
            // 
            dudColor.Location = new Point(150, 71);
            dudColor.Margin = new Padding(4);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(200, 31);
            dudColor.TabIndex = 2;
            dudColor.Wrap = true;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(25, 138);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(68, 25);
            lblSize.TabIndex = 3;
            lblSize.Text = "Cỡ chữ";
            // 
            // nudSize
            // 
            nudSize.Location = new Point(150, 135);
            nudSize.Margin = new Padding(4);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(200, 31);
            nudSize.TabIndex = 4;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.BorderStyle = BorderStyle.FixedSingle;
            lblSampleText.Location = new Point(25, 212);
            lblSampleText.Margin = new Padding(4, 0, 4, 0);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(550, 150);
            lblSampleText.TabIndex = 5;
            lblSampleText.Text = "Trần Tiến Hợp - 6551071031";
            lblSampleText.TextAlign = ContentAlignment.MiddleCenter;
            lblSampleText.Click += lblSampleText_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(450, 400);
            btnDong.Margin = new Padding(4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(125, 44);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 475);
            Controls.Add(btnDong);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(lblSize);
            Controls.Add(dudColor);
            Controls.Add(lblColor);
            Controls.Add(lblMssv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 15 - DomainUpDown và NumericUpDown";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMssv;
        private Label lblColor;
        private DomainUpDown dudColor;
        private Label lblSize;
        private NumericUpDown nudSize;
        private Label lblSampleText;
        private Button btnDong;
    }
}
