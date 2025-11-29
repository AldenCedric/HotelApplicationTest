namespace HotelApplication.Forms.Auth
{
    partial class ProgressBar
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
            uiProgressBar1 = new HotelApp.UI.Components.UIProgressBar();
            statusLbl = new Label();
            SuspendLayout();
            // 
            // uiProgressBar1
            // 
            uiProgressBar1.BackColor = Color.FromArgb(20, 20, 20);
            uiProgressBar1.ChannelColor = Color.FromArgb(32, 32, 32);
            uiProgressBar1.ForeColor = Color.FromArgb(230, 230, 230);
            uiProgressBar1.Location = new Point(64, 81);
            uiProgressBar1.Maximum = 100;
            uiProgressBar1.Name = "uiProgressBar1";
            uiProgressBar1.ShowValue = false;
            uiProgressBar1.Size = new Size(436, 38);
            uiProgressBar1.SliderColor = Color.FromArgb(100, 149, 237);
            uiProgressBar1.TabIndex = 0;
            uiProgressBar1.Text = "uiProgressBar1";
            uiProgressBar1.Value = 0;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Segoe UI", 16F);
            statusLbl.ForeColor = Color.White;
            statusLbl.Location = new Point(252, 133);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(70, 30);
            statusLbl.TabIndex = 1;
            statusLbl.Text = "Status";
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(586, 195);
            Controls.Add(statusLbl);
            Controls.Add(uiProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressBar";
            Text = "ProgressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HotelApp.UI.Components.UIProgressBar uiProgressBar1;
        private Label statusLbl;
    }
}