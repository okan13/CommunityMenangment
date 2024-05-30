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
    public partial class Birim : Form
    {
        public Birim()
        {
            InitializeComponent();
            Birim_Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Birimtab values(@BirimNumarasi,@Birim,@BirimEkibi)", con);
            cnn.Parameters.AddWithValue("@BirimNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Birim", textBox2.Text);
            cnn.Parameters.AddWithValue("@BirimEkibi", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Birimtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Birimtab set Birim=@Birim,BirimEkibi=@BirimEkibi where BirimNumarasi=@BirimNumarasi", con);
            cnn.Parameters.AddWithValue("@BirimNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Birim", textBox2.Text);
            cnn.Parameters.AddWithValue("@BirimEkibi", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete Birimtab where BirimNumarasi=@BirimNumarasi", con);
            cnn.Parameters.AddWithValue("@BirimNumarasi", int.Parse(textBox1.Text));

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

            SqlCommand cnn = new SqlCommand("select * from Birimtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Birim_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Birimtab", con);
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
