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
using System.Data.SqlClient;

namespace otobusbiletrezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void cmbkalkis()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from il", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkalkısil.DisplayMember = "ad";
            cmbkalkısil.ValueMember = "id";
            cmbkalkısil.DataSource = dt;

            
        }

        void cmbvarisili()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from il", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            cmbvarisil.DisplayMember = "ad";
            cmbvarisil.ValueMember = "id";
            cmbvarisil.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cmbvarisili();
            cmbkalkis();
            listelesefer();
            SqlDataAdapter da3 = new SqlDataAdapter("select * FROM TBLKAPTAN", bgl);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmbseferkaptan.DisplayMember = "KAPTANADSOYAD";
            cmbseferkaptan.ValueMember = "KAPTONNO";
            cmbseferkaptan.DataSource = dt3;
            
            
            
            
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (bir.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "1";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
            
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (iki.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "2";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (uc.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "3";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void dort_Click(object sender, EventArgs e)
        {
            if (dort.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "4";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (bes.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "5";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void altı_Click(object sender, EventArgs e)
        {
            if (altı.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "6";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            if (yedi.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "7";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            if (sekiz.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "8";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            if (dokuz.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "9";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void on_Click(object sender, EventArgs e)
        {
            if (on.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "10";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void onbir_Click(object sender, EventArgs e)
        {
            if (onbir.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "11";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        private void oniki_Click(object sender, EventArgs e)
        {
            if (oniki.BackColor == Color.Gray)
            {
                txtkoltukno.Text = "12";
            }
            else
            {
                MessageBox.Show("Bu koltuk alınmıştır.");
            }
        }

        DBTESTYOLCUBILETEntities db = new DBTESTYOLCUBILETEntities();
        SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=DBTESTYOLCUBILET;Integrated Security=True;Encrypt=False");

        void listelesefer()
        {
            var listele = (from x in db.TBLSEFERBILGIs
                           select new
                           {
                               x.SEFERNO,
                               x.KALKIS,
                               x.VARIS,
                               x.TARIH,
                               x.SAAT,
                               x.KAPTAN,
                               x.FIYAT
                           }).ToList();
            

            dataGridView1.DataSource = listele;
        }
        void listeleyolcu()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLYOLCUBILGI", bgl);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                row["ID"] = row["ID"];
                row["AD"] = row["AD"];
                row["SOYAD"] = row["SOYAD"];
                row["TELEFON"] = sifresiz(row["TELEFON"] as string);
                row["TC"] = row["TC"];
                row["CINSIYET"] = row["CINSIYET"];
                row["MAIL"] = row["MAIL"];

            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        public string sifreli(string telefon)
        {
            byte[] telefonsifre = ASCIIEncoding.ASCII.GetBytes(telefon);
            string telefonsifreli = Convert.ToBase64String(telefonsifre);
            return telefonsifreli;

        }

        public string sifresiz(string telefonnon)
        {
            byte[] telefonsifresiz = Convert.FromBase64String(telefonnon);
            string telefonsifresizson = ASCIIEncoding.ASCII.GetString(telefonsifresiz);
            return telefonsifresizson;
        }
        private void btnyolcukaydet_Click(object sender, EventArgs e)
        {
            TBLYOLCUBILGI T = new TBLYOLCUBILGI();

            T.AD = txtyolcuad.Text;
            T.SOYAD = txtyolcusoyad.Text;
            T.TC = mskyolcutc.Text;
            T.MAIL = txtyolcumail.Text;
            T.TELEFON = sifreli(mskyolcutel.Text);
            T.CINSIYET = cmbyolcucinsi.Text;
            DialogResult result1 = MessageBox.Show(txtyolcuad.Text + " adlı yolcu kaydedilecek onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                db.TBLYOLCUBILGIs.Add(T);
                db.SaveChanges();
                MessageBox.Show(txtyolcuad.Text + " " + txtyolcusoyad.Text + " adlı yolcu kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            if(btnliste.Text=="YOLCU LİSTESİ")
            {
                
                btnliste.Text = "SEFER LİSTESİ";
                groupBox8.Text = "YOLCU LİSTESİ";
                listeleyolcu();
            }
            else if(btnliste.Text=="SEFER LİSTESİ")
            {
                
                btnliste.Text = "YOLCU LİSTESİ";
                groupBox8.Text = "SEFER LİSTESİ";
                listelesefer();
            }
        }

        private void cmbkalkısil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ilce where il_id=" + cmbkalkısil.SelectedValue, bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkalkisilce.DisplayMember = "ad";
            cmbkalkisilce.ValueMember = "id";
            cmbkalkisilce.DataSource = dt;
        }

        private void cmbvarisil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from ilce where il_id=" + cmbvarisil.SelectedValue, bgl);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbvarisilce.DisplayMember = "ad";
            cmbvarisilce.ValueMember = "id";
            cmbvarisilce.DataSource = dt2;
        }

        private void btnseferkaydet_Click(object sender, EventArgs e)
        {
            //TBLSEFERBILGI T = new TBLSEFERBILGI();
            //T.KALKIS = Convert.ToInt32(cmbkalkisilce.SelectedValue.ToString());
            //T.VARIS = Convert.ToInt32(cmbvarisilce.SelectedValue.ToString());
            //T.TARIH = msksefertarih.Text;
            //T.SAAT = msksefersaat.Text;
            //T.KAPTAN =cmbseferkaptan.SelectedValue.ToString();
            //T.FIYAT =Convert.ToInt16(txtseferfiyat.Text);
            //db.TBLSEFERBILGIs.Add(T);

            bgl.Open();
            SqlCommand komutsfrkydt = new SqlCommand("INSERT INTO TBLSEFERBILGI (KALKIS, VARIS,TARIH,SAAT, KAPTAN,FIYAT) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bgl);
            komutsfrkydt.Parameters.AddWithValue("@P1", cmbkalkisilce.SelectedValue);
            komutsfrkydt.Parameters.AddWithValue("@P2", cmbvarisilce.SelectedValue);
            komutsfrkydt.Parameters.AddWithValue("@P3", msksefertarih.Text);
            komutsfrkydt.Parameters.AddWithValue("@P4", msksefersaat.Text);
            komutsfrkydt.Parameters.AddWithValue("@P5", cmbseferkaptan.SelectedValue);
            komutsfrkydt.Parameters.AddWithValue("@P6", txtseferfiyat.Text);


            DialogResult result1 = MessageBox.Show("sefer kaydedilecek. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(cmbkalkisilce.Text!=""&&cmbvarisilce.Text!=""&& msksefertarih.Text != "" && msksefersaat.Text != "" && cmbseferkaptan.Text != "" && txtseferfiyat.Text != ""&&result1==DialogResult.Yes)
            {
                komutsfrkydt.ExecuteNonQuery();
                //db.SaveChanges();
                MessageBox.Show(txtseferno.Text + " kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lüften ilgili yerleri doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Close();       
        }

        private void btnkaptankaydet_Click(object sender, EventArgs e)
        {
            TBLKAPTAN T = new TBLKAPTAN();
            T.KAPTONNO = txtkaptanno.Text;
            T.KAPTANADSOYAD = txtkaptanadısoyadı.Text;
            T.KAPTANTELEFON = mskkaptantel.Text;
            if (txtkaptanno.Text != "" && txtkaptanadısoyadı.Text != "")
            {
                db.TBLKAPTANs.Add(T);
                db.SaveChanges();
                MessageBox.Show(txtkaptanno.Text + " nolu kaptan kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(groupBox8.Text=="YOLCU LİSTESİ")
            {
                txtyolcutcrezer.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            else if(groupBox8.Text=="SEFER LİSTESİ")
            {
                txtsefernorezer.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtseferara_TextChanged(object sender, EventArgs e)
        {
            if(groupBox8.Text=="SEFER LİSTESİ")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI where SEFERNO like '%" + txtseferara.Text + "%'", bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            

        }

        private void txtyolcuara_TextChanged(object sender, EventArgs e)
        {

            if (groupBox8.Text == "YOLCU LİSTESİ")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBLYOLCUBILGI where TC like '%" + txtyolcuara.Text + "%'", bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnrezeryap_Click(object sender, EventArgs e)
        {
            
            if (txtsefernorezer.Text != "" && txtyolcutcrezer.Text != "" && txtkoltukno.Text != "")
            {
                DialogResult result = MessageBox.Show(txtsefernorezer.Text + " numaralı sefere ait " + txtkoltukno.Text + " numaralı koltuk " + txtyolcutcrezer.Text + " T.C. kimlik numaralı yolcuya tahsis edilecektir.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                bgl.Open();
                SqlCommand rezervasyon = new SqlCommand("INSERT INTO TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values(@p1,@p2,@p3)", bgl);
                rezervasyon.Parameters.AddWithValue("@p1", txtsefernorezer.Text);
                rezervasyon.Parameters.AddWithValue("@p2", txtyolcutcrezer.Text);
                rezervasyon.Parameters.AddWithValue("@p3", txtkoltukno.Text);
                if (result == DialogResult.Yes)
                {
                    rezervasyon.ExecuteNonQuery();
                    MessageBox.Show(txtsefernorezer.Text + " numaralı sefere ait " + txtkoltukno.Text + " numaralı koltuk " + txtyolcutcrezer.Text + " T.C. kimlik numaralı yolcuya tahsis edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //TBLSEFERDETAY T = new TBLSEFERDETAY();
                //T.SEFERNO = int.Parse(txtsefernorezer.Text.ToString());
                //T.YOLCUTC = txtyolcutcrezer.Text;
                //T.KOLTUK = txtyolcutcrezer.Text;
                ////db.TBLSEFERDETAYs./*Add*/(T);
                //db.SaveChanges();
                

                

            }
            else
            {
                MessageBox.Show("Lütfen ilgili yerleri doldurunuz.");
            }
            bgl.Close();

        }

        private void txtsefernorezer_TextChanged(object sender, EventArgs e)
        {

            Button[] butonlar = { bir,iki,uc,dort,bes,altı,yedi,sekiz,dokuz,on,onbir,oniki };
            foreach(Button btnn in butonlar)
            {
                btnn.BackColor = Color.Gray;
            }
            bgl.Open();
            SqlCommand koltukbos = new SqlCommand("select KOLTUK from TBLSEFERDETAY where  SEFERNO=" + int.Parse(txtsefernorezer.Text), bgl);
            SqlDataReader rd = koltukbos.ExecuteReader();
            while (rd.Read())
            {
                foreach(Button btn in butonlar)
                {
                    if (btn.Text == rd[0].ToString())
                    {
                        btn.BackColor = Color.Blue;
                    }
                    
                }
            }
            
           

            bgl.Close();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
