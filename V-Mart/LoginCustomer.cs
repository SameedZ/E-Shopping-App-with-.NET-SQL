using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace V_Mart
{
    public partial class LoginCustomer : Form
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
        public LoginCustomer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select [C_Id] from Table_Customer where Email= '" + this.Input_Email.Text + "'and Password ='" + this.Input_Password.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count == 1)
            {
                Resources.LoggedInCustomer_Id = Int32.Parse((table.Rows[0]["C_Id"].ToString()));
                string msg = "C_Id=" + Resources.LoggedInCustomer_Id.ToString();
                MessageBox.Show(msg, "Login Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                db_con.Close();
                this.Hide();
                UserHomePage newView = new UserHomePage();
                newView.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            db_con.Close();

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
