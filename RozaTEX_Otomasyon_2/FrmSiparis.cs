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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            // Column boyutunu ayarlama
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // Row boyutunu ayarlama
            dataGridView1.RowTemplate.Height = 40;


            SqlCommand komut = new SqlCommand("SELECT convert(varchar, ArrivingDate, 109) FROM Order_List", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            IList<string> listName = new List<string>();
            while (dr.Read())
            {
                listName.Add(dr[0].ToString());
            }
            listName = listName.Distinct().ToList();
            comboBoxAylar.DataSource = listName;
            bgl.baglanti().Close();
        }

        private void comboBoxAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Convert.ToDateTime(comboBoxAylar.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Order_List WHERE ArrivingDate='" + comboBoxAylar.Text + "'", bgl.baglanti());
            // LIKE '" + comboBoxAylar.Text + "%'"
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
