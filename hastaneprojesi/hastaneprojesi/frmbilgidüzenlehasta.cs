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
    public partial class frmbilgidüzenlehasta : Form
    {
        public frmbilgidüzenlehasta()
        {
            InitializeComponent();
        }

        sqlbaglan bgl = new sqlbaglan();
        public string tcno;
        private void frmbilgidüzenlehasta_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Hastalar where HastaTC=" + tcno, bgl.baglanti());
            SqlDataReader rd = komut1.ExecuteReader();
            while (rd.Read())
            {
                txtad.Text = rd[1].ToString();
                txtsoyad.Text = rd[2].ToString();
                msktc.Text = rd[3].ToString();
                msktelefon.Text = rd[4].ToString();
                if (rd[6].ToString() == "True")
                {
                    rdyerkek.Checked = true;
                }
                else
                {
                    rdykiz.Checked = true;
                }
                msksifre.Text = rd[5].ToString();
            }
            bgl.baglanti().Close();
        }
        private void rdyerkek_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";

        }

        private void rdykiz_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void lnklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set Hastaad=@a1, Hastasoyad=@a2, Hastatelefon=@a4, Hastasifre=@a5, Hastacinsiyet=@a6   where HastaTC=" + tcno, bgl.baglanti());
            komut2.Parameters.AddWithValue("@a1", txtad.Text);
            komut2.Parameters.AddWithValue("@a2", txtsoyad);
            komut2.Parameters.AddWithValue("@a4", msktelefon.Text);
            komut2.Parameters.AddWithValue("@a5", msksifre.Text);
            komut2.Parameters.AddWithValue("@a6", label8.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        


        
    }
}
