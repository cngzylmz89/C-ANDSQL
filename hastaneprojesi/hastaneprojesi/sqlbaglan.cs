using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastaneprojesi
{
    class sqlbaglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection("Data Source=MUDYARD\\SQLEXPRESS;Initial Catalog=hastanebilgisistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
