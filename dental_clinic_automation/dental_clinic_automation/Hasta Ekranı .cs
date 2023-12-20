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


namespace dental_clinic_automation
{
    public partial class Hasta_Ekranı : Form
    {   

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Hasta_Ekranı()
        {
            InitializeComponent();
        }

        void HastaGetir()
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
            adapter = new SqlDataAdapter("select*from HastaEkranıTbl where Had like '%"+txt_ara.Text+"%'", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();


        }
        private void Hasta_Ekranı_Load(object sender, EventArgs e)
        {
            HastaGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //burada textboxlara veri çekeriz
            txt_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_hastadurum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_dtarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dt_GelisTarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_alerji.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_adres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox1.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            string sorgu = "INSERT INTO HastaEkranıTbl(Had,Htelefon,HRahatsizlik,Hcinsiyet,Hdtarih,HGelisTarih,Halerji,Hadres,HEmail) VALUES (@Had,@Htelefon,@HRahatsizlik,@Hcinsiyet,@Hdtarih,@HGelisTarih,@Halerji,@Hadres,@HEmail)";
            cmd=new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@Had",txt_ad.Text);
            cmd.Parameters.AddWithValue("@Htelefon", txt_tel.Text);
            cmd.Parameters.AddWithValue("@HRahatsizlik", txt_hastadurum.Text);
            cmd.Parameters.AddWithValue("@Hcinsiyet", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Hdtarih", txt_dtarih.Text);
            cmd.Parameters.AddWithValue("@HGelisTarih",dt_GelisTarih.Text);
            cmd.Parameters.AddWithValue("@Halerji", txt_alerji.Text);
            cmd.Parameters.AddWithValue("@Hadres", txt_adres.Text);
            cmd.Parameters.AddWithValue("@HEmail", textBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            HastaGetir();//güncel halini görmemizi sağlar

            MessageBox.Show("Kayıt başarıyla eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM HastaEkranıTbl WHERE HId=@HId";
            cmd=new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@HId", Convert.ToInt32(txt_ıd.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            HastaGetir();

            MessageBox.Show("Silme İşlemi Gerçekleşti","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_hastadurum.Clear();
            txt_ıd.Clear();
            txt_ad.Clear();
            txt_tel.Clear();
            txt_alerji.Clear();
            txt_adres.Clear();
            textBox1.Clear();
            

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update HastaEkranıTbl set Had=@Had,Htelefon=@Htelefon,Hcinsiyet=@Hcinsiyet,Hdtarih=@Hdtarih,HGelisTarih=@HGelisTarih,Halerji=@Halerji,Hadres=@Hadres,HEmail=@HEmail where Hıd=@Hıd";
            cmd=new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@HId", Convert.ToInt32(txt_ıd.Text));
            cmd.Parameters.AddWithValue("@Had", txt_ad.Text);
            cmd.Parameters.AddWithValue("@Htelefon", txt_tel.Text);
            cmd.Parameters.AddWithValue("@HRahatsizlik", txt_hastadurum.Text);
            cmd.Parameters.AddWithValue("@Hcinsiyet", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Hdtarih", txt_alerji.Text);
            cmd.Parameters.AddWithValue("@HGelisTarih",dt_GelisTarih.Text);
            cmd.Parameters.AddWithValue("@Halerji", txt_alerji.Text);
            cmd.Parameters.AddWithValue("@Hadres", txt_adres.Text);
            cmd.Parameters.AddWithValue("@HEmail", textBox1.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            HastaGetir();

            MessageBox.Show("Güncelleme işlemi başarıyla  gerçekleştirildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
            this.Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            Receteler receteler = new Receteler();
            receteler.Show();
            this.Hide();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu Anda Bu Sayfadasınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            HastaAra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tedavi tedavi= new Tedavi();
            tedavi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAra randevuAra = new RandevuAra();
            randevuAra.Show();
            this.Hide();
        }
    }
}
