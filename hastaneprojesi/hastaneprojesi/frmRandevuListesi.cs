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

namespace hastaneprojesi
{
    public partial class frmRandevuListesi : Form
    {
        public frmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglan bgl = new sqlbaglan();
        public string hastanintc;
        public string sektcc;
        public void yenile()
        {
            if (hastanintc != "")
            {
                DataTable dt1 = new DataTable();
                SqlCommand komut1 = new SqlCommand("select * from Tbl_Randevular where HastaTC='" + hastanintc+"'", bgl.baglanti());
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = komut1;
                da1.Fill(dt1);
                dataGridViewlisteleme.DataSource = dt1;
                bgl.baglanti().Close();
            }

            else
            {
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Randevular", bgl.baglanti());
                da2.Fill(dt2);
                dataGridViewlisteleme.DataSource = dt2;
            }
        }
        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {
            yenile();

        }

        
        

       
    }
}
