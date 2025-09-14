using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKAPROJESI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        BANKAMATIKEntities2 db = new BANKAMATIKEntities2();
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
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if(txtad.Text!=""&& txtsoyad.Text != "" && mskhesapno.Text != "" && msktc.Text != "" && msktelefon.Text != "" && txtsifre.Text != "")
            {
                var sorgu = (from x in db.TBLKISILER where x.HESAPNO != int.Parse(mskhesapno.Text) && x.TC != msktc.Text && x.TELEFON != msktelefon.Text select x);

                if (sorgu.Any())
                {
                    try
                    {
                        
                        TBLKISILER T = new TBLKISILER();
                        T.AD = txtad.Text;
                        T.SOYAD = txtsoyad.Text;
                        T.TC = Sifreli(msktc.Text);
                        T.HESAPNO = int.Parse(mskhesapno.Text);
                        T.TELEFON = Sifreli(msktelefon.Text);
                        T.SIFRE = txtsifre.Text;
                        db.TBLKISILER.Add(T);
                        db.SaveChanges();
                        MessageBox.Show(mskhesapno.Text + " hesap numaralı kullanıcı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.ToString());
                    }
                        
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydı zaten var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen ilgili yerleri doldurunuz.");
            }
            

        }
    }
}
