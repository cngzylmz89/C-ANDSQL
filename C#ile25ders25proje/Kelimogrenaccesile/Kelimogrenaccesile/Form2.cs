using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices.ComTypes;

namespace Kelimogrenaccesile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CENGİZ\Desktop\c#allproject\C#ile25ders25proje\Kelimogrenaccesile\dbSozluk.accdb");
        int sure, dogru, yanlis;

        void kelime()
        {
            Random rast = new Random();
            int rst = rast.Next(1, 2400);
            string ingilizcekelime;
            string turkcekelime;
            baglanti.Open();
            OleDbCommand kelimegetir = new OleDbCommand("select ingilizce, turkce from sozluk where id=@S1", baglanti);
            kelimegetir.Parameters.AddWithValue("@S1", rst);
            OleDbDataReader rd = kelimegetir.ExecuteReader();
            while (rd.Read())
            {
                ingilizcekelime = rd[0].ToString();
                turkcekelime = rd[1].ToString();
                label3.Text = turkcekelime;
                lblingilizce.Text = ingilizcekelime;

            }
            baglanti.Close();
        }
        public string adısoyadı;
        private void Form2_Load(object sender, EventArgs e)
        {
            sure = 20;
            lblsure.Text = sure.ToString();
            Form1 fr = new Form1();
            lblyarismaci.Text = adısoyadı.ToString();
            baglanti.Open();
            OleDbCommand komutdy = new OleDbCommand("select DOGRU, YANLIS from KULLANICI WHERE ADISOYADI=@P1", baglanti);
            komutdy.Parameters.AddWithValue("@P1",  lblyarismaci.Text);
            OleDbDataReader rd = komutdy.ExecuteReader();
            while (rd.Read())
            {
                lbldogru.Text = rd[0].ToString();
                lblyanlis.Text = rd[1].ToString();
            }
            baglanti.Close();
        }

        private void txtturkce_TextChanged(object sender, EventArgs e)
        {
            if (txtturkce.Text == label3.Text.ToUpper())
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                kelime();
                sure = 20;
                lblsure.Text = sure.ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sure--;
            lblsure.Text = sure.ToString();
            if(sure==0)
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                sure = 20;
                lblsure.Text = sure.ToString();
                timer1.Stop();
            }
        }
        private void btnbasla_Click(object sender, EventArgs e)
        {
            kelime();
            baglanti.Open();
            OleDbCommand komutkyt = new OleDbCommand("update KULLANICI  set DOGRU=@P1, YANLIS=@P2 WHERE ADISOYADI=@P3", baglanti);
            komutkyt.Parameters.AddWithValue("@P3", adısoyadı);
            komutkyt.Parameters.AddWithValue("@P1", dogru);
            komutkyt.Parameters.AddWithValue("@P2", yanlis);
            
            
            if (btnbasla.Text == "BAŞLA")
            {
                
                btnbasla.Text = "DURDUR";
                timer1.Start();
            }

            else if (btnbasla.Text == "DURDUR")
            {
                

                btnbasla.Text = "BAŞLA";
                timer1.Stop();
                komutkyt.ExecuteNonQuery();

            }
            baglanti.Close();

        }

    }
}
