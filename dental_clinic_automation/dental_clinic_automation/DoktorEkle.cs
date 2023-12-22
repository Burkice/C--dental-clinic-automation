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
using System.Runtime.Remoting.Messaging;

namespace dental_clinic_automation
{

    public partial class DoktorEkle : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public DoktorEkle()
        {
            InitializeComponent();
        }
        void DoktorGetir()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from Doctor", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }
        void DoktorAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from Doctor where DoktorAd like '%"+textBox1.Text+"%'", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            DoktorGetir();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            string sorgu = "INSERT INTO Doctor(DoktorAd,DoktorTel,DoktorTc,DDogumTarih,DStart,DCinsiyet,DAdres,MailAdress) VALUES (@DoktorAd,@DoktorTel,@DoktorTc,@DDogumTarih,@DStart,@DCinsiyet,@DAdres,@MailAdress)";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@DoktorAd", txt_ad.Text);
            cmd.Parameters.AddWithValue("@DoktorTel", txt_tel.Text);
            cmd.Parameters.AddWithValue("@DoktorTc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@DDogumTarih", txt_dtarih.Text);
            cmd.Parameters.AddWithValue("@DStart", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@DCinsiyet", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@DAdres", txt_adres.Text);
            cmd.Parameters.AddWithValue("@MailAdress", textBox2.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            DoktorGetir();//güncel halini görmemizi sağlar

            txt_tc.Clear();
            txt_ıd.Clear();
            txt_ad.Clear();
            txt_tel.Clear();
            txt_adres.Clear();

            MessageBox.Show("Kayıt başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
          try
            {
                string sorgu = "Update Doctor set DoktorAd=@DoktorAd, DoktorTel=@DoktorTel, DoktorTc=@DoktorTc, DDogumTarih=@DDogumTarih, DStart=@DStart, DCinsiyet=@DCinsiyet, DAdres=@DAdres,MailAdress=@MailAdress where DoktorId=@DoktorId";
                cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@DoktorId", Convert.ToInt32(txt_ıd.Text));
                cmd.Parameters.AddWithValue("@DoktorAd", txt_ad.Text);
                cmd.Parameters.AddWithValue("@DoktorTel", txt_tel.Text);
                cmd.Parameters.AddWithValue("@DoktorTc", txt_tc.Text);
                cmd.Parameters.AddWithValue("@DDogumTarih", txt_dtarih.Text); // Burada uygun bir tarih formatı bekleniyor
                cmd.Parameters.AddWithValue("@DStart", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@DCinsiyet", comboBox1.SelectedItem); 
                cmd.Parameters.AddWithValue("@DAdres", txt_adres.Text);
                cmd.Parameters.AddWithValue("@MailAdress", textBox2.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                DoktorGetir();

                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex) //Sql hatasını bulmak için kullandım
            {
                MessageBox.Show("SQL Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_dtarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_adres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Doctor WHERE DoktorId=@DoktorId";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@DoktorId", Convert.ToInt32(txt_ıd.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            DoktorGetir();

            MessageBox.Show("Silme İşlemi Gerçekleşti", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
           txt_tc.Clear();
            txt_ıd.Clear();
            txt_ad.Clear();
            txt_tel.Clear(); 
            txt_adres.Clear();
            textBox2.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Kayitli_Kullanıcılar kayitli_Kullanıcılar= new Kayitli_Kullanıcılar();
            kayitli_Kullanıcılar.Show();
            this .Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevulu_Hastalar randevulu_Hastalar = new Randevulu_Hastalar();
            randevulu_Hastalar.Show();
            this.Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
          KayitliReceteler kayitliReceteler= new KayitliReceteler();
            kayitliReceteler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar_Listesi doktorlar_Listesi= new Doktorlar_Listesi();
            doktorlar_Listesi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten Bu Sayfadasınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DoktorAra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
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
