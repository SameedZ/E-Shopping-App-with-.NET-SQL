using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace V_Mart
{
    public static class Resources
    {
        public static SqlConnection db_con = new SqlConnection(@"Data Source=DESKTOP-A6M4VHH;Initial Catalog=VMart_DB;Integrated Security=True");

        public static int LoggedInAdmin_Id = 0;
        public static int LoggedInCustomer_Id = 0;

        public static string LoggedInAdminName = "";

    }

    public class Product
    {
        public int P_Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string Details { get; set; }
        public int StockQuantity { get; set; }
        public int Rating { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }

    }



}
