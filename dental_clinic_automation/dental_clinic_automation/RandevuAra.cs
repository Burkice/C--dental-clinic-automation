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
    public partial class RandevuAra : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public RandevuAra()
        {
            InitializeComponent();
        }
        void DoktorAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from RandevuTbl where RDoctor like '%" + textBox1.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void TariheGoreAratma()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from RandevuTbl where RTarih like '%" + txt_tarih.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void Randevularım()
        {
            string connectionString = "Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select*from RandevuTbl", conn); // burada verileri çektik
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Hasta"].Visible = true;
            dataGridView1.Columns["Tedavi"].Visible = false;
            dataGridView1.Columns["RUygulanacakYer"].Visible = false;
            dataGridView1.Columns["Tedavi2"].Visible = false;
            dataGridView1.Columns["UygulanacakYer2"].Visible = false;
            dataGridView1.Columns["RTarih"].Visible = true;
            dataGridView1.Columns["RSaat"].Visible = true;
            dataGridView1.Columns["RAciklama"].Visible = false;
            dataGridView1.Columns["RDoctor"].Visible = true;
            dataGridView1.Columns["Rtutar"].Visible = false;
            dataGridView1.Columns["Rtutar2"].Visible = false;


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void RandevuAra_Load(object sender, EventArgs e)
        {
            Randevularım();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DoktorAra();
        }

        private void txt_tarih_ValueChanged(object sender, EventArgs e)
        {
            TariheGoreAratma();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Hasta_Ekranı hasta_Ekranı=new Hasta_Ekranı();
            hasta_Ekranı.Show();
            this .Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevu randevu=new Randevu();
            randevu.Show();
            this .Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            Receteler receteler=new Receteler();
            receteler.Show();
            this .Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tedavi tedavi=new Tedavi();
            tedavi.Show();
            this .Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu anda Bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
