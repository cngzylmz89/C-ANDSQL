using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etut_Merkezi
{
    internal class connect
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=EtutTest;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
