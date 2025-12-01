namespace HotelApplication.Forms.Dashboard
{
    partial class FrmMainDashboard
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
            testBtn = new HotelApplication.Components.RoundedButton();
            pnlTest = new Panel();
            SuspendLayout();
            // 
            // testBtn
            // 
            testBtn.BackColor = Color.FromArgb(100, 149, 237);
            testBtn.BackgroundColor = Color.FromArgb(100, 149, 237);
            testBtn.BorderColor = Color.FromArgb(60, 60, 60);
            testBtn.BorderRadius = 20;
            testBtn.BorderSize = 0;
            testBtn.FlatAppearance.BorderSize = 0;
            testBtn.FlatStyle = FlatStyle.Flat;
            testBtn.ForeColor = Color.White;
            testBtn.Location = new Point(314, 656);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(150, 40);
            testBtn.TabIndex = 0;
            testBtn.Text = "roundedButton1";
            testBtn.TextColor = Color.White;
            testBtn.UseVisualStyleBackColor = false;
            testBtn.Click += testBtn_Click;
            // 
            // pnlTest
            // 
            pnlTest.Location = new Point(12, 12);
            pnlTest.Name = "pnlTest";
            pnlTest.Size = new Size(776, 541);
            pnlTest.TabIndex = 1;
            // 
            // FrmMainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 708);
            Controls.Add(pnlTest);
            Controls.Add(testBtn);
            Name = "FrmMainDashboard";
            Text = "FrmMainDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Components.RoundedButton testBtn;
        private Panel pnlTest;
    }
}