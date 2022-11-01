using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace V_Mart
{
    public partial class AdminUpdatePassword : UserControl
    {
        public AdminUpdatePassword()
        {
            InitializeComponent();
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
                MessageBox.Show("Your Password has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Incorrect Current Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Input_NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_CurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
