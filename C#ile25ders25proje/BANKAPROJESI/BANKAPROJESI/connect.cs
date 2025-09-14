using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BANKAPROJESI
{
    internal class connect
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=BANKAMATIK;Integrated Security=True;Encrypt=False");
            bgl.Open();
            return bgl;

        }
        
    }
}
