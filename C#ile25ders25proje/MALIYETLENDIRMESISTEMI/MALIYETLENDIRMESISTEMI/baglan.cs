using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MALIYETLENDIRMESISTEMI
{
    internal class baglan
    {
        public SqlConnection baglanti ()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=CNGZSLMAYSNR\SQLEXPRESS;Initial Catalog=TESTMALIYET;Integrated Security=True;Encrypt=False");
            bgl.Open();
            return bgl;
        }
    }
}
