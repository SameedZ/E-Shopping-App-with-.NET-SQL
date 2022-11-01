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
    public partial class LoginAdmin : Form
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

        public LoginAdmin()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getLoggedInUserFullName(int A_Id)
        {
            string fullname = "";
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select CONCAT(FirstName,' ',LastName) as Name FROM Table_Admin WHERE [A_Id]= '" + A_Id.ToString()+ "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count == 1)
            {
                fullname = (table.Rows[0]["Name"].ToString());
                db_con.Close();
                return fullname;
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            db_con.Close();
            return fullname;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select [A_Id] from Table_Admin where Email= '" + this.Input_Email.Text + "'and Password ='" + this.Input_Password.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();          
            adapt.Fill(table);            
            if (table.Rows.Count == 1)
            {
                Resources.LoggedInAdmin_Id = Int32.Parse((table.Rows[0]["A_Id"].ToString()));
                db_con.Close();
                Resources.LoggedInAdminName = this.getLoggedInUserFullName(Resources.LoggedInAdmin_Id);
                //string msg = "A_Id=" + Resources.LoggedInAdmin_Id.ToString();
                //MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                db_con.Open();
                db_con.Close();
                AdminDashboard newView = new AdminDashboard();
                newView.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            db_con.Close();
        }
    }
}
