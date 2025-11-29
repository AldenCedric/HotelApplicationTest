namespace HotelApplication
{
    partial class LoginFrm
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
            exitBtn = new HotelApplication.Components.RoundedButton();
            minimizeBtn = new HotelApplication.Components.RoundedButton();
            userTextBox = new HotelApp.UI.Components.UITextBox();
            label1 = new Label();
            label2 = new Label();
            passTxtBox = new HotelApp.UI.Components.UITextBox();
            signUpLbl = new LinkLabel();
            forgotBtn = new HotelApplication.Components.RoundedButton();
            roundedButton1 = new HotelApplication.Components.RoundedButton();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(64, 64, 64);
            exitBtn.BackgroundColor = Color.FromArgb(64, 64, 64);
            exitBtn.BorderColor = Color.FromArgb(60, 60, 60);
            exitBtn.BorderRadius = 20;
            exitBtn.BorderSize = 0;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 12F);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(533, 5);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(32, 37);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "X";
            exitBtn.TextColor = Color.White;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = Color.FromArgb(64, 64, 64);
            minimizeBtn.BackgroundColor = Color.FromArgb(64, 64, 64);
            minimizeBtn.BorderColor = Color.FromArgb(60, 60, 60);
            minimizeBtn.BorderRadius = 20;
            minimizeBtn.BorderSize = 0;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(494, 5);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(33, 37);
            minimizeBtn.TabIndex = 2;
            minimizeBtn.Text = "_";
            minimizeBtn.TextColor = Color.White;
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // userTextBox
            // 
            userTextBox.BackColor = Color.White;
            userTextBox.BackgroundImageLayout = ImageLayout.None;
            userTextBox.BorderColor = Color.FromArgb(60, 60, 60);
            userTextBox.BorderFocusColor = Color.FromArgb(100, 149, 237);
            userTextBox.BorderRadius = 5;
            userTextBox.Font = new Font("Segoe UI", 12F);
            userTextBox.ForeColor = Color.Black;
            userTextBox.Location = new Point(102, 75);
            userTextBox.Multiline = false;
            userTextBox.Name = "userTextBox";
            userTextBox.Padding = new Padding(10, 7, 10, 7);
            userTextBox.PasswordChar = false;
            userTextBox.PlaceholderText = "";
            userTextBox.Size = new Size(367, 36);
            userTextBox.TabIndex = 3;
            userTextBox.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(248, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // passTxtBox
            // 
            passTxtBox.BackColor = Color.White;
            passTxtBox.BackgroundImageLayout = ImageLayout.None;
            passTxtBox.BorderColor = Color.FromArgb(60, 60, 60);
            passTxtBox.BorderFocusColor = Color.FromArgb(100, 149, 237);
            passTxtBox.BorderRadius = 5;
            passTxtBox.Font = new Font("Segoe UI", 12F);
            passTxtBox.ForeColor = Color.Black;
            passTxtBox.Location = new Point(102, 138);
            passTxtBox.Multiline = false;
            passTxtBox.Name = "passTxtBox";
            passTxtBox.Padding = new Padding(10, 7, 10, 7);
            passTxtBox.PasswordChar = true;
            passTxtBox.PlaceholderText = "";
            passTxtBox.Size = new Size(367, 36);
            passTxtBox.TabIndex = 6;
            passTxtBox.UnderlinedStyle = false;
            // 
            // signUpLbl
            // 
            signUpLbl.AutoSize = true;
            signUpLbl.Font = new Font("Segoe UI", 11F);
            signUpLbl.Location = new Point(160, 280);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(250, 20);
            signUpLbl.TabIndex = 7;
            signUpLbl.TabStop = true;
            signUpLbl.Text = "Don't have an account? Sign up here";
            signUpLbl.LinkClicked += linkLabel1_LinkClicked;
            // 
            // forgotBtn
            // 
            forgotBtn.BackColor = Color.FromArgb(100, 149, 237);
            forgotBtn.BackgroundColor = Color.FromArgb(100, 149, 237);
            forgotBtn.BorderColor = Color.FromArgb(60, 60, 60);
            forgotBtn.BorderRadius = 17;
            forgotBtn.BorderSize = 0;
            forgotBtn.FlatAppearance.BorderSize = 0;
            forgotBtn.FlatStyle = FlatStyle.Flat;
            forgotBtn.ForeColor = Color.White;
            forgotBtn.Location = new Point(212, 255);
            forgotBtn.Name = "forgotBtn";
            forgotBtn.Size = new Size(150, 22);
            forgotBtn.TabIndex = 8;
            forgotBtn.Text = "Forgot password?";
            forgotBtn.TextColor = Color.White;
            forgotBtn.UseVisualStyleBackColor = false;
            forgotBtn.Click += forgotBtn_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(80, 80, 80);
            roundedButton1.BackgroundColor = Color.FromArgb(80, 80, 80);
            roundedButton1.BorderColor = Color.FromArgb(60, 60, 60);
            roundedButton1.BorderRadius = 20;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(212, 190);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(150, 40);
            roundedButton1.TabIndex = 9;
            roundedButton1.Text = "Login";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += forgotBtn_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            BorderSize = 0;
            ClientSize = new Size(568, 314);
            Controls.Add(roundedButton1);
            Controls.Add(forgotBtn);
            Controls.Add(signUpLbl);
            Controls.Add(passTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userTextBox);
            Controls.Add(minimizeBtn);
            Controls.Add(exitBtn);
            Name = "LoginFrm";
            Text = "HotelApp";
            Load += LoginFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.RoundedButton exitBtn;
        private Components.RoundedButton minimizeBtn;
        private HotelApp.UI.Components.UITextBox userTextBox;
        private Label label1;
        private Label label2;
        private HotelApp.UI.Components.UITextBox passTxtBox;
        private LinkLabel signUpLbl;
        private Components.RoundedButton forgotBtn;
        private Components.RoundedButton roundedButton1;
    }
}
