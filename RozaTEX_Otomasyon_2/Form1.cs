using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozaTEX_Otomasyon_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string LOTNo;
        public static string BobinNo;

        private void BtnLOTBilgisi_Click(object sender, EventArgs e)
        {
            FrmLOT fr = new FrmLOT();
            fr.Show();
        }

        private void BtnUretimTakip_Click(object sender, EventArgs e)
        {
            FrmUretim fr = new FrmUretim(); 
            fr.Show();
        }

        private void BtnSiparisTakip_Click(object sender, EventArgs e)
        {
            FrmSiparis fr = new FrmSiparis();
            fr.Show();
        }

        private void BtnTüketimDegerleri_Click(object sender, EventArgs e)
        {
            FrmTuketim fr = new FrmTuketim();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLOTSorgu.Text != "" || textBoxBobinNo.Text != "")
            {
                LOTNo = textBoxLOTSorgu.Text;
                BobinNo = textBoxBobinNo.Text;

                FrmUretimFormu frmUretimForm = new FrmUretimFormu();
                frmUretimForm.Show();
                textBoxLOTSorgu.Text = String.Empty;
                textBoxBobinNo.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("LOT değeri ve bobin no boş olamaz!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLAB_Click(object sender, EventArgs e)
        {
            FrmLAB frmLAB = new FrmLAB();
            frmLAB.Show();
        }

        private void textBoxLOTSorgu_Validating(object sender, CancelEventArgs e)
        {
        }

    }
}
