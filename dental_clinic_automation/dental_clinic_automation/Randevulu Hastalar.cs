using DevExpress.XtraEditors.Frames;
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

namespace dental_clinic_automation
{
    public partial class Randevulu_Hastalar : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Randevulu_Hastalar()
        {
            InitializeComponent();
        }

        void RandevuluHastalar()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from RandevuTbl", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void RHastaAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from RandevuTbl where Hasta like '%" + textBox1.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Randevulu_Hastalar_Load(object sender, EventArgs e)
        {
            RandevuluHastalar();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Kayitli_Kullanıcılar kayitli_Kullanıcılar = new Kayitli_Kullanıcılar();
            kayitli_Kullanıcılar.Show();
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            KayitliReceteler kayitliReceteler= new KayitliReceteler();
            kayitliReceteler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle= new DoktorEkle();
            doktorEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar_Listesi doktorlar_Listesi= new Doktorlar_Listesi();
            doktorlar_Listesi.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminAnaSayfa adminAnaSayfa= new AdminAnaSayfa();
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RHastaAra();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura= new Fatura();
            fatura.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faturalar faturalar= new Faturalar();
            faturalar.Show();
            this.Hide();
        }
    }
}
