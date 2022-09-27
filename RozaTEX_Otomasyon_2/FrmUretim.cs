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

namespace RozaTEX_Otomasyon_2
{
    public partial class FrmUretim : Form
    {
        public FrmUretim()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();


        private void Combo_Doldurma(ComboBox comboAdi)
        {
            // Güncellenecek tarih comboboxunu doldurma
            SqlCommand komut = new SqlCommand("SELECT ProductDate FROM Production_List", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboAdi.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }


        private void FrmUretim_Load(object sender, EventArgs e)
        {
            // Column boyutunu ayarlama
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridView1.RowTemplate.Height = 40;

            // ComboBox'ları doldurma işlemi
            Combo_Doldurma(comboBoxSilinecekTarih);
            Combo_Doldurma(comboBoxGuncellemeTarih);
            Combo_Doldurma(comboBoxSorguTarih);

            // Güncellenecek değer comboBox'unu doldurma
            SqlCommand komut = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Production_List' ORDER BY ORDINAL_POSITION", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxGuncellemeAlan.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void buttonTumUretimiGoruntule_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Production_List", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonUretimKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Production_List (ProductDate,ProductCode,ProductLotNo,[Width(mm)],[ProductAmount(08/16)(mt)],[ProductAmount(16/24)(mt)],[ProductAmount(24/08)(mt)]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxUretimTarih.Text);
            komut.Parameters.AddWithValue("@p2", textBoxUretimMusteriKodu.Text);
            komut.Parameters.AddWithValue("@p3", textBoxUretimLOTNo.Text);
            komut.Parameters.AddWithValue("@p4", textBoxUretimUrunEni.Text);
            komut.Parameters.AddWithValue("@p5", textBox816Vardiyasi.Text);
            komut.Parameters.AddWithValue("@p6", textBox1624Vardiyasi.Text);
            komut.Parameters.AddWithValue("@p7", textBox248Vardiyasi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            //Silinecek Tarih combo boxunu yenileme
            comboBoxSilinecekTarih.Items.Clear();
            Combo_Doldurma(comboBoxSilinecekTarih);



            //Guncellenecek Tarih combo boxunu yenileme
            comboBoxGuncellemeTarih.Items.Clear();
            Combo_Doldurma(comboBoxGuncellemeTarih);


            //Sorgulanacak Tarih combo boxunu yenileme
            comboBoxSorguTarih.Items.Clear();
            Combo_Doldurma(comboBoxSorguTarih);


            buttonTumUretimiGoruntule.PerformClick();
        }

        private void buttonUretimSil_Click(object sender, EventArgs e)
        {
            DateTime unDateValue = Convert.ToDateTime(comboBoxSilinecekTarih.Text);
            string dateValue = unDateValue.ToString("MM/dd/yyyy");
            SqlCommand komut = new SqlCommand("DELETE FROM Production_List WHERE ProductDate='" + dateValue + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonTumUretimiGoruntule.PerformClick();
            comboBoxSilinecekTarih.Text = string.Empty;
        }

        private void buttonUrunGuncelle_Click(object sender, EventArgs e)
        {
            DateTime unDateValue = Convert.ToDateTime(comboBoxGuncellemeTarih.Text);
            string dateValue = unDateValue.ToString("MM/dd/yyyy");
            SqlCommand komut = new SqlCommand("UPDATE Production_List SET [" + comboBoxGuncellemeAlan.Text + "] = @p2 " + " WHERE ProductDate='" + dateValue + "'",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBoxGuncellemeDeger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonTumUretimiGoruntule.PerformClick();

            //Yazılan alanları temizleme
            comboBoxGuncellemeTarih.Text = string.Empty;
            textBoxGuncellemeDeger.Text = string.Empty;
            comboBoxGuncellemeAlan.Text = string.Empty;

            //Guncellenecek Tarih combo boxunu yenileme
            comboBoxGuncellemeTarih.Items.Clear();
            Combo_Doldurma(comboBoxGuncellemeTarih);

            //Silinecek Tarih combo boxunu yenileme
            comboBoxSilinecekTarih.Items.Clear();
            Combo_Doldurma(comboBoxSilinecekTarih);

            //Sorgulanacak Tarih combo boxunu yenileme
            comboBoxSorguTarih.Items.Clear();
            Combo_Doldurma(comboBoxSorguTarih);
        }

        private void buttonUretimGoruntule_Click(object sender, EventArgs e)
        {
            DateTime unDateValue = Convert.ToDateTime(comboBoxSorguTarih.Text);
            string dateValue = unDateValue.ToString("MM/dd/yyyy");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Production_List WHERE ProductDate='" + dateValue + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
