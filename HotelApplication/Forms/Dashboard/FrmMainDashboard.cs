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

namespace HotelApplication.Forms.Dashboard
{
    public partial class FrmMainDashboard : Form
    {
        public FrmMainDashboard()
        {
            InitializeComponent();
            this.BackColor = RoundedCorners.HotelPalette.MainBackground;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Admin adminPage = new Admin();
            ShowViewInPanel(adminPage);
        }

        private void ShowViewInPanel(UserControl view)
        {
            view.Dock = DockStyle.Fill;
            pnlTest.Controls.Add(view);
        }
    }
}
