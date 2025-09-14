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
    public partial class frmsekreterkayit : Form
    {
        public frmsekreterkayit()
        {
            InitializeComponent();
        }
        sqlbaglan bgl = new sqlbaglan();

        private void lnklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SqlCommand kayit = new SqlCommand("insert into Tbl_sekreter (SekreterAd, SekreterSoyad, SekreterTC, SekreterSifre) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            kayit.Parameters.AddWithValue("@p1", txtsekreterad.Text);
            kayit.Parameters.AddWithValue("@p2", txtsekretersoyad.Text);
            kayit.Parameters.AddWithValue("@p3", msksekretertc.Text);
            kayit.Parameters.AddWithValue("@p4", msksekretersifre.Text);
            SqlCommand kontrol = new SqlCommand("select * from Tbl_sekreter  where SekreterTC=@k1", bgl.baglanti());
            kontrol.Parameters.AddWithValue("@k1", msksekretertc.Text);
            SqlDataReader rdr = kontrol.ExecuteReader();
            if(msksekretertc.Text=="" || txtsekreterad.Text=="" || txtsekretersoyad.Text=="" || txtsekretersoyad.Text=="" )
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz", "Eksik Bilgi");
                txtsekreterad.Focus();
            }
            else
            {
                if (rdr.Read())
                {
                    MessageBox.Show("Kullanıcı zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsekreterad.Text = "";
                    txtsekretersoyad.Text = "";
                    msksekretertc.Text = "";
                    msksekretersifre.Text = "";
                    txtsekreterad.Focus();
                }
                else
                {
                    kayit.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Kaydedildi", "Bilgi", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                }
            }
           
            
           
            bgl.baglanti().Close();
           
            

        }
    }
}
