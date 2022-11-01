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
    public partial class CustomerCart : Form
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
        public CustomerCart()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void CustomerCart_Load(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
 

            DataTable dt = new DataTable();
          
            db_con.Open();
            BindingSource bindingSource1 = new BindingSource();
            SqlCommand myCmd = new SqlCommand("GetCustomerCard", db_con);
            //Resources.LoggedInCustomer_Id = 4;
            myCmd.Parameters.AddWithValue("@CustomerId", Resources.LoggedInCustomer_Id);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            bindingSource1.DataSource = dt;
            this.guna2DataGridView1.DataSource = bindingSource1;



            db_con.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CutomerPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage newView = new UserHomePage();
            newView.ShowDialog();

            this.Close();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBuy newView = new UserBuy();
            newView.ShowDialog();

            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCompareProduct newView = new UserCompareProduct();
            newView.ShowDialog();
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            UserComplain newView = new UserComplain();
            newView.ShowDialog();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            AddPaymentMethod newView = new AddPaymentMethod();
            newView.ShowDialog();
        }
    }
}
