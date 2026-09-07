namespace Bai2
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
            btnClickMe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.BackColor = SystemColors.ControlLightLight;
            btnClickMe.FlatAppearance.BorderColor = Color.Cyan;
            btnClickMe.FlatAppearance.BorderSize = 3;
            btnClickMe.FlatStyle = FlatStyle.Flat;
            btnClickMe.Font = new Font("Segoe UI", 30F);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(227, 97);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(312, 165);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = false;
            btnClickMe.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(298, 276);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 1;
            label1.Text = "6551071031";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickMe;
        private Label label1;
    }
}
