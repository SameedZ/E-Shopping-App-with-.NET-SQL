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
    public partial class InputOrderDetails : Form
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

        public int productId = 0;
        public int stockQ = 0;
        public InputOrderDetails()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public InputOrderDetails(Product obj)
        {
            InitializeComponent();
            
            this.productId = obj.P_Id;
            this.PB_ProductImg.ImageLocation = obj.Img;
            this.lbl_productname.Text = obj.ProductName;
            this.lbl_Details.Text = obj.Details;
            this.rating_product.Value = obj.Rating;
            this.lbl_PriceValue.Text = obj.Price.ToString();
            this.lb_StockValue.Text = obj.StockQuantity.ToString();
            this.lbl_TotalAmount.Text= obj.Price.ToString();
            this.stockQ = obj.StockQuantity;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void btn_BuyProduct_Click(object sender, EventArgs e)
        {
            SqlConnection db_con = Resources.db_con;
            DateTime DateTimeCurrent = DateTime.Now;

            db_con.Open();


            string query3 = "Select [StockQuantity] from Table_Product where [P_Id]= '" + this.productId + "'";
            SqlDataAdapter adapt3 = new SqlDataAdapter(query3, db_con);
            DataTable table3 = new DataTable();
            adapt3.Fill(table3);
            if (table3.Rows.Count == 1)
            {

                int CurrentStockQuantity = Int32.Parse((table3.Rows[0]["StockQuantity"].ToString()));
                // string msg = "Current Stock=" + CurrentStockQuantity.ToString();
                // MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.Input_Quantity.Text == "" || Int32.Parse(this.Input_Quantity.Text) <= 0)
                {
                    this.errorProvider1.SetError(this.Input_Quantity,"Incorrect Quantity");
  
                } else
                {
                    if (this.Input_Address.Text == "")
                    {
                        this.errorProvider1.SetError(this.Input_Address, "Incorrect Address");
                    } else
                    {
                        if (CurrentStockQuantity >= Int32.Parse((this.Input_Quantity.Text)))
                        {

                            SqlCommand cmd = new SqlCommand("AddOrderCustomer", db_con);
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OrderDate", DateTimeCurrent);
                            // Resources.LoggedInCustomer_Id = 4;
                            cmd.Parameters.AddWithValue("@C_Id", Resources.LoggedInCustomer_Id);
                            cmd.Parameters.AddWithValue("@TotalAmount", Int32.Parse(this.lbl_TotalAmount.Text));
                            cmd.Parameters.AddWithValue("@DeliveredStatus", false);
                            int numAffected = cmd.ExecuteNonQuery();

                            if (numAffected == 1)
                            {
                                // order placed
                                // MessageBox.Show("Order Placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string query = "Select TOP(1) [O_Id] from Table_Order ORDER BY [O_Id] DESC ";
                                SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
                                DataTable table = new DataTable();
                                adapt.Fill(table);
                                if (table.Rows.Count == 1)
                                {
                                    int OrderId = Int32.Parse((table.Rows[0]["O_Id"].ToString()));
                                    // //  string msg1 = "O_Id=" + OrderId.ToString();
                                    //   MessageBox.Show(msg1, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Invoking Add Order Details

                                    SqlCommand cmd2 = new SqlCommand("AddOrderDetails", db_con);
                                    cmd2.CommandType = System.Data.CommandType.StoredProcedure;

                                    cmd2.Parameters.AddWithValue("@P_Id", this.productId);
                                    //Resources.LoggedInCustomer_Id = 4;
                                    cmd2.Parameters.AddWithValue("@Quantity", Int32.Parse((this.Input_Quantity.Text)));
                                    cmd2.Parameters.AddWithValue("@DeliveryAddress", this.Input_Address.Text);
                                    cmd2.Parameters.AddWithValue("@O_Id", OrderId);
                                    int numAffected1 = cmd2.ExecuteNonQuery();

                                    if (numAffected1 == 1)
                                    {
                                        //MessageBox.Show("Order Details added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        SqlCommand cmd4 = new SqlCommand("AdminUpdateStock", db_con);
                                        cmd4.CommandType = System.Data.CommandType.StoredProcedure;

                                        cmd4.Parameters.AddWithValue("@P_Id", this.productId);
                                        cmd4.Parameters.AddWithValue("@StockQuantity", CurrentStockQuantity - Int32.Parse((this.Input_Quantity.Text)));

                                        int valuesAffected = cmd4.ExecuteNonQuery();
                                        if (valuesAffected >= 1)
                                        {
                                            SqlCommand cmd5 = new SqlCommand("AdminUpdateNumOrders", db_con);
                                            cmd5.CommandType = System.Data.CommandType.StoredProcedure;

                                            cmd5.Parameters.AddWithValue("@P_Id", this.productId);
                                           
                                            int valuesAffected2 = cmd5.ExecuteNonQuery();
                                            if (valuesAffected2 >= 1)
                                            {
                                                CustomMessageBox newView = new CustomMessageBox("Notification!", "Dear Customer Your Order has been recieved");
                                                newView.ShowDialog();
                                                db_con.Close();
                                                this.Close();
                                            }
                      
                                        }




                                    }
                                    else
                                    {
                                        MessageBox.Show("Error : Some Issue was Encountered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }


                                }

                            }


                        }
                    }

                    
                }


            }// if quantity exists in database.






            db_con.Close();
        }

        private void Event_QuantityChanged(object sender, EventArgs e)
        {
            int value1 = 0; int value2 = 0;
            value1 = Int32.Parse(this.Input_Quantity.Text);
            value2 = Int32.Parse(this.lbl_PriceValue.Text);
            value1 = value1 * value2;
            this.lbl_TotalAmount.Text = value1.ToString();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
