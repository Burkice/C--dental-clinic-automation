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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dental_clinic_automation
{
    public partial class KayitliReceteler : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public KayitliReceteler()
        {
            InitializeComponent();
        }
        void Recete()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from ReceteTbl", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void ReceteAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from ReceteTbl where HasAd like '%" + textBox3.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Kayitli_Kullanıcılar kayitli_Kullanıcılar = new Kayitli_Kullanıcılar();
            kayitli_Kullanıcılar.Show();
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevulu_Hastalar randevulu_Hastalar=new Randevulu_Hastalar();
            randevulu_Hastalar.Show();
            this.Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar_Listesi doktorlar_Listesi = new Doktorlar_Listesi();
            doktorlar_Listesi.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayitliReceteler_Load(object sender, EventArgs e)
        {
            Recete();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Recete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faturalar faturalar= new Faturalar();
            faturalar.Show();
            this.Hide();
        }
    }
}
