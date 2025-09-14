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
    public partial class frmhastakayit : Form
    {

        sqlbaglan bgl = new sqlbaglan();
        public frmhastakayit()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lnklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmhastagiris frmhstgrs = new frmhastagiris();
            frmhstgrs.Show();
            this.Hide();
            SqlCommand kmtkayit = new SqlCommand("insert into Tbl_Hastalar (Hastaad, Hastasoyad, HastaTC, Hastatelefon, Hastasifre, Hastacinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            kmtkayit.Parameters.AddWithValue("@p1", txtad.Text);
            kmtkayit.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kmtkayit.Parameters.AddWithValue("@p3", msktc.Text);
            kmtkayit.Parameters.AddWithValue("@p4", msktelefon.Text);
            kmtkayit.Parameters.AddWithValue("@p5", msksifre.Text);
            kmtkayit.Parameters.AddWithValue("@p6", lblcinsiyet.Text);
            if (txtad.Text != "" && txtsoyad.Text != "" && msktc.Text != "" && msktelefon.Text != "" && lblcinsiyet.Text != "" && msksifre.Text != "")
            {
                kmtkayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt yapıldı" + "Şifreniz:"+ " "+msksifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void rdyerkek_CheckedChanged(object sender, EventArgs e)
        {
            lblcinsiyet.Text = "True";
        }

        private void rdykiz_CheckedChanged(object sender, EventArgs e)
        {
            lblcinsiyet.Text = "False";
        }
    }
}
