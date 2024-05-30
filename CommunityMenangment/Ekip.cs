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


namespace CommunityMenangment
{
    public partial class Ekip : Form
    {
        public Ekip()
        {
            InitializeComponent();
            Ekip_Load();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) 
            
            {
                dateTimePicker1.CustomFormat = "";
            
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Ekiptab values(@OkulNumarasi,@Ad_Soyad,@DogumTarihi,@Cinsiyet,@TelefonNumarasi,@MailAdresi)", con);
            cnn.Parameters.AddWithValue("@OkulNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Ad_Soyad", textBox2.Text);
            cnn.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            cnn.Parameters.AddWithValue("@TelefonNumarasi", textBox4.Text);
            cnn.Parameters.AddWithValue("@MailAdresi", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "KAYDET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Ekiptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Ekiptab set Ad_Soyad=@Ad_Soyad,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,TelefonNumarasi=@TelefonNumarasi,MailAdresi=@MailAdresi where OkulNumarasi=@OkulNumarasi", con);
            cnn.Parameters.AddWithValue("@OkulNumarasi", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Ad_Soyad", textBox2.Text);
            cnn.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            cnn.Parameters.AddWithValue("@TelefonNumarasi", textBox4.Text);
            cnn.Parameters.AddWithValue("@MailAdresi", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete Ekiptab where OkulNumarasi=@OkulNumarasi", con);
            cnn.Parameters.AddWithValue("@OkulNumarasi", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Kaydedildi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Ekiptab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Ekip_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ID5HPJP5\SQLEXPRESS;Initial Catalog=communitydb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Ekiptab", con);
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
