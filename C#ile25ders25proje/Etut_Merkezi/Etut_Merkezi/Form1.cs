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
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Etut_Merkezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        connect bgl = new connect();
        EtutTestEntities db = new EtutTestEntities();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=EtutTest;Integrated Security=True;Encrypt=False");
        void listeleetut()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ETUT", bgl.baglanti());
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataGridViewCellStyle stil = new DataGridViewCellStyle();
            //datagridviewcellstyle sınıfından stil adında bir nesne tanımlıyoruz.
            for(int i=0; i < dataGridView1.Rows.Count -1; i++)//döngü oluşturuyoruz
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[9].Value) == true)
                    //tablonun i inci sırasının 9 uncu hücresinin değerini boolean değişkenine çeviripsorguluyoruz.
                {
                    stil.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].DefaultCellStyle = stil;
                }
            }
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            



            //var list = (from x in db.TBLETUTs
            //            select new
            //            {
            //                x.ID,
            //                x.DERSID,
            //                x.OGRETMENID,
            //                x.OGRENCIID,
            //                x.TARIH,
            //                x.SAAT,
            //                x.DURUM,
            //            }
            //).ToList();
            //dataGridView1.DataSource = list;
        }
        void listelebrans()
        {
            //var derslist = (from x in db.TBLBRANS
            //            select new
            //            {
            //                x.BRANSAD,
            //                x.BRANSID,
            //            }
            //).ToList();

            //cmbders.DisplayMember = "BRANSAD";
            //cmbders.ValueMember = "BRANSID";
            //cmbders.DataSource = derslist;

            SqlDataAdapter da = new SqlDataAdapter("select * from TBLBRANS", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.ValueMember = "BRANSID";
            cmbders.DisplayMember = "BRANSAD";
            cmbders.DataSource = dt;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            listeleetut();
            listelebrans();

        }
        int a;
        
        
        private void btnetutolus_Click(object sender, EventArgs e)
        {
            //ENTİTY
            //TBLETUT T = new TBLETUT();
            //T.DERSID = int.Parse(cmbders.SelectedValue.ToString());

            //FİRST KOD
            con.Open();
            SqlCommand komutetol = new SqlCommand("insert into tbletut (dersıd,ogretmenıd, tarıh, saat) values(@a1,@a2,@a3,@a4)",con);
            komutetol.Parameters.AddWithValue("@a1", cmbders.SelectedValue);
            komutetol.Parameters.AddWithValue("@a2", cmbders.SelectedValue);
            komutetol.Parameters.AddWithValue("@a3", msktarih.Text);
            komutetol.Parameters.AddWithValue("@a4", msksaat.Text);
            if (msksaat.Text != "" && msktarih.Text != "")
            {
                komutetol.ExecuteNonQuery();
                MessageBox.Show("Etüt kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen saat ve tarih giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            listeleetut();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        
    
        private void btnfotografyukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT AD+' '+SOYAD AS 'ADSOYAD' FROM TBLOGRETMEN WHERE BRANS=" + cmbders.SelectedValue, bgl.baglanti());
            DataTable dt2 = new DataTable();
            cmbogretmen.ValueMember = "OGRTID";
            cmbogretmen.DisplayMember = "ADSOYAD";
            da2.Fill(dt2);
            cmbogretmen.DataSource = dt2;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(button3.Text=="ÖĞRENCİ LİSTELE")
            {
                cmbders.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                msktarih.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                msksaat.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtetutıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtogrenci.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

            else if (button3.Text=="ETÜT LİSTELE")
            {
                txtogrenciad.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtogrencisoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtogrencisinif.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                mskogrencitelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtogrencimail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            

        }

        private void btnetutver_Click(object sender, EventArgs e)
        {

            //
            SqlCommand komutguncelle = new SqlCommand("update tbletut set ogrencııd=@k1 where ıd=@k2" , bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@k1", txtogrenci.Text);
            komutguncelle.Parameters.AddWithValue("@k2", txtetutıd.Text);

            if (txtetutıd.Text != "" && txtogrenci.Text != "")
            {
                komutguncelle.ExecuteNonQuery();
                MessageBox.Show(txtetutıd.Text + " numaralı etüt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID VE OGRENCI NUMARASI GİRİNİZ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listeleetut();
            //Entity 
            //TBLETUT T = new TBLETUT();
            //var bul = (from x in db.TBLETUTs where x.ID == int.Parse(txtetutıd.Text) select x).FirstOrDefault();
            //db.TBLETUTs.Find(bul);
            //bul.OGRENCIID = short.Parse(txtogrenci.Text);
            //db.SaveChanges();
            //MessageBox.Show(bul + " numaralı etüt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listeleetut();
            
        }
        string okuders;
        private void btndersekle_Click(object sender, EventArgs e)
        {
            
            if (txtdersadi.Text != "")
            {
                SqlCommand komutders = new SqlCommand("select BRANSAD FROM TBLBRANS WHERE BRANSAD=@A1" , bgl.baglanti());
                komutders.Parameters.AddWithValue("@A1", txtdersadi.Text.ToUpper());
                SqlDataReader rd = komutders.ExecuteReader();
                if (rd.Read() == true)
                {
                    MessageBox.Show("Bu ders zaten var. Başka bir ders ekleyiniz.");
                    okuders = "true";
                }
                else
                {
                    okuders = "false";
                }
                bgl.baglanti().Close();
                if (okuders=="false")
                {

                    SqlCommand komutdersekle = new SqlCommand("INSERT INTO TBLBRANS (BRANSAD) VALUES(@P1)", bgl.baglanti());
                    komutdersekle.Parameters.AddWithValue("@P1", txtdersadi.Text.ToUpper());
                    komutdersekle.ExecuteNonQuery();
                    MessageBox.Show("Ders eklendi");
                    bgl.baglanti().Close();
                }
            }

            

            
        }
        public string sifreli(string sifre)
        {
            byte[] sifrele = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreson = Convert.ToBase64String(sifrele);
            return sifreson;
        }

        public string sifrecoz(string sifresiz)
        {
            byte[] sifrecozum = Convert.FromBase64String(sifresiz);
            string sifrecozumson = ASCIIEncoding.ASCII.GetString(sifrecozum);
            return sifrecozumson;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TBLOGRENCI T = new TBLOGRENCI();
            SqlCommand telefon = new SqlCommand("select TELEFON FROM TBLOGRENCI WHERE TELEFON=@P1", bgl.baglanti());
            telefon.Parameters.AddWithValue("@P1", sifreli(mskogrencitelefon.Text));
            SqlDataReader rd = telefon.ExecuteReader();

            if (rd.Read())
            {
                MessageBox.Show(mskogrencitelefon.Text + " telefon numaralı öğrenci zaten kayıtlı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                T.OGRAD = txtogrenciad.Text;
                T.OGRSOYAD = txtogrencisoyad.Text;
                T.SINIF = txtogrencisinif.Text;
                T.TELEFON = sifreli(mskogrencitelefon.Text);
                T.MAIL = txtogrencimail.Text;
                T.FOTOGRAF=pictureBox1.ImageLocation;
                db.TBLOGRENCIs.Add(T);
                db.SaveChanges();
                MessageBox.Show(mskogrencitelefon.Text + " telefon numaralı öğrenci kaydedildi.");

            }
            

        }
        string okuogretmen;
        private void btnogretmenekle_Click(object sender, EventArgs e)
        {
            if (txtogretmenad.Text != "" && txtogretmensoyad.Text != "" && txtogretmenders.Text != "")
            {
                TBLOGRETMan T = new TBLOGRETMan();
                T.AD = txtogretmenad.Text;
                T.SOYAD = txtogretmensoyad.Text;
                T.BRANS = byte.Parse(txtogretmenders.Text);
                db.TBLOGRETMEN.Add(T);
                db.SaveChanges();
                MessageBox.Show(txtogretmenad.Text + " " + txtogretmensoyad.Text + "  ögretmen kaydedildi.");
            }
            else
            {
                MessageBox.Show("İlgili yerleri doldurunuz.");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text=="ÖĞRENCİ LİSTELE")
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT OGRID, OGRAD,OGRSOYAD,FOTOGRAF ,SINIF,TELEFON,MAIL FROM TBLOGRENCI", bgl.baglanti());
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["OGRID"] = row["OGRID"];
                    row["OGRAD"] = row["OGRAD"];
                    row["OGRSOYAD"] = row["OGRSOYAD"];
                    row["FOTOGRAF"] = row["FOTOGRAF"];
                    row["SINIF"] = row["SINIF"];
                    row["TELEFON"] = sifrecoz(row["TELEFON"] as string);
                    row["MAIL"] = row["MAIL"];

                }
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[3].Visible = false;
                button3.Text = "ETÜT LİSTELE";
            }
            
            else if (button3.Text == "ETÜT LİSTELE")
            {
                
                listeleetut();
                button3.Text = "ÖĞRENCİ LİSTELE";
            }
            
        }

        
    }
}
