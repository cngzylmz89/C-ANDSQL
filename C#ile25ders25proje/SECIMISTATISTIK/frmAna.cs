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
using System.Data;
using System.Runtime.InteropServices;


namespace SECIMISTATISTIK
{
    public partial class frmAna: Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=DBSECIMPROJE;Integrated Security=True;Encrypt=False");
        private void btnoygiris_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values(@P1, @P2, @P3, @P4, @P5, @P6)", bgl);
            komutekle.Parameters.AddWithValue("@P1", txtilcead.Text);
            komutekle.Parameters.AddWithValue("@P2", short.Parse(txtaparti.Text));
            komutekle.Parameters.AddWithValue("@P3", short.Parse(txtbparti.Text)); komutekle.Parameters.AddWithValue("@P4", short.Parse(txtcparti.Text)); komutekle.Parameters.AddWithValue("@P5", short.Parse(txtdparti.Text));
            komutekle.Parameters.AddWithValue("@P6", short.Parse(txteparti.Text));

            if (komutekle.Connection.State != ConnectionState.Open)
            {
                komutekle.Connection.Open();
                komutekle.ExecuteNonQuery();
            }
            MessageBox.Show("Kayıt eklendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.Close();
            



        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            frmGrafikler frm = new frmGrafikler();
            frm.Show();
            this.Hide();
        }
    }
}
