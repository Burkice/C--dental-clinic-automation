using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_clinic_automation
{
    public partial class AdminAnaSayfa : Form
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Kayitli_Kullanıcılar kayitli_Kullanıcılar=new Kayitli_Kullanıcılar();
            kayitli_Kullanıcılar.Show();
            this.Hide();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevulu_Hastalar randevulu_Hastalar = new Randevulu_Hastalar();
            randevulu_Hastalar.Show();
            this.Hide(); 
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
           KayitliReceteler kayitliReceteler = new KayitliReceteler();
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
            Doktorlar_Listesi doktorlar_Listesi = new Doktorlar_Listesi();
            doktorlar_Listesi.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faturalar faturalar = new Faturalar();
            faturalar.Show();
            this.Hide();
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
