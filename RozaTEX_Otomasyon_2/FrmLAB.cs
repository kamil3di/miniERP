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
    public partial class FrmLAB : Form
    {
        public FrmLAB()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmLAB_Load(object sender, EventArgs e)
        {
            // Column boyutunu ayarlama
            dataGridViewLABSonuclari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridViewLABSonuclari.RowTemplate.Height = 40;
        }

        private void buttonLABKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO LABValues_List (ProductLotNo,BobinNo,FirstLABValue,SecondLABValue,ThirdLABValue,FourthLABValue,FifthLABValue) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBoxLOTNo.Text);
                komut.Parameters.AddWithValue("@p2", textBoxBobinNo.Text);
                komut.Parameters.AddWithValue("@p3", textBoxDeger1.Text);
                komut.Parameters.AddWithValue("@p4", textBoxDeger2.Text);
                komut.Parameters.AddWithValue("@p5", textBoxDeger3.Text);
                komut.Parameters.AddWithValue("@p6", textBoxDeger4.Text);
                komut.Parameters.AddWithValue("@p7", textBoxDeger5.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                buttonLABSonuclari.PerformClick();
                textBoxLOTNo.Text = String.Empty;
                textBoxBobinNo.Text = String.Empty;
                textBoxDeger1.Text = String.Empty;
                textBoxDeger2.Text = String.Empty;
                textBoxDeger3.Text = String.Empty;
                textBoxDeger4.Text = String.Empty;
                textBoxDeger5.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir değer giriniz!");
            }

        }

        private void buttonLABSonuclari_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LABValues_List ORDER BY ProductLotNo DESC,BobinNo ASC",bgl.baglanti());
            da.Fill(dt);    
            dataGridViewLABSonuclari.DataSource = dt;   
        }

        private void buttonLABDegerSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM LABValues_List WHERE ProductLotNo=" + textBoxSilLOTNo.Text + " AND BobinNo=" + textBoxSilBobinNo.Text,bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            buttonLABSonuclari.PerformClick();
        }

        private void textBoxBobinNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLABGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE LABValues_List SET [" + comboBoxGuncelParametre.Text + "] =@p2 " + " WHERE ProductLotNo=" + textBoxGuncelLOT.Text + " AND BobinNo=" +textBoxGuncelBOBIN.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBoxGuncelDeger.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textBoxGuncelDeger.Text = String.Empty;
            comboBoxGuncelParametre.Text = String.Empty;
            textBoxGuncelLOT.Text = String.Empty;
            textBoxGuncelBOBIN.Text = String.Empty;
            buttonLABSonuclari.PerformClick();
        }
    }
}
