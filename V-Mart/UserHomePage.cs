using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
{
    public partial class UserHomePage : Form
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
        public UserHomePage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btn_Complains_Click(object sender, EventArgs e)
        {
            UserComplain newView = new UserComplain();
            newView.ShowDialog();
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            AddPaymentMethod newView = new AddPaymentMethod();
            newView.ShowDialog();
        }

        private void btn_Compare_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCompareProduct newView = new UserCompareProduct();
            newView.ShowDialog();
            this.Close();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBuy newView = new UserBuy();
            newView.ShowDialog();
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBuy newView = new UserBuy();
            newView.ShowDialog();
            this.Close();
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
