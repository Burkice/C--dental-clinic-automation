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
using DevExpress.XtraEditors.Frames;

namespace dental_clinic_automation
{

    public partial class Tedavi : Form
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        
        public Tedavi()
        {
            InitializeComponent();
        }

        private void TedaviListele()
        {
            string connectionString = "Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter("select*from RandevuTbl", connection); // burada verileri çektik
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Hasta"].Visible = true;
            dataGridView1.Columns["Tedavi"].Visible = true;
            dataGridView1.Columns["RUygulanacakYer"].Visible = true;
            dataGridView1.Columns["RTarih"].Visible = false;
            dataGridView1.Columns["RSaat"].Visible = false;
            dataGridView1.Columns["RAciklama"].Visible = true;
            dataGridView1.Columns["RDoctor"].Visible = true;
            dataGridView1.Columns["Rtutar"].Visible = false;


        }
        void RHastaAra()
        {
            connection = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            dataAdapter = new SqlDataAdapter("select*from RandevuTbl where Hasta like '%" + textBox1.Text + "%'",connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Tedavi_Load(object sender, EventArgs e)
        {
            TedaviListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RHastaAra();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Hasta_Ekranı hasta_Ekranı=new Hasta_Ekranı();
            hasta_Ekranı.Show();
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevu randevu=new Randevu();
            randevu.Show();
            this.Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            Receteler receteler=new Receteler();
            receteler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu anda bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAra randevuAra=new RandevuAra();
            randevuAra.Show();
            this.Hide();
        }
    }
}
