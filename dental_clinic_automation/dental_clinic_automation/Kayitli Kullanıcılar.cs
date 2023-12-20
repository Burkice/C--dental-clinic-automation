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

    public partial class Kayitli_Kullanıcılar : Form
    {
        public Kayitli_Kullanıcılar()
        {
            InitializeComponent();
        }


        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        void HastalariGetir()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from HastaEkranıTbl", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();

        }
        void HastaAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from HastaEkranıTbl where Had like '%" + textBox1.Text + "%'", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();


        }

        private void Kayitli_Kullanıcılar_Load(object sender, EventArgs e)
        {
            HastalariGetir();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevulu_Hastalar randevulu_Hastalar= new Randevulu_Hastalar();
            randevulu_Hastalar.Show();
            this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HastaAra();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura= new Fatura();
            fatura.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faturalar faturalar=new Faturalar();
            faturalar.Show();
            this.Hide();
        }
    }
}
