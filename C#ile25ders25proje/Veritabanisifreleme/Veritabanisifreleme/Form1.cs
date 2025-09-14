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


namespace Veritabanisifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=DBsql;Integrated Security=True;Encrypt=False");
        //
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE LISTELE", baglanti);//sorguyu yazdık
            DataSet ds = new DataSet();//dataset sınıfından ds adında nesne türettik
            da.Fill(ds);//ds yi da ya atadık.
            foreach (DataRow row in ds.Tables[0].Rows)//foreach döngüsü


                //DataRow sınıfından row adında bir değişken oluşturduk ve in yöntemiyle ds nin içindeki 0 ıncı tablodaki sıraları dizi yapıp her bir dizi elemanına atadık.
            {
                row["AD"] = sifrecoz(row["AD"] as string);
                //sifrecoz metoduyla AD sütunundaki bütün rowları string ederek çözdük ve tekrar AD sutunundaki rowlara atadık.
                row["SOYAD"] = sifrecoz(row["SOYAD"] as string);
                row["MAIL"] = sifrecoz(row["MAIL"] as string);
                row["SIFRE"] = sifrecoz(row["SIFRE"] as string);
                row["HESAPNO"] = sifrecoz(row["HESAPNO"] as string);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        public string sifre(string ad)
        {
            //parametreli metot oluşturduk ve ad değişkeni oluşturduk
            string turad=(((ad.ToLower()).Replace("ş", "s")).Replace("ö","o")).Replace("ç","c");//lower küçük harfe çevir, replace değiştirerek yaz
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(turad);
            //byte türünde addizi adında bir dizi oluşturduk. bu dizinin elemanlarını ad
            //değişkeninden gelen string bytelara ayırdık ve her bir byte ı
            //ASCII metoduna göre şifreleyip addizi dizisine attık.
            string adsifre = Convert.ToBase64String(addizi);
            //adsifre stringi oluşturup bu stringin addizisini tobase64 yöntemiyle şifreledik.
            return adsifre;
            

        }
        
       
        
        public string sifrecoz(string adcozum)
        {
            //parametreli metot oluşturup adcozum adında string türünde bir parametre oluşturduk
            byte[] adcozumdizisi = Convert.FromBase64String(adcozum);
            //byte türünde dizi oluşturup bu dizinin elemanlarını adcozum stringini sifresini çözerek dizi elemanlarına atadık.
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizisi);
            //dizi elemanlarını ASCII sembollerine göre çözümleyip adverisine atadık.
            return adverisi;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komutkaydet = new SqlCommand("insert into TBLBANKAHESABI (AD, SOYAD, MAIL, SIFRE, HESAPNO) VALUES(@P1,@P2,@P3,@P4,@P5)", baglanti);
            komutkaydet.Parameters.AddWithValue("@P1", sifre(txtad.Text));
            komutkaydet.Parameters.AddWithValue("@P2", sifre(txtsoyad.Text));
            komutkaydet.Parameters.AddWithValue("@P3", sifre(txtmail.Text));
            komutkaydet.Parameters.AddWithValue("@P4", sifre(txtsifre.Text));
            komutkaydet.Parameters.AddWithValue("@P5", sifre(txthesapno.Text));
            komutkaydet.ExecuteNonQuery();

            listele();
            
            
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = sifrecoz(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtsoyad.Text = sifrecoz(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtmail.Text = sifrecoz(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtsifre.Text = sifrecoz(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            txthesapno.Text = sifrecoz(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = sifrecoz(txtad.Text);
        }
    }
}
 