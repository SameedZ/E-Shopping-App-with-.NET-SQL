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
    public partial class UserBuy : Form
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
        public UserBuy()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private ProductDisplay ListProduct(Product Obj)
        {
            ProductDisplay newView = new ProductDisplay(Obj);

            return newView;
        }


        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select * from Table_Product where ProductName Like '" + this.Input_SearchByName.Text + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count >= 1)
            {
                this.FP_ProductDisplay.Controls.Clear();
                Product newObject=new Product();

                for(int i=0; i < table.Rows.Count; i++)
                {
                    newObject.P_Id = Int32.Parse((table.Rows[i]["P_Id"].ToString()));
                    newObject.ProductName = table.Rows[i]["ProductName"].ToString();
                    newObject.ProductCategory = table.Rows[i]["ProductCategory"].ToString();
                    newObject.Details = table.Rows[i]["Details"].ToString();
                    newObject.StockQuantity = Int32.Parse((table.Rows[i]["StockQuantity"].ToString()));
                    newObject.Rating = Int32.Parse((table.Rows[i]["Rating"].ToString()));
                    newObject.Price = Int32.Parse((table.Rows[i]["Price"].ToString()));
                    newObject.Img =((table.Rows[i]["Img"].ToString()));
                    if (newObject.StockQuantity > 0)
                    {
                        this.FP_ProductDisplay.Controls.Add(this.ListProduct(newObject));
                    }

                }


            }
            else
            {
                MessageBox.Show("Sorry nothing Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db_con.Close();
        }

        private void btn_SearchCategory_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select * from Table_Product where ProductCategory Like '" + this.Input_SearchByCategory.Text + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count >= 1)
            {
               this.FP_ProductDisplay.Controls.Clear();
                this.FP_ProductDisplay.Hide();
               Product newObject=new Product();
               
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    newObject.P_Id = Int32.Parse((table.Rows[i]["P_Id"].ToString() ));
                    newObject.ProductName = table.Rows[i]["ProductName"].ToString();
                    newObject.ProductCategory = table.Rows[i]["ProductCategory"].ToString();
                    newObject.Details = table.Rows[i]["Details"].ToString();
                    newObject.StockQuantity = Int32.Parse((table.Rows[i]["StockQuantity"].ToString()));
                    newObject.Rating = Int32.Parse((table.Rows[i]["Rating"].ToString()));
                    newObject.Price = Int32.Parse((table.Rows[i]["Price"].ToString()));
                    newObject.Img = ((table.Rows[i]["Img"].ToString()));

                    this.FP_ProductDisplay.Controls.Add(this.ListProduct(newObject));


                }
                this.FP_ProductDisplay.Show();

            }
            else
            {
                MessageBox.Show("Nothing Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db_con.Close();
        }

        private void btn_CutomerPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHomePage newView = new UserHomePage();
            newView.ShowDialog();
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCompareProduct newView = new UserCompareProduct();
            newView.ShowDialog();
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            UserComplain newView = new UserComplain();
            newView.ShowDialog();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            AddPaymentMethod newView = new AddPaymentMethod();
            newView.ShowDialog();
        }

        private void btn_CustomerCart_Click(object sender, EventArgs e)
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
