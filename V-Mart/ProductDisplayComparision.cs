using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
{
    public partial class ProductDisplayComparision : UserControl
    {
        public int productId = 0;
        public int stockQ = 0;
        public ProductDisplayComparision()
        {
            InitializeComponent();
        }

        public ProductDisplayComparision(Product obj)
        {
            InitializeComponent();
            this.productId = obj.P_Id;
            this.PB_ProductImg.ImageLocation = obj.Img;
            this.lbl_productname.Text = obj.ProductName;
            this.Input_Details.PlaceholderText = obj.Details;
            this.rating_product.Value = obj.Rating;
            this.lbl_PriceValue.Text = obj.Price.ToString();
            this.lb_StockValue.Text = obj.StockQuantity.ToString();
            this.stockQ = obj.StockQuantity;
        }

    }
}
