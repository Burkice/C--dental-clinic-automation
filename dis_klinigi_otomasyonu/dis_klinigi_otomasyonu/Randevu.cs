﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dis_klinigi_otomasyonu
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
         Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


           

        }
    }
}
