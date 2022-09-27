namespace RozaTEX_Otomasyon_2
{
    partial class FrmLOT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTumLOTlar = new System.Windows.Forms.Button();
            this.buttonLOTSorgu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxLOTSorgu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBobinSayisi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxIplikcm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxYarnType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSiparisNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBitisTarih = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLOTNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGenislik = new System.Windows.Forms.TextBox();
            this.textBoxTotalMiktar = new System.Windows.Forms.TextBox();
            this.textBoxAgirlik = new System.Windows.Forms.TextBox();
            this.textBoxUzunluk = new System.Windows.Forms.TextBox();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.BtnLotKayit = new System.Windows.Forms.Button();
            this.buttonLOTKayitSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLOTKayitSil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxLOTGuncelle = new System.Windows.Forms.ComboBox();
            this.textBoxGuncellenmisDeger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLOTGuncelle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonLOTGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonTumLOTlar);
            this.groupBox1.Controls.Add(this.buttonLOTSorgu);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBoxLOTSorgu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1770, 613);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOT Sorgulama";
            // 
            // buttonTumLOTlar
            // 
            this.buttonTumLOTlar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.buttonTumLOTlar.Location = new System.Drawing.Point(388, 50);
            this.buttonTumLOTlar.Name = "buttonTumLOTlar";
            this.buttonTumLOTlar.Size = new System.Drawing.Size(168, 36);
            this.buttonTumLOTlar.TabIndex = 14;
            this.buttonTumLOTlar.Text = "Tüm LOT\'ları görüntüle";
            this.buttonTumLOTlar.UseVisualStyleBackColor = true;
            this.buttonTumLOTlar.Click += new System.EventHandler(this.buttonTumLOTlar_Click);
            // 
            // buttonLOTSorgu
            // 
            this.buttonLOTSorgu.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLOTSorgu.Location = new System.Drawing.Point(257, 50);
            this.buttonLOTSorgu.Name = "buttonLOTSorgu";
            this.buttonLOTSorgu.Size = new System.Drawing.Size(125, 36);
            this.buttonLOTSorgu.TabIndex = 13;
            this.buttonLOTSorgu.Text = "LOT Sorgula";
            this.buttonLOTSorgu.UseVisualStyleBackColor = true;
            this.buttonLOTSorgu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1751, 510);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxLOTSorgu
            // 
            this.textBoxLOTSorgu.Location = new System.Drawing.Point(130, 50);
            this.textBoxLOTSorgu.Name = "textBoxLOTSorgu";
            this.textBoxLOTSorgu.Size = new System.Drawing.Size(121, 36);
            this.textBoxLOTSorgu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT Numarası:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBobinSayisi);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxIplikcm);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxYarnType);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxSiparisNo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxBitisTarih);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxLOTNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxGenislik);
            this.groupBox2.Controls.Add(this.textBoxTotalMiktar);
            this.groupBox2.Controls.Add(this.textBoxAgirlik);
            this.groupBox2.Controls.Add(this.textBoxUzunluk);
            this.groupBox2.Controls.Add(this.textBoxUrunKodu);
            this.groupBox2.Controls.Add(this.textBoxTarih);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTarih);
            this.groupBox2.Controls.Add(this.BtnLotKayit);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.groupBox2.Location = new System.Drawing.Point(12, 631);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1790, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni LOT Girişi";
            // 
            // textBoxBobinSayisi
            // 
            this.textBoxBobinSayisi.Location = new System.Drawing.Point(139, 107);
            this.textBoxBobinSayisi.Name = "textBoxBobinSayisi";
            this.textBoxBobinSayisi.Size = new System.Drawing.Size(63, 36);
            this.textBoxBobinSayisi.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(5, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 35);
            this.label16.TabIndex = 23;
            this.label16.Text = "Bobin Sayısı:";
            // 
            // textBoxIplikcm
            // 
            this.textBoxIplikcm.Location = new System.Drawing.Point(1438, 47);
            this.textBoxIplikcm.Name = "textBoxIplikcm";
            this.textBoxIplikcm.Size = new System.Drawing.Size(102, 36);
            this.textBoxIplikcm.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1341, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 35);
            this.label15.TabIndex = 21;
            this.label15.Text = "İplik/cm:";
            // 
            // textBoxYarnType
            // 
            this.textBoxYarnType.Location = new System.Drawing.Point(1209, 47);
            this.textBoxYarnType.Name = "textBoxYarnType";
            this.textBoxYarnType.Size = new System.Drawing.Size(121, 36);
            this.textBoxYarnType.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1109, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 35);
            this.label14.TabIndex = 19;
            this.label14.Text = "İplik Tipi:";
            // 
            // textBoxSiparisNo
            // 
            this.textBoxSiparisNo.Location = new System.Drawing.Point(1013, 49);
            this.textBoxSiparisNo.Name = "textBoxSiparisNo";
            this.textBoxSiparisNo.Size = new System.Drawing.Size(94, 36);
            this.textBoxSiparisNo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(830, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 35);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sipariş Numarası:";
            // 
            // textBoxBitisTarih
            // 
            this.textBoxBitisTarih.Location = new System.Drawing.Point(479, 48);
            this.textBoxBitisTarih.Name = "textBoxBitisTarih";
            this.textBoxBitisTarih.Size = new System.Drawing.Size(117, 36);
            this.textBoxBitisTarih.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(360, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 35);
            this.label11.TabIndex = 15;
            this.label11.Text = "Bitiş Tarihi:";
            // 
            // textBoxLOTNo
            // 
            this.textBoxLOTNo.Location = new System.Drawing.Point(86, 48);
            this.textBoxLOTNo.Name = "textBoxLOTNo";
            this.textBoxLOTNo.Size = new System.Drawing.Size(67, 36);
            this.textBoxLOTNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "LOT No:";
            // 
            // textBoxGenislik
            // 
            this.textBoxGenislik.Location = new System.Drawing.Point(648, 104);
            this.textBoxGenislik.Name = "textBoxGenislik";
            this.textBoxGenislik.Size = new System.Drawing.Size(110, 36);
            this.textBoxGenislik.TabIndex = 11;
            // 
            // textBoxTotalMiktar
            // 
            this.textBoxTotalMiktar.Location = new System.Drawing.Point(959, 104);
            this.textBoxTotalMiktar.Name = "textBoxTotalMiktar";
            this.textBoxTotalMiktar.Size = new System.Drawing.Size(119, 36);
            this.textBoxTotalMiktar.TabIndex = 12;
            // 
            // textBoxAgirlik
            // 
            this.textBoxAgirlik.Location = new System.Drawing.Point(371, 104);
            this.textBoxAgirlik.Name = "textBoxAgirlik";
            this.textBoxAgirlik.Size = new System.Drawing.Size(123, 36);
            this.textBoxAgirlik.TabIndex = 10;
            // 
            // textBoxUzunluk
            // 
            this.textBoxUzunluk.Location = new System.Drawing.Point(1639, 47);
            this.textBoxUzunluk.Name = "textBoxUzunluk";
            this.textBoxUzunluk.Size = new System.Drawing.Size(135, 36);
            this.textBoxUzunluk.TabIndex = 8;
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Location = new System.Drawing.Point(714, 47);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(117, 36);
            this.textBoxUrunKodu.TabIndex = 4;
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Location = new System.Drawing.Point(225, 47);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(131, 36);
            this.textBoxTarih.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(774, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Miktar(m2):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(500, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genişlik(mm):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(219, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ağırlık(gr/m2):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1545, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uzunluk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(599, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kodu:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(159, 48);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(68, 35);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // BtnLotKayit
            // 
            this.BtnLotKayit.Location = new System.Drawing.Point(1084, 102);
            this.BtnLotKayit.Name = "BtnLotKayit";
            this.BtnLotKayit.Size = new System.Drawing.Size(694, 41);
            this.BtnLotKayit.TabIndex = 0;
            this.BtnLotKayit.Text = "LOT Kaydet";
            this.BtnLotKayit.UseVisualStyleBackColor = true;
            this.BtnLotKayit.Click += new System.EventHandler(this.BtnLotKayit_Click);
            // 
            // buttonLOTKayitSil
            // 
            this.buttonLOTKayitSil.Location = new System.Drawing.Point(11, 97);
            this.buttonLOTKayitSil.Name = "buttonLOTKayitSil";
            this.buttonLOTKayitSil.Size = new System.Drawing.Size(563, 93);
            this.buttonLOTKayitSil.TabIndex = 0;
            this.buttonLOTKayitSil.Text = "LOT Kaydını Sil";
            this.buttonLOTKayitSil.UseVisualStyleBackColor = true;
            this.buttonLOTKayitSil.Click += new System.EventHandler(this.buttonLOTKayitSil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F);
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "LOT No:";
            // 
            // textBoxLOTKayitSil
            // 
            this.textBoxLOTKayitSil.Location = new System.Drawing.Point(86, 50);
            this.textBoxLOTKayitSil.Name = "textBoxLOTKayitSil";
            this.textBoxLOTKayitSil.Size = new System.Drawing.Size(488, 36);
            this.textBoxLOTKayitSil.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxLOTKayitSil);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonLOTKayitSil);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.groupBox3.Location = new System.Drawing.Point(12, 792);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOT Sil";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxLOTGuncelle);
            this.groupBox4.Controls.Add(this.textBoxGuncellenmisDeger);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBoxLOTGuncelle);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.buttonLOTGuncelle);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.groupBox4.Location = new System.Drawing.Point(649, 792);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 205);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LOT Güncelle";
            // 
            // comboBoxLOTGuncelle
            // 
            this.comboBoxLOTGuncelle.FormattingEnabled = true;
            this.comboBoxLOTGuncelle.Location = new System.Drawing.Point(226, 99);
            this.comboBoxLOTGuncelle.Name = "comboBoxLOTGuncelle";
            this.comboBoxLOTGuncelle.Size = new System.Drawing.Size(251, 37);
            this.comboBoxLOTGuncelle.TabIndex = 17;
            // 
            // textBoxGuncellenmisDeger
            // 
            this.textBoxGuncellenmisDeger.Location = new System.Drawing.Point(197, 148);
            this.textBoxGuncellenmisDeger.Name = "textBoxGuncellenmisDeger";
            this.textBoxGuncellenmisDeger.Size = new System.Drawing.Size(280, 36);
            this.textBoxGuncellenmisDeger.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Yeni Parametre Değeri:";
            // 
            // textBoxLOTGuncelle
            // 
            this.textBoxLOTGuncelle.Location = new System.Drawing.Point(76, 44);
            this.textBoxLOTGuncelle.Name = "textBoxLOTGuncelle";
            this.textBoxLOTGuncelle.Size = new System.Drawing.Size(401, 36);
            this.textBoxLOTGuncelle.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "LOT No:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "Güncellenecek parametre:";
            // 
            // buttonLOTGuncelle
            // 
            this.buttonLOTGuncelle.Location = new System.Drawing.Point(483, 23);
            this.buttonLOTGuncelle.Name = "buttonLOTGuncelle";
            this.buttonLOTGuncelle.Size = new System.Drawing.Size(91, 176);
            this.buttonLOTGuncelle.TabIndex = 0;
            this.buttonLOTGuncelle.Text = "LOT Güncelle";
            this.buttonLOTGuncelle.UseVisualStyleBackColor = true;
            this.buttonLOTGuncelle.Click += new System.EventHandler(this.buttonLOTGuncelle_Click);
            // 
            // FrmLOT
            // 
            this.AcceptButton = this.BtnLotKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOT Sorgulama Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLOT_Load);
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
        private System.Windows.Forms.TextBox textBoxLOTSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button BtnLotKayit;
        private System.Windows.Forms.TextBox textBoxGenislik;
        private System.Windows.Forms.TextBox textBoxTotalMiktar;
        private System.Windows.Forms.TextBox textBoxAgirlik;
        private System.Windows.Forms.TextBox textBoxUzunluk;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.Button buttonLOTSorgu;
        private System.Windows.Forms.Button buttonTumLOTlar;
        private System.Windows.Forms.TextBox textBoxLOTNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLOTKayitSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLOTKayitSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxLOTGuncelle;
        private System.Windows.Forms.TextBox textBoxGuncellenmisDeger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLOTGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonLOTGuncelle;
        private System.Windows.Forms.TextBox textBoxBitisTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSiparisNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxYarnType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIplikcm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxBobinSayisi;
        private System.Windows.Forms.Label label16;
    }
}