using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class AdminDashboard : Form
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
        public AdminDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.lbl_UserName.Text = Resources.LoggedInAdminName;

            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "SELECT COUNT([Complain_Id]) as CountComplains from Table_Complain";
            SqlDataAdapter adapt = new SqlDataAdapter(query, db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count == 1)
            {
                int TotalComplainsCount = Int32.Parse((table.Rows[0]["CountComplains"].ToString()));
              //  string msg = "Complains Found =" + TotalComplainsCount.ToString();
              //  MessageBox.Show(msg, "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lbl_CountComplains.Text = TotalComplainsCount.ToString();
            }

            string query2 = "SELECT COUNT(O_Id) as CountShipmentsPending from Table_Order where [DeliveredStatus]=0 and year([OrderDate])= 2020; ";
            SqlDataAdapter adapt2 = new SqlDataAdapter(query2, db_con);
            DataTable table2 = new DataTable();
            adapt2.Fill(table2);
            int TotalShipmentsPending2020 = 0;
            if (table2.Rows.Count == 1)
            {
                TotalShipmentsPending2020 = Int32.Parse((table2.Rows[0]["CountShipmentsPending"].ToString()));
                
            }

            string query2021 = "SELECT COUNT(O_Id) as CountShipmentsPending from Table_Order where [DeliveredStatus]=0 and year([OrderDate])= 2021; ";
            SqlDataAdapter adapt2021 = new SqlDataAdapter(query2021, db_con);
            DataTable table2021 = new DataTable();
            adapt2021.Fill(table2021);
            int TotalShipmentsPending2021 = 0;
            if (table2021.Rows.Count == 1)
            {
                 TotalShipmentsPending2021 = Int32.Parse((table2021.Rows[0]["CountShipmentsPending"].ToString()));
                this.lbl_CountShipmentsPending.Text = TotalShipmentsPending2021.ToString();
            }

            string query3 = "SELECT COUNT(O_Id) as CountTotalOrders from Table_Order WHERE year([OrderDate])=2020;";
            SqlDataAdapter adapt3 = new SqlDataAdapter(query3, db_con);
            DataTable table3 = new DataTable();
            adapt3.Fill(table3);
            int TotalOrders=0;
            if (table3.Rows.Count == 1)
            {
                 TotalOrders = Int32.Parse((table3.Rows[0]["CountTotalOrders"].ToString()));
               // string msg = "Total Orders = " + TotalOrders.ToString();
               // MessageBox.Show(msg, "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            string query3031 = "SELECT COUNT(O_Id) as CountTotalOrders from Table_Order WHERE year([OrderDate])=2021;";
            SqlDataAdapter adapt3031 = new SqlDataAdapter(query3031, db_con);
            DataTable table3031 = new DataTable();
            adapt3031.Fill(table3031);
            int TotalOrders2021 = 0;
            if (table3031.Rows.Count == 1)
            {
                 TotalOrders2021 = Int32.Parse((table3031.Rows[0]["CountTotalOrders"].ToString()));
                this.lbl_CountTotalOrders.Text = TotalOrders2021.ToString();
            }
            
            this.cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis { 
                Title = "Points",
                Labels= new[] { "Total Orders","ShipmentsPending","Complains Filed" }
            });


            this.cartesianChart1.Series = new LiveCharts.SeriesCollection {
               new LineSeries {
                   Values = new ChartValues<ObservablePoint> // 2020 Data
                   {
                       new ObservablePoint(0,TotalOrders),
                       new ObservablePoint(1,TotalShipmentsPending2020),
                       new ObservablePoint(2,Int32.Parse(this.lbl_CountComplains.Text))
                   },
                   PointGeometrySize=15
                   
               },
               new LineSeries { // 2021 data 
                   Values = new ChartValues<ObservablePoint>
                   {
                       new ObservablePoint(0,TotalOrders2021),
                       new ObservablePoint(1,TotalShipmentsPending2021),
                       new ObservablePoint(2,Int32.Parse(this.lbl_CountComplains.Text))
                   },
                   PointGeometrySize=15
               },


           };

            db_con.Close();

        }
        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardOrderFeed newView = new DashboardOrderFeed();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProducts newView = new AdminProducts();
            newView.ShowDialog();
            this.Close();

        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminUpdatePassword_ newView = new AdminUpdatePassword_();
            newView.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ComplainCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardComplainCenter newView = new DashboardComplainCenter();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_OrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardOrderDetails newView = new DashboardOrderDetails();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
