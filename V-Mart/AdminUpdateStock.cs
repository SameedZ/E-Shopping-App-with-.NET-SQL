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
    public partial class AdminUpdateStock : UserControl
    {
        public AdminUpdateStock()
        {
            InitializeComponent();
        }

        MiniProductDisplay getProducts()
        {
            MiniProductDisplay newView = new MiniProductDisplay();
            return newView;
        }


        private void AdminUpdateStock_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_UpdateStock_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminUpdateStock", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
            cmd.Parameters.AddWithValue("@StockQuantity", Int32.Parse(this.InputStockQuantity.Text));

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected >= 1)
            {
                MessageBox.Show("Product's  Stock has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }
    }
}
