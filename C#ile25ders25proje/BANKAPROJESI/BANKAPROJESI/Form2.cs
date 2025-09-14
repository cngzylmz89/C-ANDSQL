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

namespace BANKAPROJESI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void bakiyelistele()
        {
            SqlCommand komutbakiye = new SqlCommand("select BAKIYE FROM TBLHESAP WHERE HESAPNO=@A", baglan.baglanti());
            komutbakiye.Parameters.AddWithValue("@A", sifresiz(lblhesapno.Text));
            SqlDataReader rd2 = komutbakiye.ExecuteReader();
            while (rd2.Read())
            {
                lblbakiye.Text = rd2[0].ToString();
            }
            baglan.baglanti().Close();
        }
        public string hesapno;
        connect baglan = new connect();

       public string Sifreli(string hesap)
        {

            byte[] adsifrele = ASCIIEncoding.ASCII.GetBytes(hesap);
            string adsifreli = Convert.ToBase64String(adsifrele);
            return adsifreli;
            
        }

        public string sifresiz(string hesapsifresiz)
        {

            byte[] adsifrecozum = Convert.FromBase64String(hesapsifresiz);
            string adcozum = ASCIIEncoding.ASCII.GetString(adsifrecozum);
            return adcozum;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = Sifreli(hesapno);
            //string paramethesapno = lblhesapno.Text;

            SqlCommand komutgetir = new SqlCommand("select LEFT(AD,1)+'. '+SOYAD,TELEFON, TC FROM TBLKISILER  WHERE HESAPNO=@P", baglan.baglanti());
            komutgetir.Parameters.AddWithValue("@P", sifresiz(lblhesapno.Text));
            SqlDataReader rd = komutgetir.ExecuteReader();
            while (rd.Read())
            {
                
                lbladsoyad.Text = rd[0].ToString();
                lbltelefon.Text = rd[1].ToString();
                lbltckn.Text = rd[2].ToString();
               
            }
            baglan.baglanti().Close();

            bakiyelistele();

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            //bakiye artır
            SqlCommand bakiyeartir = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@P2 WHERE HESAPNO=@P3", baglan.baglanti());
            bakiyeartir.Parameters.AddWithValue("@P2", decimal.Parse(txttutar.Text));
            bakiyeartir.Parameters.AddWithValue("@P3", mskhesapno.Text);
            DialogResult result1 = MessageBox.Show(txttutar.Text + " tutarında para " + mskhesapno.Text + " hesabına gönderilecek. Onaylıyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mskhesapno.Text != "" )
            {
                if(result1 == DialogResult.Yes)
                bakiyeartir.ExecuteNonQuery();
                MessageBox.Show(txttutar.Text + " tutarında havale" + " " + mskhesapno.Text + " hesap numarasına gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesap numarası giriniz", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            baglan.baglanti().Close();

            //bakiye azalt

            SqlCommand bakiyeazalt = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@E WHERE HESAPNO=@H1", baglan.baglanti());
            bakiyeazalt.Parameters.AddWithValue("@H1", sifresiz(lblhesapno.Text));
            bakiyeazalt.Parameters.AddWithValue("@E", decimal.Parse(txttutar.Text));
            bakiyeazalt.ExecuteNonQuery();
            baglan.baglanti().Close();
            bakiyelistele();
            //işlem kaydet
            SqlCommand hareket = new SqlCommand("insert into TBLHAREKET (GONDEREN, ALICI, TUTAR) VALUES(@M1, @M2, @M3)", baglan.baglanti());
            hareket.Parameters.AddWithValue("@M1", sifresiz(lblhesapno.Text));
            hareket.Parameters.AddWithValue("@M2", mskhesapno.Text);
            hareket.Parameters.AddWithValue("@M3", txttutar.Text);
            hareket.ExecuteNonQuery();

            
        }

        private void btnhareketler_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();

            fr.hesap = int.Parse(sifresiz( lblhesapno.Text));
            fr.Show();
        }
    }
}
