﻿namespace dental_clinic_automation
{
    partial class Doktorlar_Listesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar_Listesi));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Recete = new System.Windows.Forms.Button();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.btn_hasta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(145, 661);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 30);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-transparent-magnifying-glass-font-search-magnifying-glass-icon-glass-text-car" +
        "toon-thumbnail.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1353, 360);
            this.dataGridView1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(671, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 67);
            this.label1.TabIndex = 79;
            this.label1.Text = "SİSTEMDEKİ DOKTORLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1316, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 36);
            this.label2.TabIndex = 83;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Recete);
            this.panel1.Controls.Add(this.btn_randevu);
            this.panel1.Controls.Add(this.btn_hasta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 100);
            this.panel1.TabIndex = 84;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "Invoice-Icon.png";
            this.button3.ImageList = this.ımageList3;
            this.button3.Location = new System.Drawing.Point(1127, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 12;
            this.button3.Text = "FATURA";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "png-transparent-dental-dental-chair-dentist-dentistry-medical-tooth-dental-treatm" +
        "ent-dental-premium-color-symbol-icon-thumbnail.png");
            this.ımageList3.Images.SetKeyName(1, "Ekran görüntüsü 2023-11-26 152635.png");
            this.ımageList3.Images.SetKeyName(2, "png-transparent-icon-calendar-symbol-day-business-appointment-schedule-thumbnail." +
        "png");
            this.ımageList3.Images.SetKeyName(3, "png-transparent-dental-dental-chair-dentist-dentistry-medical-tooth-dental-treatm" +
        "ent-dental-premium-color-symbol-icon-thumbnail.png");
            this.ımageList3.Images.SetKeyName(4, "png-transparent-computer-icons-integrity-physical-therapy-management-organization" +
        "-optoro-check-mark-and-x-angle-text-service.png");
            this.ımageList3.Images.SetKeyName(5, "e-imza-destegi-ile-guvenli-bir-sekilde-recetenizi-yazin_1.png");
            this.ımageList3.Images.SetKeyName(6, "2023-07-21.jpg");
            this.ımageList3.Images.SetKeyName(7, "Invoice-Icon.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "2023-07-21.jpg";
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(943, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Doktorlar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "png-transparent-dental-dental-chair-dentist-dentistry-medical-tooth-dental-treatm" +
        "ent-dental-premium-color-symbol-icon-thumbnail.png");
            this.ımageList2.Images.SetKeyName(1, "Ekran görüntüsü 2023-11-26 152635.png");
            this.ımageList2.Images.SetKeyName(2, "png-transparent-icon-calendar-symbol-day-business-appointment-schedule-thumbnail." +
        "png");
            this.ımageList2.Images.SetKeyName(3, "png-transparent-dental-dental-chair-dentist-dentistry-medical-tooth-dental-treatm" +
        "ent-dental-premium-color-symbol-icon-thumbnail.png");
            this.ımageList2.Images.SetKeyName(4, "png-transparent-computer-icons-integrity-physical-therapy-management-organization" +
        "-optoro-check-mark-and-x-angle-text-service.png");
            this.ımageList2.Images.SetKeyName(5, "e-imza-destegi-ile-guvenli-bir-sekilde-recetenizi-yazin_1.png");
            this.ımageList2.Images.SetKeyName(6, "2023-07-21.jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "2023-07-21.jpg";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(758, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "DoktorEkle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1535, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_Recete
            // 
            this.btn_Recete.BackColor = System.Drawing.Color.White;
            this.btn_Recete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Recete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Recete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Recete.ImageKey = "e-imza-destegi-ile-guvenli-bir-sekilde-recetenizi-yazin_1.png";
            this.btn_Recete.ImageList = this.ımageList2;
            this.btn_Recete.Location = new System.Drawing.Point(588, 12);
            this.btn_Recete.Name = "btn_Recete";
            this.btn_Recete.Size = new System.Drawing.Size(164, 70);
            this.btn_Recete.TabIndex = 6;
            this.btn_Recete.Text = "Reçeteler";
            this.btn_Recete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Recete.UseVisualStyleBackColor = false;
            this.btn_Recete.Click += new System.EventHandler(this.btn_Recete_Click);
            // 
            // btn_randevu
            // 
            this.btn_randevu.BackColor = System.Drawing.Color.White;
            this.btn_randevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_randevu.ImageKey = "png-transparent-computer-icons-integrity-physical-therapy-management-organization" +
    "-optoro-check-mark-and-x-angle-text-service.png";
            this.btn_randevu.ImageList = this.ımageList2;
            this.btn_randevu.Location = new System.Drawing.Point(439, 12);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(143, 70);
            this.btn_randevu.TabIndex = 4;
            this.btn_randevu.Text = "Randevu";
            this.btn_randevu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_randevu.UseVisualStyleBackColor = false;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // btn_hasta
            // 
            this.btn_hasta.BackColor = System.Drawing.Color.White;
            this.btn_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hasta.ImageKey = "2023-07-21.jpg";
            this.btn_hasta.ImageList = this.ımageList2;
            this.btn_hasta.Location = new System.Drawing.Point(290, 12);
            this.btn_hasta.Name = "btn_hasta";
            this.btn_hasta.Size = new System.Drawing.Size(143, 70);
            this.btn_hasta.TabIndex = 3;
            this.btn_hasta.Text = "Hasta";
            this.btn_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hasta.UseVisualStyleBackColor = false;
            this.btn_hasta.Click += new System.EventHandler(this.btn_hasta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 114;
            this.label4.Text = "ARA :";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "Invoice-Icon.png";
            this.button4.ImageList = this.ımageList3;
            this.button4.Location = new System.Drawing.Point(1301, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 70);
            this.button4.TabIndex = 13;
            this.button4.Text = "FATURALAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Doktorlar_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 762);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doktorlar_Listesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorlar_Listesi";
            this.Load += new System.EventHandler(this.Doktorlar_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Recete;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.Button btn_hasta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}