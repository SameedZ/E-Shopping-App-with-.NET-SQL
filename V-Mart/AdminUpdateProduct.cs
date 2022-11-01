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
    public partial class AdminUpdateProduct : UserControl
    {
        public string imgProduct = "";
        public AdminUpdateProduct()
        {
            InitializeComponent();
        }

        private void btn_UpdateImg_Click(object sender, EventArgs e)
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

                    SqlConnection db_con = Resources.db_con;
                    db_con.Open();
                    SqlCommand cmd = new SqlCommand("AdminUpdateImgProduct", db_con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
                    cmd.Parameters.AddWithValue("@Img", this.imgProduct);

                    int valuesAffected = cmd.ExecuteNonQuery();
                    if (valuesAffected == 1)
                    {
                        MessageBox.Show("Product's Image has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    db_con.Close();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UpdateName_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminUpdateNameProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
            cmd.Parameters.AddWithValue("@ProductName", this.Input_ProductName.Text);

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Product Name has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }

        private void btn_UpdateDetail_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminUpdateDetailProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
            cmd.Parameters.AddWithValue("@Details", this.Input_Details.Text);

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Product's Details has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }

        private void btn_UpdateCategory_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminUpdateCategoryProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
            cmd.Parameters.AddWithValue("@ProductCategory", this.Input_ProductCategory.Text);

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Product's Category has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }

        private void btn_UpdatePrice_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            SqlCommand cmd = new SqlCommand("AdminUpdatePriceProduct", db_con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@P_Id", Int32.Parse(this.Input_ProductId.Text));
            cmd.Parameters.AddWithValue("@Price", Int32.Parse(this.Input_Price.Text));

            int valuesAffected = cmd.ExecuteNonQuery();
            if (valuesAffected == 1)
            {
                MessageBox.Show("Product's Price has been Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db_con.Close();
        }
    }
}
