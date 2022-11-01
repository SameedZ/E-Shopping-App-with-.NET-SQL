using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
{
    public partial class AdminProducts : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public AdminProducts()
        {
            InitializeComponent();
            this.lbl_UserName.Text = Resources.LoggedInAdminName;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            this.panel_subProduct.Controls.Clear();

            this.panel_subProduct.Controls.Add(new AdminAddProduct());

            this.panel_subProduct.Show();

        }

        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            this.panel_subProduct.Controls.Clear();

            this.panel_subProduct.Controls.Add(new AdminRemoveProduct());

            this.panel_subProduct.Show();
        }

        private void btn_updatestock_Click(object sender, EventArgs e)
        {
            this.panel_subProduct.Controls.Clear();

            this.panel_subProduct.Controls.Add(new AdminUpdateStock());

            this.panel_subProduct.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            AdminDashboard newView = new AdminDashboard();
            newView.ShowDialog();
            this.Close();

        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            this.panel_subProduct.Controls.Clear();

            this.panel_subProduct.Controls.Add(new AdminUpdateProduct());

            this.panel_subProduct.Show();
        }

        private void btn_ComplainCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardComplainCenter newView = new DashboardComplainCenter();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_OrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardOrderDetails newView = new DashboardOrderDetails();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_OrdersFeed_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardOrderFeed newView = new DashboardOrderFeed();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminUpdatePassword_ newView = new AdminUpdatePassword_();
            newView.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
