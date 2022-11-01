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

namespace V_Mart
{
    public partial class UserCompareProduct : Form
    {
        public UserCompareProduct()
        {
            InitializeComponent();
        }

        private ProductDisplayComparision ListProduct(Product Obj)
        {
            ProductDisplayComparision newView = new ProductDisplayComparision(Obj);

            return newView;
        }
        private void btn_SearchName1_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select * from Table_Product where ProductName Like '" + this.Input_Search1.Text + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count >= 1)
            {
                this.FP_Product1.Controls.Clear();
                Product newObject = new Product();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    newObject.P_Id = Int32.Parse((table.Rows[i]["P_Id"].ToString()));
                    newObject.ProductName = table.Rows[i]["ProductName"].ToString();
                    newObject.ProductCategory = table.Rows[i]["ProductCategory"].ToString();
                    newObject.Details = table.Rows[i]["Details"].ToString();
                    newObject.StockQuantity = Int32.Parse((table.Rows[i]["StockQuantity"].ToString()));
                    newObject.Rating = Int32.Parse((table.Rows[i]["Rating"].ToString()));
                    newObject.Price = Int32.Parse((table.Rows[i]["Price"].ToString()));
                    newObject.Img = ((table.Rows[i]["Img"].ToString()));
                    if (newObject.StockQuantity > 0)
                    {
                        this.FP_Product1.Controls.Add(this.ListProduct(newObject));
                    }

                }


            }
            else
            {
                MessageBox.Show("Sorry nothing Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db_con.Close();
        }

        private void btn_SearchName2_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select * from Table_Product where ProductName Like '" + this.Input_Search2.Text + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count >= 1)
            {
                this.FP_Product2.Controls.Clear();
                Product newObject = new Product();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    newObject.P_Id = Int32.Parse((table.Rows[i]["P_Id"].ToString()));
                    newObject.ProductName = table.Rows[i]["ProductName"].ToString();
                    newObject.ProductCategory = table.Rows[i]["ProductCategory"].ToString();
                    newObject.Details = table.Rows[i]["Details"].ToString();
                    newObject.StockQuantity = Int32.Parse((table.Rows[i]["StockQuantity"].ToString()));
                    newObject.Rating = Int32.Parse((table.Rows[i]["Rating"].ToString()));
                    newObject.Price = Int32.Parse((table.Rows[i]["Price"].ToString()));
                    newObject.Img = ((table.Rows[i]["Img"].ToString()));
                    if (newObject.StockQuantity > 0)
                    {
                        this.FP_Product2.Controls.Add(this.ListProduct(newObject));
                    }

                }


            }
            else
            {
                MessageBox.Show("Sorry nothing Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db_con.Close();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBuy newView = new UserBuy();
            newView.ShowDialog();
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            UserComplain newView = new UserComplain();
            newView.ShowDialog();
        }

        private void btn_CutomerPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage newView = new UserHomePage();
            newView.ShowDialog();
            this.Show();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            AddPaymentMethod newView = new AddPaymentMethod();
            newView.ShowDialog();
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCart newView = new CustomerCart();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
