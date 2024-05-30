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
    public partial class Yetkili : Form
    {
        public Yetkili()
        {
            InitializeComponent();
            Yetkili_Load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Yetkitab values(@YetkiliNumarasi,@Yetkili,@YetkiAlani)", con);
            cnn.Parameters.AddWithValue("@YetkiliNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Yetkili", textBox2.Text);
            cnn.Parameters.AddWithValue("@YetkiAlani", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Yetkitab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Yetkitab set Yetkili=@Yetkili,YetkiAlani=@YetkiAlani where YetkiliNumarasi=@YetkiliNumarasi", con);
            cnn.Parameters.AddWithValue("@YetkiliNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Yetkili", textBox2.Text);
            cnn.Parameters.AddWithValue("@YetkiAlani", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete Yetkitab where YetkiliNumarasi=@YetkiliNumarasi", con);
            cnn.Parameters.AddWithValue("@YetkiliNumarasi", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Yetkitab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Yetkili_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Yetkitab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
