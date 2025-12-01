using System.Drawing;
using HotelApplication.Components;
using HotelApp.UI.Components;

namespace HotelApplication.Forms.Dashboard
{
    partial class FrmMainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel contentPanel;
        private HotelApp.UI.Components.UITextBox txtSearch;
        private HotelApplication.Components.RoundedButton btnDashboard;
        private HotelApplication.Components.RoundedButton btnUsers;
        private HotelApplication.Components.RoundedButton btnSettings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox bellIcon;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblNewUsersTitle;
        private System.Windows.Forms.Label lblNewUsersValue;
        private HotelApplication.Components.RoundedButton btnLogout;

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
            pnlTest = new Panel();
            leftPanel = new Panel();
            btnLogout = new RoundedButton();
            btnSettings = new RoundedButton();
            btnUsers = new RoundedButton();
            btnDashboard = new RoundedButton();
            lblTitle = new Label();
            topPanel = new Panel();
            txtSearch = new UITextBox();
            bellIcon = new PictureBox();
            contentPanel = new Panel();
            cardPanel = new Panel();
            cardSales = new Panel();
            lblTotalSalesTitle = new Label();
            lblTotalSalesValue = new Label();
            cardUsers = new Panel();
            lblNewUsersTitle = new Label();
            lblNewUsersValue = new Label();
            leftPanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bellIcon).BeginInit();
            contentPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            cardSales.SuspendLayout();
            cardUsers.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTest
            // 
            pnlTest.Dock = DockStyle.Fill;
            pnlTest.Name = "pnlTest";
            pnlTest.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(32, 32, 32);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnSettings);
            leftPanel.Controls.Add(btnUsers);
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Controls.Add(lblTitle);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(12);
            leftPanel.Size = new Size(160, 650);
            leftPanel.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 64, 64);
            btnLogout.BackgroundColor = Color.FromArgb(64, 64, 64);
            btnLogout.BorderColor = Color.FromArgb(60, 60, 60);
            btnLogout.BorderRadius = 8;
            btnLogout.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 520);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 36);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.TextColor = Color.White;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);
            btnSettings.BackgroundColor = Color.FromArgb(64, 64, 64);
            btnSettings.BorderColor = Color.FromArgb(60, 60, 60);
            btnSettings.BorderRadius = 8;
            btnSettings.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(12, 140);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(120, 36);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.TextColor = Color.White;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(64, 64, 64);
            btnUsers.BackgroundColor = Color.FromArgb(64, 64, 64);
            btnUsers.BorderColor = Color.FromArgb(60, 60, 60);
            btnUsers.BorderRadius = 8;
            btnUsers.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(12, 98);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(120, 36);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.TextColor = Color.White;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(64, 64, 64);
            btnDashboard.BackgroundColor = Color.FromArgb(64, 64, 64);
            btnDashboard.BorderColor = Color.FromArgb(60, 60, 60);
            btnDashboard.BorderRadius = 8;
            btnDashboard.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 56);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(120, 36);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextColor = Color.White;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(230, 230, 230);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "TestApp";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(18, 18, 18);
            topPanel.Controls.Add(txtSearch);
            topPanel.Controls.Add(bellIcon);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(160, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(12);
            topPanel.Size = new Size(840, 64);
            topPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(32, 32, 32);
            txtSearch.BorderColor = Color.FromArgb(60, 60, 60);
            txtSearch.BorderFocusColor = Color.FromArgb(100, 149, 237);
            txtSearch.BorderRadius = 10;
            txtSearch.Location = new Point(180, 14);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(10, 7, 10, 7);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(520, 36);
            txtSearch.TabIndex = 0;
            txtSearch.UnderlinedStyle = false;
            // 
            // bellIcon
            // 
            bellIcon.BackColor = Color.Transparent;
            bellIcon.Location = new Point(930, 16);
            bellIcon.Name = "bellIcon";
            bellIcon.Size = new Size(24, 24);
            bellIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            bellIcon.TabIndex = 1;
            bellIcon.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(20, 20, 20);
            contentPanel.Controls.Add(cardPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(160, 64);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(18);
            contentPanel.Size = new Size(840, 586);
            contentPanel.TabIndex = 0;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(20, 20, 20);
            cardPanel.Controls.Add(cardSales);
            cardPanel.Controls.Add(cardUsers);
            cardPanel.Dock = DockStyle.Top;
            cardPanel.Location = new Point(18, 18);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(6);
            cardPanel.Size = new Size(804, 120);
            cardPanel.TabIndex = 1;
            // 
            // cardSales
            // 
            cardSales.BackColor = Color.FromArgb(24, 24, 24);
            cardSales.BorderStyle = BorderStyle.FixedSingle;
            cardSales.Controls.Add(lblTotalSalesTitle);
            cardSales.Controls.Add(lblTotalSalesValue);
            cardSales.Location = new Point(12, 12);
            cardSales.Name = "cardSales";
            cardSales.Size = new Size(420, 100);
            cardSales.TabIndex = 0;
            // 
            // lblTotalSalesTitle
            // 
            lblTotalSalesTitle.ForeColor = Color.FromArgb(160, 160, 160);
            lblTotalSalesTitle.Location = new Point(12, 12);
            lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            lblTotalSalesTitle.Size = new Size(100, 23);
            lblTotalSalesTitle.TabIndex = 0;
            lblTotalSalesTitle.Text = "Total Sales";
            // 
            // lblTotalSalesValue
            // 
            lblTotalSalesValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSalesValue.ForeColor = Color.FromArgb(230, 230, 230);
            lblTotalSalesValue.Location = new Point(12, 40);
            lblTotalSalesValue.Name = "lblTotalSalesValue";
            lblTotalSalesValue.Size = new Size(100, 45);
            lblTotalSalesValue.TabIndex = 1;
            lblTotalSalesValue.Text = "₱0";
            // 
            // cardUsers
            // 
            cardUsers.BackColor = Color.FromArgb(24, 24, 24);
            cardUsers.BorderStyle = BorderStyle.FixedSingle;
            cardUsers.Controls.Add(lblNewUsersTitle);
            cardUsers.Controls.Add(lblNewUsersValue);
            cardUsers.Location = new Point(452, 12);
            cardUsers.Name = "cardUsers";
            cardUsers.Size = new Size(200, 100);
            cardUsers.TabIndex = 1;
            // 
            // lblNewUsersTitle
            // 
            lblNewUsersTitle.ForeColor = Color.FromArgb(160, 160, 160);
            lblNewUsersTitle.Location = new Point(12, 12);
            lblNewUsersTitle.Name = "lblNewUsersTitle";
            lblNewUsersTitle.Size = new Size(100, 23);
            lblNewUsersTitle.TabIndex = 0;
            lblNewUsersTitle.Text = "New Users";
            // 
            // lblNewUsersValue
            // 
            lblNewUsersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNewUsersValue.ForeColor = Color.FromArgb(230, 230, 230);
            lblNewUsersValue.Location = new Point(12, 40);
            lblNewUsersValue.Name = "lblNewUsersValue";
            lblNewUsersValue.Size = new Size(100, 45);
            lblNewUsersValue.TabIndex = 1;
            lblNewUsersValue.Text = "0";
            // 
            // FrmMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            // ensure the test/content host panel is placed inside the main content area
            contentPanel.Controls.Add(pnlTest);
            Controls.Add(contentPanel);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Name = "FrmMainDashboard";
            Text = "FrmMainDashboard";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bellIcon).EndInit();
            contentPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            cardSales.ResumeLayout(false);
            cardUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTest;
    }
}