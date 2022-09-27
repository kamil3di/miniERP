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
    public partial class FrmUretimFormu : Form
    {
        private string NowDate;

        sqlbaglantisi bgl = new sqlbaglantisi();    

        public FrmUretimFormu()
        {
            InitializeComponent();
            NowDate = DateTime.Now.ToString("dd/MM/yyyy");
        }

    private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        Bitmap bmp = new Bitmap(this.pnl.Width, this.pnl.Height, this.pnl.CreateGraphics());
        this.pnl.DrawToBitmap(bmp, new Rectangle(0, 0, this.pnl.Width, this.pnl.Height));
        RectangleF bounds = e.PageSettings.PrintableArea;
        float factor = ((float)bmp.Height / (float)bmp.Width);
        e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
    }


        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Yazdır!");
        }

        private void FrmUretimFormu_Load(object sender, EventArgs e)
        {
            try
            {
                labelFormOlusturmaTarihi.Text = NowDate;
                labelLOTNo.Text = Form1.LOTNo;
                labelBobinNo.Text = Form1.BobinNo;
                SqlCommand komut = new SqlCommand("SELECT StartDate,EndDate,ProductCode,YarnType,[Yarn/cm],[Weight(gr/m2)],[Width(mm)] FROM LOT_List WHERE ProductLotNo=" + labelLOTNo.Text, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    labelBaslamaTarihi.Text = Convert.ToString(dr[0]);
                    labelBitisTarihi.Text = Convert.ToString(dr[1]);
                    labelUrunKodu.Text = Convert.ToString(dr[2]);
                    labelIplikTipi.Text = Convert.ToString(dr[3]);
                    labelIplikcm.Text = Convert.ToString(dr[4]);
                    labelAgirlik.Text = Convert.ToString(dr[5]);
                    labelGenislik.Text = Convert.ToString(dr[6]);
                }

                SqlCommand komut2 = new SqlCommand("SELECT FirstLABValue,SecondLABValue,ThirdLABValue,FourthLABValue,FifthLABValue,AverageLABValue,FirstThickness,SecondThickness,ThirdThickness,FourthThickness,FifthThickness,AverageThickness FROM LABValues_List WHERE ProductLotNo=" + labelLOTNo.Text + " AND BobinNo=" + labelBobinNo.Text, bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    labelDeger1.Text = Convert.ToString(dr2[0]);
                    labelDeger2.Text = Convert.ToString(dr2[1]);
                    labelDeger3.Text = Convert.ToString(dr2[2]);
                    labelDeger4.Text = Convert.ToString(dr2[3]);
                    labelDeger5.Text = Convert.ToString(dr2[4]);
                    labelOrtalamaDeger.Text = Convert.ToString(dr2[5]);
                    labelKalınlık1.Text = Convert.ToString(dr2[6]);
                    labelKalınlık2.Text = Convert.ToString(dr2[7]);
                    labelKalınlık3.Text = Convert.ToString(dr2[8]);
                    labelKalınlık4.Text = Convert.ToString(dr2[9]);
                    labelKalınlık5.Text = Convert.ToString(dr2[10]);
                    labelKalınlıkOrtalama.Text = Convert.ToString(dr2[11]);
                }

                SqlCommand komut3 = new SqlCommand("SELECT Recete_List.* FROM LABValues_List JOIN Recete_List ON LABValues_List.ReceteName = Recete_List.ReceteAdı WHERE LABValues_List.ProductLotNo=" + labelLOTNo.Text + " AND LABValues_List.BobinNo=" + labelBobinNo.Text, bgl.baglanti());
                SqlDataReader dr3 = komut3.ExecuteReader();
                if (dr3.Read())
                {
                    labelReceteAdi.Text = Convert.ToString(dr3[0]);
                    labelTarakTipi.Text = Convert.ToString(dr3[1]);
                    labelKimyasalTuru.Text = Convert.ToString(dr3[2]);
                    labelKimyasalMarkasi.Text = Convert.ToString(dr3[3]);
                    labelKimyasalOrani.Text = Convert.ToString(dr3[4]);
                    labelYukariRakkasGerginlik.Text = Convert.ToString(dr3[5]);
                    labelAsagiRakkasGerginlik.Text = Convert.ToString(dr3[6]);
                    labelBirincilDevre.Text = Convert.ToString(dr3[7]);
                    labelTamburluKurutucu1.Text = Convert.ToString(dr3[8]);
                    labelTamburluKurutucu2.Text = Convert.ToString(dr3[9]);
                    labelHedefHizPotans.Text = Convert.ToString(dr3[10]);
                    labelSıkıstırmaSilindiri.Text = Convert.ToString(dr3[11]);
                    labelHedefAtki.Text = Convert.ToString(dr3[12]);
                    labelOmegaCekmeMomenti.Text = Convert.ToString(dr3[13]);
                    labelTamburlu1Moment.Text = Convert.ToString(dr3[14]);
                    labelTamburlu2Moment.Text = Convert.ToString(dr3[15]);
                    labelSıkıstırmaSilindirMoment.Text = Convert.ToString(dr3[16]);
                    labelDalgıcSilindirMoment.Text = Convert.ToString(dr3[17]);
                    labelSolBeslemeCikisMoment.Text = Convert.ToString(dr3[18]);
                    labelSolBeslemeGirisMoment.Text = Convert.ToString(dr3[19]);
                    labelSagBeslemeCikisMoment.Text = Convert.ToString(dr3[20]);
                    labelSagBeslemeGirisMoment.Text = Convert.ToString(dr3[21]);
                    labelCaglikYukarıMoment.Text = Convert.ToString(dr3[22]);
                    labelCaglikAsagiMoment.Text = Convert.ToString(dr3[23]);
                    labelOmegaCekmeHiz.Text = Convert.ToString(dr3[24]);
                    labelTamburlu1Hiz.Text = Convert.ToString(dr3[25]);
                    labelTamburlu2Hiz.Text = Convert.ToString(dr3[26]);
                    labelSıkıstırmaSilindirHiz.Text = Convert.ToString(dr3[27]);
                    labelDalgicSilindirHiz.Text = Convert.ToString(dr3[28]);
                    labelSolBeslemeCikisHiz.Text = Convert.ToString(dr3[29]);
                    labelSolBeslemeGirisHiz.Text = Convert.ToString(dr3[30]);
                    labelSagBeslemeCikisHiz.Text = Convert.ToString(dr3[31]);
                    labelSagBeslemeGirisHiz.Text = Convert.ToString(dr3[32]);
                    labelCaglikYukarıHiz.Text = Convert.ToString(dr3[33]);
                    labelCaglikAsagiHiz.Text = Convert.ToString(dr3[34]);
                    labelInceBezUretimi.Text = Convert.ToString(dr3[35]);
                    labelCozguUstIplıkGerginligi.Text = Convert.ToString(dr3[36]);
                    labelUstRakkasdakiIplikSayisi.Text = Convert.ToString(dr3[37]);
                    labelCozguAltIplıkGerginligi.Text = Convert.ToString(dr3[38]);
                    labelAltRakkasdakiIplikSayisi.Text = Convert.ToString(dr3[39]);
                    labelToleransSıcaklık.Text = Convert.ToString(dr3[40]);
                    labelYapıstırıcıSeviye.Text = Convert.ToString(dr3[41]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!");                   
         }

        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                doc.Print();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
