using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
{
    public partial class DashboardReports : Form
    {
        public DashboardReports()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminUpdatePassword_ newView = new AdminUpdatePassword_();
            newView.Show();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

            DashboardOrderFeed newView = new DashboardOrderFeed();
            newView.ShowDialog();
            this.Close();
        }
    }
}
