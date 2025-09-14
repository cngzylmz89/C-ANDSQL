using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MESAJPROGRAMI
{
    internal class baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection bgl =new SqlConnection(@"Data Source=.;Initial Catalog=DBMAILSISTEMI;Integrated Security=True;Encrypt=False");
            bgl.Open();
            return bgl;
        }
    }
}
