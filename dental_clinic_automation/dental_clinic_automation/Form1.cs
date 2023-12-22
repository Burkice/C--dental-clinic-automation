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
    
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            string kullaniciadi = txt_kullaniciAdi.Text;
            string parola = txt_Parola.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
            {
                conn.Open();

                // Admin tablosunda kontrol
                using (SqlCommand adminCmd = new SqlCommand("SELECT * FROM AdminTbl WHERE AdminId=@AdminId AND AdminSifre=@AdminSifre", conn))
                {
                    adminCmd.Parameters.AddWithValue("@AdminId", kullaniciadi);
                    adminCmd.Parameters.AddWithValue("@AdminSifre", parola);

                    using (SqlDataReader adminReader = adminCmd.ExecuteReader())
                    {
                        if (adminReader.Read())
                        {
                            // Kullanıcı admin ise
                            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
                            adminAnaSayfa.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                // Eğer kullanıcı admin değilse, Doktor tablosunda kontrol
                using (SqlCommand doktorCmd = new SqlCommand("SELECT * FROM Doctor WHERE DoktorId=@DoktorId AND DoktorTc=@DoktorTc", conn))
                {
                    doktorCmd.Parameters.AddWithValue("@DoktorId", kullaniciadi);
                    doktorCmd.Parameters.AddWithValue("@DoktorTc", parola);

                    using (SqlDataReader doktorReader = doktorCmd.ExecuteReader())
                    {
                        if (doktorReader.Read())
                        {
                            // Kullanıcı doktor ise
                            Anasayfa anasayfa = new Anasayfa();
                            anasayfa.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                // Eğer hiçbir tabloda kullanıcı bulunamazsa
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

        

        /* using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
         {
             conn.Open();

             using (SqlCommand cmd = new SqlCommand("SELECT * FROM Doctor WHERE DoktorId=@DoktorId AND DoktorTc=@DoktorTc", conn))
             {
                 cmd.Parameters.AddWithValue("@DoktorId", kullaniciadi);
                 cmd.Parameters.AddWithValue("@DoktorTc", parola);

                 using (SqlDataReader reader = cmd.ExecuteReader())
                 {
                     if (reader.Read())
                     {
                         Anasayfa anasayfa = new Anasayfa();
                         anasayfa.Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                     }
                 }
             }
         }
        */








    }
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_kullaniciAdi.Text;
            string parola = txt_Parola.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-925472U\\SQLEXPRESS;Initial Catalog=IstanbulDisKlinik;Integrated Security=True"))
            {
                conn.Open();

                // Admin tablosunda kontrol
                using (SqlCommand adminCmd = new SqlCommand("SELECT * FROM AdminTbl WHERE AdminId=@AdminId AND AdminSifre=@AdminSifre", conn))
                {
                    adminCmd.Parameters.AddWithValue("@AdminId", kullaniciadi);
                    adminCmd.Parameters.AddWithValue("@AdminSifre", parola);

                    using (SqlDataReader adminReader = adminCmd.ExecuteReader())
                    {
                        if (adminReader.Read())
                        {
                            // Kullanıcı admin ise
                            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
                            adminAnaSayfa.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                // Eğer kullanıcı admin değilse, Doktor tablosunda kontrol
                using (SqlCommand doktorCmd = new SqlCommand("SELECT * FROM Doctor WHERE DoktorId=@DoktorId AND DoktorTc=@DoktorTc", conn))
                {
                    doktorCmd.Parameters.AddWithValue("@DoktorId", kullaniciadi);
                    doktorCmd.Parameters.AddWithValue("@DoktorTc", parola);

                    using (SqlDataReader doktorReader = doktorCmd.ExecuteReader())
                    {
                        if (doktorReader.Read())
                        {
                            // Kullanıcı doktor ise
                            Anasayfa anasayfa = new Anasayfa();
                            anasayfa.Show();
                            this.Hide();
                            return;
                        }
                    }
                }

                // Eğer hiçbir tabloda kullanıcı bulunamazsa
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
