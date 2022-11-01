using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace V_Mart
{
    public partial class Main_AdminPanel : Form
    {
        public Main_AdminPanel()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.guna2ToggleSwitch1.Checked == true)
            {
                this.bunifuShadowPanel1.PanelColor = Color.Gray;
                this.bunifuShadowPanel1.PanelColor2 = Color.DimGray;
            } else
            {
                this.bunifuShadowPanel1.PanelColor = Color.White;
                this.bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                this.bunifuCircleProgress1.Value += 5;
                if (this.bunifuCircleProgress1.Value == 100)
                {
                    this.bunifuCircleProgress1.Value = 0;
                }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void Main_AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            SqlConnection db_con = Resources.db_con;
            db_con.Open();
            string query = "Select * from Table_Customer where Email= '"+ this.Txt_Email.Text+ "'and Password ='" + this.Txt_Password.Text+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(query,db_con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Very Good Login done", "meow", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            } else
            {
                MessageBox.Show("Wrong Credentials","meow",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);


            }


            db_con.Close();
        }
    }
}
