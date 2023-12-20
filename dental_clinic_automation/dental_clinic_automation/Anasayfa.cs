using DevExpress.XtraEditors.ColorPick.Picker;
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            Hasta_Ekranı hasta_Ekranı= new Hasta_Ekranı();
            hasta_Ekranı.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Randevu randevu= new Randevu();
            randevu.Show();
            this.Hide();
        }

        private void btn_tedavi_Click(object sender, EventArgs e)
        {
            /*Tedavi tedavi= new Tedavi();
            tedavi.Show();
            this.Hide();
            */
        }

        private void btn_Recete_Click(object sender, EventArgs e)
        {
            Receteler receteler= new Receteler();
            receteler.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuAra randevu= new RandevuAra();
            randevu.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
