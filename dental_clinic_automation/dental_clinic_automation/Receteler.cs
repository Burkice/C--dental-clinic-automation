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

  
    public partial class Receteler : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Receteler()
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
            adapter = new SqlDataAdapter("select*from ReceteTbl where HasAd like '%"+textBox1.Text+"%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void Randevular()
        {
            string connectionString = "Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter("select*from RandevuTbl", conn); // burada verileri çektik
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            dataGridView2.Columns["Hasta"].Visible = true;
            dataGridView2.Columns["Tedavi"].Visible = true;
            dataGridView2.Columns["RUygulanacakYer"].Visible = false;
            dataGridView2.Columns["Tedavi2"].Visible = true;
            dataGridView2.Columns["UygulanacakYer2"].Visible = false;
            dataGridView2.Columns["RTarih"].Visible = false;
            dataGridView2.Columns["RSaat"].Visible = false;
            dataGridView2.Columns["RAciklama"].Visible = false;
            dataGridView2.Columns["RDoctor"].Visible = false;
            dataGridView2.Columns["Rtutar"].Visible = true;
            dataGridView2.Columns["Rtutar2"].Visible = true;

        }

        private void Hasta()  //Burada Randevu sayfasından randevu verilen hastanın reçeteler sayfasındaki combobax da görüntülenmesinin kodları yazılmıştır
        {
           /* SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True;Connect Timeout=200");
           
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT Hasta FROM RandevuTbl", conn);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Hasta", typeof(string));
                dt.Load(sqlDataReader);

                combobax_Ad.ValueMember = "Hasta";
                combobax_Ad.DisplayMember = "Hasta";
                combobax_Ad.DataSource = dt;
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
        private void TedaviHasta()
        {
            /*
            //Burada combobax dan hasta seçilince otomatik olarak tedavisi de eklenmesinin kodları yazılmıştır
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from RandevuTbl where Hasta='" + combobax_Ad.SelectedValue.ToString() + "'", conn);
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                txt_ad.Text = dr["Tedavi"].ToString();
                txt_tedavi2.Text = dr["Tedavi2"].ToString();
            }
            */

        }
       


       
        private void Tutar()
        {
            /*
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from RandevuTbl where Hasta='" + combobax_Ad.SelectedValue.ToString() + "'", conn);
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                comboBox_tutar.Text = dr["Rtutar"].ToString();
                comboBox1.Text = dr["Rtutar2"].ToString();
            }
            */
        }
        void RHastaAra()
        {
            conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True");
            adapter = new SqlDataAdapter("select*from RandevuTbl where Hasta like '%" + textBox3.Text + "%'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Receteler_Load(object sender, EventArgs e)
        {
            Hasta();
            Recete();
            Tutar();
            Randevular();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void combobax_Ad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TedaviHasta();
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
            MessageBox.Show("Şu Anda Bu Sayfadasınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_tutar_TextChanged(object sender, EventArgs e)
        {
            Tutar();
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            Tutar(); 
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
                {
                    string sorgu = "INSERT INTO ReceteTbl(HasAd,TedaviAd,TedaviUcret,Tedavi2Ad,TedaviUcret2,Ilac,IlacMiktar,Tutar) VALUES (@HasAd,@TedaviAd,@TedaviUcret,@Tedavi2Ad,@TedaviUcret2,@Ilac,@IlacMiktar,@Tutar)";
                    using (SqlCommand cmd = new SqlCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@HasAd", textBox4.Text);
                        cmd.Parameters.AddWithValue("@TedaviAd", txt_ad.Text);
                        cmd.Parameters.AddWithValue("@TedaviUcret",textBox5.Text);
                        cmd.Parameters.AddWithValue("@Tedavi2Ad", txt_tedavi2.Text);
                        cmd.Parameters.AddWithValue("@TedaviUcret2", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Ilac", textBox2.Text);
                        cmd.Parameters.AddWithValue("@IlacMiktar", txt_mikar.Text);
                        cmd.Parameters.AddWithValue("@Tutar", textBox7.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Recete();

        }








        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ReceteTbl WHERE RId=@RId";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@RId", Convert.ToInt32(txt_ıd.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Recete();

            MessageBox.Show("Silme İşlemi Gerçekleşti", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_tedavi2.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_mikar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ReceteAra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
           textBox4.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_ad.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text= dataGridView2.CurrentRow.Cells[10].Value.ToString();
            txt_tedavi2.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text= dataGridView2.CurrentRow.Cells[11].Value.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            RHastaAra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAra randevuAra = new RandevuAra();
            randevuAra.Show();
            this.Hide();
        }
    }
}



//SqlCommand cmd = new SqlCommand("select*from RandevuTbl where Hasta='" + combobax_Ad.SelectedValue.ToString() + "'", conn);