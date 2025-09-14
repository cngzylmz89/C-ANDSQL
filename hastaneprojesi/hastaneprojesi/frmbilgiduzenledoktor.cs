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
    public partial class frmbilgiduzenledoktor : Form
    {
        public frmbilgiduzenledoktor()
        {
            InitializeComponent();
        }

        private void msksifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        sqlbaglan bgl = new sqlbaglan();
        public string doktoruntc;
        private void frmbilgiduzenledoktor_Load(object sender, EventArgs e)
        {
            frmdoktordetay frm = new frmdoktordetay();
            msktcdoktor.Text = doktoruntc;

            SqlCommand komut1 = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC='" + doktoruntc + "'", bgl.baglanti());
            SqlDataReader rd1 = komut1.ExecuteReader();
            while (rd1.Read())
            {
                txtadoktorad.Text = rd1[1].ToString();
                txtsoyaddoktor.Text = rd1[2].ToString();
                cmbbrans.Text = rd1[3].ToString();
                msksifredoktor.Text = rd1[5].ToString();
            }
            SqlCommand komut2 = new SqlCommand("select Bransad from Tbl_Branslar", bgl.baglanti());
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                cmbbrans.Items.Add(rd2[0]);
            }
        }

        private void lnklblbilgiduzelt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Tbl_Doktorlar set Doktorad=@a1, Doktorsoyad=@a2, DoktorBrans=@a3, DoktorSifre= @a4 where DoktorTC='" + doktoruntc + "'", bgl.baglanti());
            komut3.Parameters.AddWithValue("@a1", txtadoktorad.Text);
            komut3.Parameters.AddWithValue("@a2", txtsoyaddoktor.Text);
            komut3.Parameters.AddWithValue("@a3", cmbbrans.Text);
            komut3.Parameters.AddWithValue("@a4", msksifredoktor.Text);
            if (msktcdoktor.Text != "")
            {
                komut3.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("TC kimlik numarası yoktur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }

        

        
    }
}
