using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

// Data Source=FULLINDIR-CO;Initial Catalog=RozaTEX;Integrated Security=True

namespace RozaTEX_Otomasyon_2
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ROZATEX;Initial Catalog=RozaTEX;Integrated Security=True");
            baglan.Open();  
            return baglan;  
        }
    }
}
