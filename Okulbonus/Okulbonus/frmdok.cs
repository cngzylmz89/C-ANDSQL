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

namespace Okulbonus
{
    public partial class frmdok : Form
    {
        public frmdok()
        {
            InitializeComponent();
        }
        public string ogrenci;
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=OKULBONUS;Integrated Security=True");
        private void frmdok_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut2 = new SqlCommand("select OGRAD, OGRSOYAD from TBLOGRENCILER where OGRID=@a1", bgl);
            komut2.Parameters.AddWithValue("@a1", ogrenci);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                this.Text = rd2[0].ToString()+" "+rd2[1].ToString();
            }

            bgl.Close();
            label1.Text=ogrenci;
            
            SqlCommand komut1 = new SqlCommand("select DERSAD, NOTID, SINAV1, SINAV2, SINAV3, PROJE, ORTALAMA from TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID=TBLDERSLER.DERSID where OGRID=@P1", bgl);
            komut1.Parameters.AddWithValue("@P1", label1.Text);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
    }
}
