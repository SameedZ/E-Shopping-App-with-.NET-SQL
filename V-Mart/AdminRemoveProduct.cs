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
    public partial class AdminRemoveProduct : UserControl
    {
        public AdminRemoveProduct()
        {
            InitializeComponent();
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {

            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminRemoveProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProdutId.Text));

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Product has beend Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();

        }
    }
}
