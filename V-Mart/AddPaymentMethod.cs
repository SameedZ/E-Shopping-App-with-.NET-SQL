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
    public partial class AddPaymentMethod : Form
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
        public AddPaymentMethod()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AddCustomerPaymentMethod", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //Resources.LoggedInCustomer_Id = 4;
            cmd.Parameters.AddWithValue("@C_Id", Resources.LoggedInCustomer_Id);
            cmd.Parameters.AddWithValue("@CardNumber", this.Input_CardNumber.Text);
            cmd.Parameters.AddWithValue("@ExpiryMonth", Int32.Parse(this.Input_Month.Text));
            cmd.Parameters.AddWithValue("@ExpiryYear", Int32.Parse(this.Input_Year.Text));
            cmd.Parameters.AddWithValue("@SecurityCode", Int32.Parse(this.Input_Pin.Text));

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Payment Method Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db_con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
