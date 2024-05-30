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

namespace CommunityMenangment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object  sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekip st = new Ekip();
            st.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Gorev sj = new Gorev();
            sj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yetkili sj = new Yetkili();
            sj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Birim sj = new Birim();
            sj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel dd = new Panel();
            dd.Show();  
        }
    }
}
