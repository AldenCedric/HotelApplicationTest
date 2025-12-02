using HotelApp.UI.Components;
using HotelApplication.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelApplication.Components.RoundedCorners;

namespace HotelApplication.Forms.Dashboard
{
    public partial class Admin : UserControl
    {
        private DataGridView dgvUsers;
        private Label lblTitle;
        private RoundedButton btnAddUser;
        private RoundedButton btnEditUser;
        private RoundedButton btnDeleteUser;
        private UITextBox txtSearch;
        private Panel pnlHeader;

        public Admin()
        {
            InitializeComponent();
            SetupManualUI();
            LoadMockData();
        }

        private void SetupManualUI()
        {
            // Root Container Setup - Match CustomerUC.cs styling
            this.Dock = DockStyle.Fill;
            this.BackColor = HotelPalette.MainBackground;

            // 1. Header Panel - Match CustomerUC header (Height 80, Dock Top)
            pnlHeader = new Panel
            {
                Height = 80,
                Dock = DockStyle.Top,
                BackColor = HotelPalette.MainBackground,
                Padding = new Padding(20)
            };

            lblTitle = new Label
            {
                Text = "User Management",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = HotelPalette.TextPrimary,
                Location = new Point(20, 25),
                AutoSize = true
            };

            pnlHeader.Controls.Add(lblTitle);

            // 2. Filter & Action Bar Panel
            Panel pnlFilterBar = new Panel
            {
                Height = 60,
                Dock = DockStyle.Top,
                BackColor = HotelPalette.MainBackground,
                Padding = new Padding(20, 10, 20, 0)
            };

            // Search Bar - Match CustomerUC dimensions
            txtSearch = new UITextBox
            {
                PlaceholderText = "Search staff by name...",
                Size = new Size(250, 40),
                Location = new Point(20, 10),
                BorderRadius = 15,
                ForeColor = HotelPalette.TextPrimary
            };
            txtSearch._TextChanged += TxtSearch_TextChanged;

            // 3. Action Buttons - Positioned horizontally
            btnAddUser = CreateButton("Add Staff", HotelPalette.Accent, 290);
            btnEditUser = CreateButton("Edit Selected", HotelPalette.Surface, 450);
            btnDeleteUser = CreateButton("Deactivate", Color.IndianRed, 610);

            pnlFilterBar.Controls.Add(txtSearch);
            pnlFilterBar.Controls.Add(btnAddUser);
            pnlFilterBar.Controls.Add(btnEditUser);
            pnlFilterBar.Controls.Add(btnDeleteUser);

            // 4. Data Grid View Container - Match CustomerUC content area
            Panel pnlContentArea = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                BackColor = HotelPalette.MainBackground
            };

            dgvUsers = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = HotelPalette.Surface,
                BorderStyle = BorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AllowUserToAddRows = false
            };

            // Grid Styling - Match theme
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = HotelPalette.Surface;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = HotelPalette.TextPrimary;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsers.DefaultCellStyle.BackColor = HotelPalette.MainBackground;
            dgvUsers.DefaultCellStyle.ForeColor = HotelPalette.TextSecondary;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUsers.GridColor = HotelPalette.Border;
            dgvUsers.RowTemplate.Height = 35;

            pnlContentArea.Controls.Add(dgvUsers);

            // Assemble Control Hierarchy - Match CustomerUC order
            this.Controls.Add(pnlContentArea);
            this.Controls.Add(pnlFilterBar);
            this.Controls.Add(pnlHeader);
        }

        // Helper to create consistent buttons - Match CustomerUC button styling
        private RoundedButton CreateButton(string text, Color bg, int x)
        {
            RoundedButton btn = new RoundedButton
            {
                Text = text,
                BackColor = bg,
                ForeColor = Color.White,
                Size = new Size(130, 35),
                Location = new Point(x, 10),
                BorderRadius = 15,
                Font = new Font("Segoe UI", 10)
            };
            btn.Click += ActionButton_Click;
            return btn;
        }

        // --- Mock Functionality ---

        private void LoadMockData()
        {
            // Setup Columns
            dgvUsers.Columns.Add("ID", "ID");
            dgvUsers.Columns.Add("Name", "Full Name");
            dgvUsers.Columns.Add("Role", "Role");
            dgvUsers.Columns.Add("Status", "Status");

            // Auto-size columns for better scaling
            dgvUsers.Columns["ID"].Width = 80;
            dgvUsers.Columns["Name"].Width = 200;
            dgvUsers.Columns["Role"].Width = 150;
            dgvUsers.Columns["Status"].Width = 120;

            // Add Mock Rows
            dgvUsers.Rows.Add("101", "Alice Johnson", "Manager", "Active");
            dgvUsers.Rows.Add("102", "Bob Smith", "Receptionist", "Active");
            dgvUsers.Rows.Add("103", "Charlie Davis", "Housekeeping", "On Leave");
            dgvUsers.Rows.Add("104", "Diana Prince", "Receptionist", "Active");
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Simple mock filter logic
            string query = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.IsNewRow) continue;
                string name = row.Cells["Name"].Value?.ToString().ToLower() ?? "";
                row.Visible = name.Contains(query);
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            RoundedButton btn = (RoundedButton)sender;
            MessageBox.Show($"You clicked: {btn.Text}\n(This would open a form to {btn.Text})");
        }
    }
}
