using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
{
    public partial class DashboardOrderDetails : Form
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
        public DashboardOrderDetails()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void DashboardOrderDetails_Load(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;


            DataTable dt = new DataTable();
            
            db_con.Open();

            BindingSource bindingSource1 = new BindingSource();

            string query = "Select * from OrderDetailsFeed ";

            SqlDataAdapter da = new SqlDataAdapter(query, db_con);
            da.Fill(dt);
            bindingSource1.DataSource = dt;
            this.guna2DataGridView1.DataSource = bindingSource1;

            db_con.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ComplainCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardComplainCenter newView = new DashboardComplainCenter();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProducts newView = new AdminProducts();
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

        private void btn_CutomerPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard newView = new AdminDashboard();
            newView.ShowDialog();
            this.Close();
        }
    }
}
