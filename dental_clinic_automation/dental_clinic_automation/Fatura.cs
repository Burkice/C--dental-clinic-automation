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
    public partial class Fatura : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Fatura()
        {
            InitializeComponent();
        }
        private void RandevuTutarGetir()
        {
          
        }
        
        void ReceteAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from ReceteTbl where HasAd like '%" + textBox3.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
            private void ReceteTutarGetir()
        {
            string connectionString = "Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select*from ReceteTbl", conn); // burada verileri çektik
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            dataGridView2.Columns["HasAd"].Visible = true;
            dataGridView2.Columns["TedaviAd"].Visible = false;
            dataGridView2.Columns["TedaviUcret"].Visible = false;
            dataGridView2.Columns["Tedavi2Ad"].Visible = false;
            dataGridView2.Columns["TedaviUcret2"].Visible = true;
            dataGridView2.Columns["Ilac"].Visible = false;
            dataGridView2.Columns["IlacMiktar"].Visible = false;
            dataGridView2.Columns["Tutar"].Visible = true;
           
        }
    
        private void Fatura_Load(object sender, EventArgs e)
        {
            RandevuTutarGetir();
            ReceteTutarGetir();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_HasAd.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_tedavi.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_tedavi2.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_tutar.Text= dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ReceteAra();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin1 = string.IsNullOrEmpty(txt_tedavi.Text) ? "0" : txt_tedavi.Text;
            string metin2 = string.IsNullOrEmpty(txt_tedavi2.Text) ? "0" : txt_tedavi2.Text;
            string metin3 = string.IsNullOrEmpty(txt_tutar.Text) ? "0" : txt_tutar.Text;

            if (int.TryParse(metin1, out int sayi1) && int.TryParse(metin2, out int sayi2) && int.TryParse(metin3, out int sayi3))
            {
                int toplam = sayi1 + sayi2 + sayi3;

                // Sonucu kullanıcıya göster
                txt_toplam.Text = toplam.ToString();
            }
            else
            {
                // Geçersiz giriş durumunda hata mesajı göster
                MessageBox.Show("Lütfen geçerli sayılar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
                {
                    string sorgu = "INSERT INTO FaturaTbl(Hasta,FaturaKesimTarih,Tedavi1,Tedavi2,IlacUcret,ToplamUcret) VALUES (@Hasta,@FaturaKesimTarih,@Tedavi1,@Tedavi2,@IlacUcret,@ToplamUcret)";
                    using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@Hasta",txt_HasAd.Text);
                        cmd.Parameters.AddWithValue("@FaturaKesimTarih", txt_tarih.Text);
                        cmd.Parameters.AddWithValue("@Tedavi1", txt_tedavi.Text);
                        cmd.Parameters.AddWithValue("@Tedavi2", txt_tedavi2.Text);
                        cmd.Parameters.AddWithValue("@IlacUcret ", txt_tutar.Text);
                        cmd.Parameters.AddWithValue("@ToplamUcret", txt_toplam.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Faturanız Yazdırılıyor ve Kayıtlara Eklendi", "Bilgilendirme", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
          KayitliReceteler kayitliReceteler=new KayitliReceteler();
            kayitliReceteler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle=new DoktorEkle();
            doktorEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar_Listesi doktorlar_Listesi=new Doktorlar_Listesi();
            doktorlar_Listesi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Şu Anda Bu Sayfadasınız","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Faturalar faturalar=new Faturalar();
            faturalar.Show();
            this.Hide();
        }
    }
}
