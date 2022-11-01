using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace V_Mart
{
    public partial class PortalSelection : Form
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
        public PortalSelection()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void btn_CutomerPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal newView = new CustomerPortal();        
            newView.ShowDialog();
            this.Show();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AdminPortal_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin newView = new LoginAdmin();          
            newView.ShowDialog();
            this.Show();
        }
    }
}
