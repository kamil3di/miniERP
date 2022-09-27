namespace RozaTEX_Otomasyon_2
{
    partial class FrmUretim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUretimGoruntule = new System.Windows.Forms.Button();
            this.comboBoxSorguTarih = new System.Windows.Forms.ComboBox();
            this.buttonTumUretimiGoruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUrunGuncelle = new System.Windows.Forms.Button();
            this.comboBoxGuncellemeTarih = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxGuncellemeAlan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGuncellemeDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUretimKaydet = new System.Windows.Forms.Button();
            this.textBox248Vardiyasi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1624Vardiyasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox816Vardiyasi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUretimUrunEni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUretimMusteriKodu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUretimLOTNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUretimTarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSilinecekTarih = new System.Windows.Forms.ComboBox();
            this.buttonUretimSil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUretimGoruntule);
            this.groupBox1.Controls.Add(this.comboBoxSorguTarih);
            this.groupBox1.Controls.Add(this.buttonTumUretimiGoruntule);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1531, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üretim Sorgulama";
            // 
            // buttonUretimGoruntule
            // 
            this.buttonUretimGoruntule.Location = new System.Drawing.Point(185, 52);
            this.buttonUretimGoruntule.Name = "buttonUretimGoruntule";
            this.buttonUretimGoruntule.Size = new System.Drawing.Size(172, 36);
            this.buttonUretimGoruntule.TabIndex = 6;
            this.buttonUretimGoruntule.Text = "Üretimi Görüntüle";
            this.buttonUretimGoruntule.UseVisualStyleBackColor = true;
            this.buttonUretimGoruntule.Click += new System.EventHandler(this.buttonUretimGoruntule_Click);
            // 
            // comboBoxSorguTarih
            // 
            this.comboBoxSorguTarih.FormattingEnabled = true;
            this.comboBoxSorguTarih.Location = new System.Drawing.Point(60, 52);
            this.comboBoxSorguTarih.Name = "comboBoxSorguTarih";
            this.comboBoxSorguTarih.Size = new System.Drawing.Size(121, 37);
            this.comboBoxSorguTarih.TabIndex = 5;
            // 
            // buttonTumUretimiGoruntule
            // 
            this.buttonTumUretimiGoruntule.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.buttonTumUretimiGoruntule.Location = new System.Drawing.Point(363, 52);
            this.buttonTumUretimiGoruntule.Name = "buttonTumUretimiGoruntule";
            this.buttonTumUretimiGoruntule.Size = new System.Drawing.Size(206, 36);
            this.buttonTumUretimiGoruntule.TabIndex = 4;
            this.buttonTumUretimiGoruntule.Text = "Tüm Üretimi Görüntüle";
            this.buttonTumUretimiGoruntule.UseVisualStyleBackColor = true;
            this.buttonTumUretimiGoruntule.Click += new System.EventHandler(this.buttonTumUretimiGoruntule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1517, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUrunGuncelle);
            this.groupBox2.Controls.Add(this.comboBoxGuncellemeTarih);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxGuncellemeAlan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxGuncellemeDeger);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 619);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üretim Güncelle";
            // 
            // buttonUrunGuncelle
            // 
            this.buttonUrunGuncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.buttonUrunGuncelle.Location = new System.Drawing.Point(1048, 57);
            this.buttonUrunGuncelle.Name = "buttonUrunGuncelle";
            this.buttonUrunGuncelle.Size = new System.Drawing.Size(284, 36);
            this.buttonUrunGuncelle.TabIndex = 7;
            this.buttonUrunGuncelle.Text = "Güncelle";
            this.buttonUrunGuncelle.UseVisualStyleBackColor = true;
            this.buttonUrunGuncelle.Click += new System.EventHandler(this.buttonUrunGuncelle_Click);
            // 
            // comboBoxGuncellemeTarih
            // 
            this.comboBoxGuncellemeTarih.FormattingEnabled = true;
            this.comboBoxGuncellemeTarih.Location = new System.Drawing.Point(127, 56);
            this.comboBoxGuncellemeTarih.Name = "comboBoxGuncellemeTarih";
            this.comboBoxGuncellemeTarih.Size = new System.Drawing.Size(121, 37);
            this.comboBoxGuncellemeTarih.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tarihi seçiniz:";
            // 
            // comboBoxGuncellemeAlan
            // 
            this.comboBoxGuncellemeAlan.FormattingEnabled = true;
            this.comboBoxGuncellemeAlan.Location = new System.Drawing.Point(565, 57);
            this.comboBoxGuncellemeAlan.Name = "comboBoxGuncellemeAlan";
            this.comboBoxGuncellemeAlan.Size = new System.Drawing.Size(191, 37);
            this.comboBoxGuncellemeAlan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Güncellemek istediğiniz alanı seçiniz:";
            // 
            // textBoxGuncellemeDeger
            // 
            this.textBoxGuncellemeDeger.Location = new System.Drawing.Point(921, 56);
            this.textBoxGuncellemeDeger.Name = "textBoxGuncellemeDeger";
            this.textBoxGuncellemeDeger.Size = new System.Drawing.Size(121, 36);
            this.textBoxGuncellemeDeger.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yeni değeri giriniz:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUretimKaydet);
            this.groupBox3.Controls.Add(this.textBox248Vardiyasi);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox1624Vardiyasi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox816Vardiyasi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxUretimUrunEni);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxUretimMusteriKodu);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxUretimLOTNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxUretimTarih);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1338, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üretim Başlat";
            // 
            // buttonUretimKaydet
            // 
            this.buttonUretimKaydet.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUretimKaydet.Location = new System.Drawing.Point(1145, 24);
            this.buttonUretimKaydet.Name = "buttonUretimKaydet";
            this.buttonUretimKaydet.Size = new System.Drawing.Size(187, 116);
            this.buttonUretimKaydet.TabIndex = 14;
            this.buttonUretimKaydet.Text = "Üretimi Kaydet";
            this.buttonUretimKaydet.UseVisualStyleBackColor = true;
            this.buttonUretimKaydet.Click += new System.EventHandler(this.buttonUretimKaydet_Click);
            // 
            // textBox248Vardiyasi
            // 
            this.textBox248Vardiyasi.Location = new System.Drawing.Point(1018, 104);
            this.textBox248Vardiyasi.Name = "textBox248Vardiyasi";
            this.textBox248Vardiyasi.Size = new System.Drawing.Size(121, 36);
            this.textBox248Vardiyasi.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(757, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "24:00 - 08:00 Vardiyası üretimi:";
            // 
            // textBox1624Vardiyasi
            // 
            this.textBox1624Vardiyasi.Location = new System.Drawing.Point(628, 104);
            this.textBox1624Vardiyasi.Name = "textBox1624Vardiyasi";
            this.textBox1624Vardiyasi.Size = new System.Drawing.Size(121, 36);
            this.textBox1624Vardiyasi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "16:00-24:00 Vardiyası üretimi:";
            // 
            // textBox816Vardiyasi
            // 
            this.textBox816Vardiyasi.Location = new System.Drawing.Point(252, 103);
            this.textBox816Vardiyasi.Name = "textBox816Vardiyasi";
            this.textBox816Vardiyasi.Size = new System.Drawing.Size(121, 36);
            this.textBox816Vardiyasi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "08:00-16:00 Vardiyası üretimi:";
            // 
            // textBoxUretimUrunEni
            // 
            this.textBoxUretimUrunEni.Location = new System.Drawing.Point(843, 51);
            this.textBoxUretimUrunEni.Name = "textBoxUretimUrunEni";
            this.textBoxUretimUrunEni.Size = new System.Drawing.Size(121, 36);
            this.textBoxUretimUrunEni.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürünün Eni:";
            // 
            // textBoxUretimMusteriKodu
            // 
            this.textBoxUretimMusteriKodu.Location = new System.Drawing.Point(600, 49);
            this.textBoxUretimMusteriKodu.Name = "textBoxUretimMusteriKodu";
            this.textBoxUretimMusteriKodu.Size = new System.Drawing.Size(121, 36);
            this.textBoxUretimMusteriKodu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Müşteri Kodu:";
            // 
            // textBoxUretimLOTNo
            // 
            this.textBoxUretimLOTNo.Location = new System.Drawing.Point(333, 49);
            this.textBoxUretimLOTNo.Name = "textBoxUretimLOTNo";
            this.textBoxUretimLOTNo.Size = new System.Drawing.Size(121, 36);
            this.textBoxUretimLOTNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "LOT Numarası:";
            // 
            // textBoxUretimTarih
            // 
            this.textBoxUretimTarih.Location = new System.Drawing.Point(61, 49);
            this.textBoxUretimTarih.Name = "textBoxUretimTarih";
            this.textBoxUretimTarih.Size = new System.Drawing.Size(121, 36);
            this.textBoxUretimTarih.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSilinecekTarih);
            this.groupBox4.Controls.Add(this.buttonUretimSil);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.groupBox4.Location = new System.Drawing.Point(1356, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 262);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Üretim Sil";
            // 
            // comboBoxSilinecekTarih
            // 
            this.comboBoxSilinecekTarih.FormattingEnabled = true;
            this.comboBoxSilinecekTarih.Location = new System.Drawing.Point(11, 87);
            this.comboBoxSilinecekTarih.Name = "comboBoxSilinecekTarih";
            this.comboBoxSilinecekTarih.Size = new System.Drawing.Size(162, 37);
            this.comboBoxSilinecekTarih.TabIndex = 17;
            // 
            // buttonUretimSil
            // 
            this.buttonUretimSil.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUretimSil.Location = new System.Drawing.Point(11, 130);
            this.buttonUretimSil.Name = "buttonUretimSil";
            this.buttonUretimSil.Size = new System.Drawing.Size(162, 116);
            this.buttonUretimSil.TabIndex = 15;
            this.buttonUretimSil.Text = "Üretimi Sil";
            this.buttonUretimSil.UseVisualStyleBackColor = true;
            this.buttonUretimSil.Click += new System.EventHandler(this.buttonUretimSil_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Silinecek Tarih:";
            // 
            // FrmUretim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 734);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUretim";
            this.Text = "Üretim Sorgu & Kayıt Paneli";
            this.Load += new System.EventHandler(this.FrmUretim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGuncellemeDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxUretimTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGuncellemeAlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUretimUrunEni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUretimMusteriKodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUretimLOTNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox248Vardiyasi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1624Vardiyasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox816Vardiyasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGuncellemeTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonUrunGuncelle;
        private System.Windows.Forms.Button buttonUretimKaydet;
        private System.Windows.Forms.Button buttonTumUretimiGoruntule;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonUretimSil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSilinecekTarih;
        private System.Windows.Forms.Button buttonUretimGoruntule;
        private System.Windows.Forms.ComboBox comboBoxSorguTarih;
    }
}