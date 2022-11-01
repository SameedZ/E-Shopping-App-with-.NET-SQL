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
    public partial class ProductDisplay : UserControl
    {
        public int productId = 0;
        public int stockQ = 0;
        Product _obj = new Product();
        public ProductDisplay()
        {
            InitializeComponent();
        }

        public ProductDisplay(Product obj)
        {
            InitializeComponent();
            this._obj.P_Id = obj.P_Id;
            this._obj.ProductName = obj.ProductName;
            this._obj.ProductCategory = obj.ProductCategory;
            this._obj.Details = obj.Details;
            this._obj.StockQuantity = obj.StockQuantity;
            this._obj.Price = obj.Price;
            this._obj.Img = obj.Img;
            



            this.productId = obj.P_Id;
            this.PB_ProductImg.ImageLocation = obj.Img;
            this.lbl_productname.Text = obj.ProductName;
            this.lbl_details.Text = obj.Details;
            this.rating_product.Value = obj.Rating;
            this.lbl_PriceValue.Text = obj.Price.ToString();
            this.lb_StockValue.Text = obj.StockQuantity.ToString();
            this.stockQ = obj.StockQuantity;
        }

        private void btn_BuyProduct_Click(object sender, EventArgs e)
        {

            InputOrderDetails newView = new InputOrderDetails(this._obj);
            newView.ShowDialog();

        }


    }
}
