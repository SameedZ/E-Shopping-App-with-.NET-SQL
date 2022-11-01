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
    public partial class AdminAddProduct : UserControl
    {
        public string imgProduct = "";
        public AdminAddProduct()
        {
            InitializeComponent();
        }

        private void btn_ImgUpload_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All Files(*.*)|*.*|";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imgLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imgLocation;
                    this.imgProduct = pictureBox1.ImageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminAddProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductName", this.Input_ProductName.Text);
            cmd.Parameters.AddWithValue("@ProductCategory", this.Input_ProductCategory.Text);
            cmd.Parameters.AddWithValue("@Details", this.Input_Details.Text);
            cmd.Parameters.AddWithValue("@StockQuantity", Int32.Parse(this.Input_Stock.Text));
            cmd.Parameters.AddWithValue("@Rating", 0);
            cmd.Parameters.AddWithValue("@Price", Int32.Parse(this.Input_Price.Text));
            cmd.Parameters.AddWithValue("@Img", this.imgProduct);

            int valuesAffected = cmd.ExecuteNonQuery();
            if(valuesAffected == 1)
            {
                MessageBox.Show("Product has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }
    }
}
