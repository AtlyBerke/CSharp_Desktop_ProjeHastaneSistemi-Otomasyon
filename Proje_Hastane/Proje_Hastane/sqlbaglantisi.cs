using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public SqlConnection bağlanti()
        {
            SqlConnection bağlan=new SqlConnection("Data Source=DESKTOP-LC55U5G\\SQLEXPRESS;Initial Catalog=OtomasyonProje;Integrated Security=True");
            bağlan.Open();
            return bağlan;
        }

    }
}
