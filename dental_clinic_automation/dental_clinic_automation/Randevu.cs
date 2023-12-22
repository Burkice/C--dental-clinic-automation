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
using static DevExpress.XtraEditors.Mask.MaskSettings;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Data.Common;
using System.Data.Linq.Mapping;

namespace dental_clinic_automation
{
    public partial class Randevu : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Randevu()
        {
            InitializeComponent();
        }
        
        private void Hasta()
        {
          /*  SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");

            try
            {
                conn.Open();

                
                SqlCommand cmd = new SqlCommand("SELECT Had FROM HastaEkranıTbl", conn);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Had", typeof(string));
                dt.Load(sqlDataReader);

                comboBox_ad.ValueMember = "Had";
                comboBox_ad.DisplayMember = "Had";
                comboBox_ad.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
          */
        }

        void HastaAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from HastaEkranıTbl where Had like '%" + textBox3.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
          

       void  RHastaGetir()
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
            adapter = new SqlDataAdapter("select*from RandevuTbl where Hasta like '%"+textBox1.Text+"%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Doctor()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");

            try
            {
                con.Open();

                SqlCommand cmdd = new SqlCommand("SELECT DoktorAd FROM Doctor", con);

                SqlDataReader sqlDataReaderr = cmdd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("DoktorAd", typeof(string));
                dt.Load(sqlDataReaderr);

                comboBox1.ValueMember = "DoktorAd";
                comboBox1.DisplayMember = "DoktorAd";
                comboBox1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void Hastalar()
        {
            string connectionString = "Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select*from HastaEkranıTbl", conn); // burada verileri çektik
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            dataGridView2.Columns["Had"].Visible = true;
            dataGridView2.Columns["HTelefon"].Visible = false;
            dataGridView2.Columns["HRahatsizlik"].Visible = false;
            dataGridView2.Columns["Hcinsiyet"].Visible = false;
            dataGridView2.Columns["Hdtarih"].Visible = false;
            dataGridView2.Columns["HGelisTarih"].Visible = false;
            dataGridView2.Columns["Halerji"].Visible = false;
            dataGridView2.Columns["Hadres"].Visible = false;
            dataGridView2.Columns["HEmail"].Visible=false;
        }



        private void Randevu_Load(object sender, EventArgs e)
        {
            Hasta();
            RHastaGetir();
            Doctor();
            Hastalar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_ustcene_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                txt_tedaviAd.Text = "üst cene tedavisi";
                txt_tutar.Text = "1000";
            }
            else if(radioButton2.Checked)
            {
                txt_tedavi2.Text = "üst cene tedavisi";
                textBox2.Text = "1000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox_kanal_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                txt_tedaviAd.Text = "kanal  tedavisi";
                txt_tutar.Text = "2000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "kanal tedavisi";
                textBox2.Text = "2000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox_cekim_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                txt_tedaviAd.Text = "Diş Çekimi";
                txt_tutar.Text = "3000";
            }
            else if(radioButton2.Checked)
            {
                txt_tedavi2.Text = "Diş Çekimi";
                textBox2.Text = "3000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox_muayne_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tedaviAd.Text = "Rutin Muayne";
                txt_tutar.Text = "4000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "Rutin Muayne";
                textBox2.Text = "4000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox_altcene_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tedaviAd.Text = "alt çene tedavisi";
                txt_tutar.Text = "5000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "alt çene tedavisi";
                textBox2.Text = "5000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox_dolgu_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tedaviAd.Text = "Dolgu  tedavisi";
                txt_tutar.Text = "6000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "Dolgu tedavisi";
                textBox2.Text = "6000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox_beyazlatma_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tedaviAd.Text = "Diş Beyazlatma ";
                txt_tutar.Text = "7000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "Diş Beyazlatma";
                textBox2.Text = "7000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox_implant_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tedaviAd.Text = "implant tedavisi";
                txt_tutar.Text = "8000";
            }
            else if (radioButton2.Checked)
            {
                txt_tedavi2.Text = "implant tedavisi";
                textBox2.Text = "8000";
            }
            else
            {
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO RandevuTbl (Hasta, Tedavi, RUygulanacakYer,Tedavi2,UygulanacakYer2, RTarih, RSaat, RAciklama, RDoctor, RTutar,Rtutar2) VALUES (@Hasta, @Tedavi, @RUygulanacakYer,@Tedavi2,@UygulanacakYer2, @RTarih, @RSaat, @RAciklama, @RDoctor, @RTutar,@Rtutar2)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Hasta", txt_HastaAdı.Text);
                        cmd.Parameters.AddWithValue("@Tedavi", txt_tedaviAd.Text);
                        cmd.Parameters.AddWithValue("@RUygulanacakYer", txt_yer.Text);
                        cmd.Parameters.AddWithValue("@Tedavi2", txt_tedavi2.Text);
                        cmd.Parameters.AddWithValue("@UygulanacakYer2", txt_uygulanacakyer2.Text);
                        cmd.Parameters.AddWithValue("@RTarih", txt_rtarih.Text);
                        cmd.Parameters.AddWithValue("@RSaat", comboBox_saat.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@RAciklama", txt_Raciklama.Text);
                        cmd.Parameters.AddWithValue("@RDoctor", comboBox1.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@RTutar", txt_tutar.Text);
                        cmd.Parameters.AddWithValue("@Rtutar2", textBox2.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Randevu Kaydı Başarıyla Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RHastaGetir();

                    txt_ıd.Clear();
                    txt_tutar.Clear();
                    txt_tedaviAd.Clear();
                    txt_yer.Clear();
                    txt_tedavi2.Clear();
                    textBox2.Clear();
                    txt_uygulanacakyer2.Clear();
                    txt_Raciklama.Clear();
                    comboBox_saat.Items.Clear();
                    comboBox_saat.Items.Clear();

                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM RandevuTbl WHERE RId=@RId";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@RId", Convert.ToInt32(txt_ıd.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            RHastaGetir();

            MessageBox.Show("Silme İşlemi Gerçekleşti", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_HastaAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tedaviAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_yer.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_tedavi2.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_uygulanacakyer2.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_rtarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox_saat.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_Raciklama.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_tutar.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            txt_ıd.Clear();
            txt_tutar.Clear();
            txt_tedaviAd.Clear();
            txt_yer.Clear();
            txt_tedavi2.Clear();
            textBox2.Clear();
            txt_uygulanacakyer2.Clear();
            txt_Raciklama.Clear();
            comboBox_saat.Items.Clear();
            comboBox_saat.Items.Clear();
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update RandevuTbl set Hasta=@Hasta,Tedavi=@Tedavi,RUygulanacakYer=@RUygulanacakYer,Tedavi2=@Tedavi2,UygulanacakYer2=@UygulanacakYer2,RTarih=@RTarih,RSaat=@RSaat,RAciklama=@RAciklama,RDoctor=@RDoctor,Rtutar=@Rtutar,Rtutar2=@Rtutar2 where RId=@RId";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@RId", Convert.ToInt32(txt_ıd.Text));
            cmd.Parameters.AddWithValue("@Hasta", txt_HastaAdı.Text);
            cmd.Parameters.AddWithValue("@Tedavi", txt_tedaviAd.Text);
            cmd.Parameters.AddWithValue("@RUygulanacakYer",txt_yer.Text);
            cmd.Parameters.AddWithValue("@Tedavi2", txt_tedavi2.Text);
            cmd.Parameters.AddWithValue("@UygulanacakYer2", txt_uygulanacakyer2.Text);
            cmd.Parameters.AddWithValue("@RTarih", txt_rtarih.Text);
            cmd.Parameters.AddWithValue("@RSaat", comboBox_saat.SelectedItem);
            cmd.Parameters.AddWithValue("@RAciklama", txt_Raciklama.Text);
            cmd.Parameters.AddWithValue("@RDoctor", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Rtutar", txt_tutar.Text);
            cmd.Parameters.AddWithValue("@Rtutar2", textBox2.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            RHastaGetir();

            MessageBox.Show("Güncelleme işlemi başarıyla  gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txt_ıd.Clear();
            txt_tutar.Clear();
            txt_tedaviAd.Clear();
            txt_yer.Clear();
            txt_tedavi2.Clear();
            textBox2.Clear();
            txt_uygulanacakyer2.Clear();
            txt_Raciklama.Clear();
            comboBox_saat.Items.Clear();
            comboBox_saat.Items.Clear();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Hasta_Ekranı hasta_Ekranı=new Hasta_Ekranı();
            hasta_Ekranı.Show();
            this.Hide();
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            Receteler receteler=new Receteler();
            receteler.Show();
            this.Hide();

        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şu Anda Bu Sayfadasınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Üst Çene";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Üst Çene";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Alt Çene";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Alt Çene";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Azı Diş";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Azı Diş";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
           ;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Küçük Azı Diş";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Küçük Azı Diş";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Köpek Dişleri";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Köpek Dişleri";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Kesici Dişler";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Kesici Dişler";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txt_yer.Text = "Yirmilik Dişler";
            else if (radioButton2.Checked)
                txt_uygulanacakyer2.Text = "Yirmilik Dişler";
            else
                MessageBox.Show("Lütfen Tedavi Seçimi Yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_ad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           // Doctor();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Doctor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RHastaAra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            HastaAra();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_HastaAdı.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuAra randevu= new RandevuAra();
            randevu.Show();
            this.Hide();
        }
    }
}
