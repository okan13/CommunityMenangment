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
using System.Data.SqlClient;


namespace CommunityMenangment
{
    public partial class Panel : Form
    {
        private object lblCount;

        public Panel()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
            display3();

        }
        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Ekiptab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount1.Text = "0";
            }

            con.Close();

        }

        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Gorevtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount2.Text = "0";
            }

            con.Close();

        }

        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Yetkitab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount3.Text = "0";
            }

            con.Close();

        }

        private void display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Birimtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount4.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount4.Text = "0";
            }

            con.Close();

        }

    }
}

