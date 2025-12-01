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
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Admin adminPage = new Admin();
            ShowView(adminPage);
        }

        private void ShowView(UserControl view)
        {
            view.Dock = DockStyle.Fill;
            pnlTest.Controls.Add(view);
        }
    }
}
