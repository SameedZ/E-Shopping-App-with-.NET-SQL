using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace V_Mart
{

    public partial class SignUpCustomer : Form
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
        public SignUpCustomer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("SignUp_Customer", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email",this.Input_Email.Text);
            cmd.Parameters.AddWithValue("@Password", this.Input_Password.Text);
            cmd.Parameters.AddWithValue("@FirstName", this.Input_FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", this.Input_LastName.Text);
            cmd.Parameters.AddWithValue("@Age", Int32.Parse(this.Input_Age.Text));
            cmd.Parameters.AddWithValue("@Country", this.Input_Country.Text);
            cmd.Parameters.AddWithValue("@City", this.Input_City.Text);
            cmd.Parameters.AddWithValue("@Phone", this.Input_PhoneNum.Text);
            cmd.Parameters.AddWithValue("@Address", this.Input_Address.Text);
            int numaffected = cmd.ExecuteNonQuery();
            if (numaffected==1)
            {
                CustomMessageBox newView = new CustomMessageBox("Notification","Welcome: Your Sign up is completed");
                newView.ShowDialog();
            } else
            {
                CustomMessageBox newView = new CustomMessageBox("Notification", "ERROR");
                newView.ShowDialog();
            }
            

            db_con.Close();
            this.Close();

        }

        private void SignUpCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
