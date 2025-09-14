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
using System.Xml.Linq;

namespace MESAJPROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        baglanti connect = new baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komutoku = new SqlCommand("select NUMARA, SIFRE FROM TBLKISILER WHERE NUMARA=@p1 and SIFRE=@p2", connect.baglan());
            komutoku.Parameters.AddWithValue("@p1", msknum.Text);
            komutoku.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader rd = komutoku.ExecuteReader();
            if (rd.Read())
            {
                Form2 fr = new Form2();
                fr.numara=msknum.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connect.baglan().Close();

        }
    }
}
