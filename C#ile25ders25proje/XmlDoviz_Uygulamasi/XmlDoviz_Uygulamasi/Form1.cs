using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;// XML kütüphanesini ekle
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace XmlDoviz_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kur;
        int miktar;
        int islem;
        int dolaroreuro;
        dovizkurEntities db = new dovizkurEntities();
        void yenile()
        {
            string adres = "https://www.tcmb.gov.tr/kurlar/today.xml";//xml şeklinde verileri paylaşan sitenin adresini yaz.
            var xmldosya = new XmlDocument();//xml dökümanını bir değişkene bağlıyoruz
            xmldosya.Load(adres);//dökümanı adrese bağlıyarak başlatıyoruz.

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;//SelectSingleNode metoduyla sitedeki bilgileri ayıklıyarak değişkene bağlıyoruz.
            lbldolaralis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatis.Text = eurosatis;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();

        }

        private void update_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralis.Text;
            dolaroreuro = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatis.Text;
            dolaroreuro = 2;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalis.Text;
            dolaroreuro = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosatis.Text;
            dolaroreuro = 4;

        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");//ilk tırnaktaki sembol yerine ikinci tırnaktaki sembolle değiştirir.
        }
        
        private void btnislem1_Click(object sender, EventArgs e)
        {
            if (txtkur.Text != "" && txtmiktar.Text != "")
            {
                kur = Convert.ToDouble(txtkur.Text);
                miktar = Convert.ToInt32(txtmiktar.Text);
                txttutar.Text = (miktar * kur).ToString();
                txtkalan.Text = "";
                islem = 0;
            }
             
           

        }

        private void btnislem2_Click(object sender, EventArgs e)
        {
            if (txtkur.Text != "" && txtmiktar.Text != "")
            {
                kur = Convert.ToDouble(txtkur.Text);
                miktar = int.Parse(txtmiktar.Text);
                txttutar.Text = (kur / miktar).ToString();
                txtkalan.Text = (kur % miktar).ToString();
                islem = 1;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DOVIZKASA DD = new DOVIZKASA();
            var dolar = (from x in db.DOVIZKASA where x.ISLEMID == 1 select x.DOLAR).FirstOrDefault();
            var tl = (from x in db.DOVIZKASA where x.ISLEMID == 1 select x.TL).FirstOrDefault();
            var euro = (from x in db.DOVIZKASA where x.ISLEMID == 1 select x.EURO).FirstOrDefault();
            var ktrg = db.DOVIZKASA.Find(1);
            if (islem == 0 && dolaroreuro==1)
            {
                
                ktrg.DOLAR = decimal.Parse(txtmiktar.Text)+decimal.Parse(dolar.ToString());
               // ktrg.TL = decimal.Parse(tl.ToString())-decimal.Parse(txttutar.Text.ToString());
                db.SaveChanges();
                MessageBox.Show(txtmiktar.Text + " tutarında dolar kasaya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(islem==1 && dolaroreuro == 2)
            {
                ktrg.TL = (decimal.Parse(txtmiktar.Text + tl));
                ktrg.DOLAR = decimal.Parse(dolar.ToString()) - decimal.Parse(txttutar.Text);
                db.SaveChanges();
                MessageBox.Show(txtmiktar.Text + " tutarında tl kasaya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(islem==0&& dolaroreuro == 3)
            {
                ktrg.EURO = decimal.Parse(txtmiktar.Text + euro);
                ktrg.TL = decimal.Parse(txttutar.Text) - decimal.Parse(tl.ToString());
                db.SaveChanges();
                MessageBox.Show(txtmiktar.Text + " tutarında euro kasaya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (islem == 1 && dolaroreuro == 4)
            {
                ktrg.TL = decimal.Parse(txtmiktar.Text + tl);
                ktrg.EURO = decimal.Parse(txttutar.Text) - decimal.Parse(euro.ToString());
                MessageBox.Show(txtmiktar.Text + " tutarında tl kasaya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.SaveChanges();
            }
            lblkasadolar.Text = dolar.ToString();
            lblkasatl.Text = tl.ToString();
            lblkasaeuro.Text = euro.ToString();
        }

        
    }
}
