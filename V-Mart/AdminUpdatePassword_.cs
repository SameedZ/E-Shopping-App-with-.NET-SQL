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
    public partial class AdminUpdatePassword_ : Form
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

        public AdminUpdatePassword_()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("UpdateAdminPassword", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@A_Id", Resources.LoggedInAdmin_Id);
            cmd.Parameters.AddWithValue("@OldPassword", this.Input_CurrentPassword.Text);
            cmd.Parameters.AddWithValue("@NewPassword", this.Input_NewPassword.Text);

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                CustomMessageBox newView = new CustomMessageBox("Notification","Dear Admin Your password has been changed");             
                db_con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Current Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
