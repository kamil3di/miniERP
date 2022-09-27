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
    public partial class FrmLOT : Form
    {
        public FrmLOT()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmLOT_Load(object sender, EventArgs e)
        {
            // Column boyutunu ayarlama
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridView1.RowTemplate.Height = 40;

            // Güncellenecek değer comboBox'unu doldurma
            SqlCommand komut = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'LOT_List' ORDER BY ORDINAL_POSITION", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxLOTGuncelle.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void BtnLotKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO LOT_List (StartDate,EndDate,ProductCode,OrderNo,ProductLotNo,YarnType,[Yarn/cm],Length,NumberOfBobin,[Weight(gr/m2)],[Width(mm)],[TotalAmount(m2)]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p5", textBoxLOTNo.Text);
            komut.Parameters.AddWithValue("@p1", textBoxTarih.Text);
            komut.Parameters.AddWithValue("@p2", textBoxBitisTarih.Text);
            komut.Parameters.AddWithValue("@p3", textBoxUrunKodu.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSiparisNo.Text);
            komut.Parameters.AddWithValue("@p6", textBoxYarnType.Text);
            komut.Parameters.AddWithValue("@p7", textBoxIplikcm.Text);
            komut.Parameters.AddWithValue("@p8", textBoxUzunluk.Text);
            komut.Parameters.AddWithValue("@p9", textBoxBobinSayisi.Text);
            komut.Parameters.AddWithValue("@p10", textBoxAgirlik.Text);
            komut.Parameters.AddWithValue("@p11", textBoxGenislik.Text);
            komut.Parameters.AddWithValue("@p12", textBoxTotalMiktar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonTumLOTlar.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOT_List WHERE ProductLotNo=" + textBoxLOTSorgu.Text, bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                textBoxLOTSorgu.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir değer giriniz!");
            }
        }

        private void buttonTumLOTlar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOT_List ORDER BY ProductLotNo DESC", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonLOTKayitSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("DELETE FROM LOT_List WHERE ProductLotNo=" + textBoxLOTKayitSil.Text, bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                buttonTumLOTlar.PerformClick();
                MessageBox.Show(textBoxLOTKayitSil.Text + " numaralı LOT kaydı silindi.");
                textBoxLOTKayitSil.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir değer giriniz!");
            }

        }

        private void buttonLOTGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE LOT_List SET [" + comboBoxLOTGuncelle.Text + "] =@p2 " + " WHERE ProductLotNo=" + textBoxLOTGuncelle.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBoxGuncellenmisDeger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textBoxLOTGuncelle.Text = String.Empty;
            comboBoxLOTGuncelle.Text = String.Empty;
            textBoxGuncellenmisDeger.Text = String.Empty;
            buttonTumLOTlar.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
