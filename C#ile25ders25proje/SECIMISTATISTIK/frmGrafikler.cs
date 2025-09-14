using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SECIMISTATISTIK
{
    public partial class frmGrafikler: Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=DBSECIMPROJE;Integrated Security=True;Encrypt=False");
        private void frmGrafikler_Load(object sender, EventArgs e)
        {

            bgl.Open();
            SqlCommand komut1 = new SqlCommand("select ILCEAD from TBLILCE", bgl);
            SqlDataReader dr = komut1.ExecuteReader();
            
            while (dr.Read())
            {
                cmbilce.Items.Add(dr[0].ToString());
            }
            bgl.Close();
        }

        private void cmbilce_TextChanged(object sender, EventArgs e)
        {
            chart1.Series["OYLAR"].Points.Clear();//combox her değiştiğinde önce temizle sonra grafiği doldur
            
            bgl.Open();
            SqlCommand komutgrafik = new SqlCommand("select  APARTI, BPARTI, CPARTI, DPARTI, EPARTI from TBLILCE where ILCEAD=@P1", bgl);
            komutgrafik.Parameters.AddWithValue("@P1", cmbilce.Text);
            SqlDataReader dr = komutgrafik.ExecuteReader();

            while (dr.Read())
            {
                chart1.Series["OYLAR"].Points.AddXY("APARTİ", dr[0].ToString());
                chart1.Series["OYLAR"].Points.AddXY("BPARTİ", dr[1].ToString());
                chart1.Series["OYLAR"].Points.AddXY("CPARTİ", dr[2].ToString());
                chart1.Series["OYLAR"].Points.AddXY("DPARTİ", dr[3].ToString());
                chart1.Series["OYLAR"].Points.AddXY("EPARTİ", dr[4].ToString());

                progressBar1.Value = short.Parse(dr[0].ToString());
                progressBar2.Value = short.Parse(dr[1].ToString());
                progressBar3.Value = short.Parse(dr[2].ToString());
                progressBar4.Value = short.Parse(dr[3].ToString());
                progressBar5.Value = short.Parse(dr[4].ToString());

                lbla.Text = dr[0].ToString();
                lblb.Text = dr[1].ToString();
                lblc.Text = dr[2].ToString();
                lbld.Text = dr[3].ToString();
                lble.Text = dr[4].ToString();



            }
            bgl.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();
            frm.Show();
            this.Close();
        }
    }
}
