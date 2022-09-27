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
    public partial class FrmTuketim : Form
    {
        public FrmTuketim()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Consumption_List ORDER BY ConsumptionDate",bgl.baglanti());
            da.Fill(dt);    
            dataGridViewTuketimDegerleri.DataSource = dt;
        }

        private void FrmTuketim_Load(object sender, EventArgs e)
        {
            // Column boyutunu ayarlama
            dataGridViewTuketimDegerleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridViewTuketimDegerleri.RowTemplate.Height = 40;

            // Column boyutunu ayarlama
            dataGridViewSicaklik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridViewSicaklik.RowTemplate.Height = 40;
        }

        private void buttonBugununTarihi_Click(object sender, EventArgs e)
        {
            textBoxTüketimTarih.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void buttonTuketimKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Consumption_List (ConsumptionDate,ConsumptionTime,ProductName,ElectricityValue,GasValue) VALUES (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBoxTüketimTarih.Text);
            komut.Parameters.AddWithValue("@p2",textBoxTüketimSaat.Text);
            komut.Parameters.AddWithValue("@p3",textBoxUrunAdı.Text);
            komut.Parameters.AddWithValue("@p4",textBoxElektrikSayac.Text);
            komut.Parameters.AddWithValue("@p5",textBoxDogalgazSayac.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            button6.PerformClick();
        }

        private void buttonVeriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Consumption_List WHERE ConsumptionDate='" + textBoxTüketimTarih.Text + "'",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            button6.PerformClick();
        }

        private void buttonSıcaklıkTümRaporuGöster_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Heat_List ORDER BY HeatDate", bgl.baglanti());
            da.Fill(dt);
            dataGridViewSicaklik.DataSource = dt;
        }

        private void buttonBugununTarihi2_Click(object sender, EventArgs e)
        {
            textBoxSıcaklıkTarih.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void buttonSıcaklıkKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Heat_List (HeatDate,PrimerHeatValue,SeconderHeatValue) VALUES (@p1,@p2,@p3)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxSıcaklıkTarih.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSıcaklıkDegeri.Text);
            komut.Parameters.AddWithValue("@p3", textBoxSeconderSıcaklıkDegeri.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonSıcaklıkTümRaporuGöster.PerformClick();
        }

        private void buttonSıcaklıkSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Heat_List WHERE HeatDate='" + textBoxSıcaklıkTarih.Text + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonSıcaklıkTümRaporuGöster.PerformClick();
        }
    }
}
