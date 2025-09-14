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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }
        public int secimsek;
        public string sektcno;
        sqlbaglan bgl = new sqlbaglan();
        //frmRandevuListesi frm = new frmRandevuListesi();
        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            frmdoktorpaneli frmdr = new frmdoktorpaneli();
            frmdr.Show();
            
        }
        public string id, tarih, saat, bransin, doktor, hastanintcsi;
        public void listeleme()
        {
            
            mskid.Text = secimsek.ToString();
            frmsekretergiris frmgiris = new frmsekretergiris();
            frmgiris.git();

           
            

        }
        public void yenile2()
        {
            frmsekretergiris frmgiris = new frmsekretergiris();
            
            
           





            SqlCommand komut1 = new SqlCommand("select * from Tbl_sekreter where SekreterTC=" + sektcno, bgl.baglanti());
           SqlDataReader rd = komut1.ExecuteReader();
           while (rd.Read())
           {
               lbladsoyadsekreter.Text = rd[1] + " " + rd[2];
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (Doktorad+' '+Doktorsoyad) as Doktorlar, Doktorbrans from Tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("select Bransad from Tbl_branslar", bgl.baglanti());
            SqlDataReader rd3 = komut3.ExecuteReader();
            while (rd3.Read())
            {
                cmbbrans.Items.Add(rd3[0]);
            }
            bgl.baglanti().Close();
        }
       
        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {
            yenile2();
        }


        private void chkdurum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdurum.Checked == true)
            {
                label9.Text = "True";

            }
            else
            {
                label9.Text = "False";
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, HastaTC, RandevuDurum) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            
            komut2.Parameters.AddWithValue("@p1", msktarih.Text);
            komut2.Parameters.AddWithValue("@p2", msksaat.Text);
            komut2.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut2.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komut2.Parameters.AddWithValue("@p5", msktc.Text);
            komut2.Parameters.AddWithValue("@p6", label9.Text);

            

            
                if (msktarih.Text != "" && msksaat.Text != "" && cmbbrans.Text != "" && cmbdoktor.Text != "")
                {
                    komut2.ExecuteNonQuery();
                    MessageBox.Show("Randevu oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frm.yenile();
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksikszi doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
           
            bgl.baglanti().Close();

            
            

        }
        public string brans;
        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            bransin= cmbbrans.Text;
            SqlCommand komut4 = new SqlCommand("select Doktorad, Doktorsoyad from Tbl_doktorlar where Doktorbrans=@b1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@b1", cmbbrans.Text);
            SqlDataReader rd4 = komut4.ExecuteReader();
            while (rd4.Read()) 
            {
                cmbdoktor.Items.Add(rd4[0] + " " + rd4[1]);
                
            }
            bgl.baglanti().Close();

            // data adaptere şartlı ifade yazma
            DataTable dt3 = new DataTable();
            SqlCommand komut5 = new SqlCommand("select  (Doktorad +' '+ Doktorsoyad) as 'Doktorlar' from Tbl_doktorlar where Doktorbrans=@b1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@b1", cmbbrans.Text);
            SqlDataAdapter da3 = new SqlDataAdapter();
            da3.SelectCommand=komut5;
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim=dataGridView1.SelectedCells[0].RowIndex;

            cmbbrans.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim2 = dataGridView2.SelectedCells[0].RowIndex;

            cmbdoktor.Text = dataGridView2.Rows[secim2].Cells[0].Value.ToString();
        }
        frmRandevuListesi frm = new frmRandevuListesi();
        private void btnrandevulistele_Click(object sender, EventArgs e)
        {
            
            
            SqlCommand komut6 = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@hs1", bgl.baglanti());
            komut6.Parameters.AddWithValue("@hs1", msktc.Text);
            SqlDataReader rd6 = komut6.ExecuteReader();
            if(rd6.Read()|| msktc.Text=="")
            {
                SqlCommand komut7 = new SqlCommand("select * from Tbl_Randevular where HastaTC=@hs2", bgl.baglanti());
                komut7.Parameters.AddWithValue("@hs2", msktc.Text);
                SqlDataReader rd7 = komut7.ExecuteReader();
                if (rd7.Read() || msktc.Text=="")
                {
                    
                    frm.hastanintc = msktc.Text;
                    frm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Hastaya ait randevu bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Hastaya ait kayıt bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            listeleme();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            genel gnl = new genel();
            gnl.kapat2();
            SqlCommand komut7 = new SqlCommand("update Tbl_Randevular set RandevuTarih=@r1, RandevuSaat=@r2, RandevuBrans=@r3, RandevuDoktor=@r4 where HastaTC=@hs3", bgl.baglanti());
            komut7.Parameters.AddWithValue("@r1", msktarih.Text);
            komut7.Parameters.AddWithValue("@r2", msksaat.Text);
            komut7.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komut7.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komut7.Parameters.AddWithValue("@hs3", msktc.Text);
            SqlCommand komut8 = new SqlCommand("select * from Tbl_Randevular where HastaTC=@hs4", bgl.baglanti());
            komut8.Parameters.AddWithValue("@hs4", msktc.Text);
            SqlDataReader rd8 = komut8.ExecuteReader();
            if (rd8.Read()|| msktc.Text=="")
            {
                
                komut7.ExecuteNonQuery();
                MessageBox.Show("Randevu güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.yenile();

            }
            else 
            {
                MessageBox.Show( msktc.Text+" "+"TC kimlik numaralı hastaya ait randevu yoktur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            
            
            frm.hastanintc = msktc.Text;
            
            frm.yenile();
            frm.Show();
        }

        private void btnduyurolus_Click(object sender, EventArgs e)
        {
            SqlCommand komut9 = new SqlCommand("insert into Tbl_Duyurular (Duyuru, DuyuruTC) values (@d1, @d2)", bgl.baglanti());
            komut9.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut9.Parameters.AddWithValue("@d2", lblsekretertc.Text);
            if (rchduyuru.Text != "")
            {
                komut9.ExecuteNonQuery();
                MessageBox.Show("Duyuru oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen duyuru kutucuğuna yazınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            frmbrans frm = new frmbrans();
            frm.Show();
        }

        private void mskid_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut10 = new SqlCommand("select * from Tbl_Randevular where Randevuid=@rn1", bgl.baglanti());
            komut10.Parameters.AddWithValue("@rn1", mskid.Text);
            SqlDataReader rd10 = komut10.ExecuteReader();
            while(rd10.Read())
            {
                msktarih.Text = rd10[1].ToString();
                msksaat.Text = rd10[2].ToString();
                cmbbrans.Text = rd10[3].ToString();
                cmbdoktor.Text = rd10[4].ToString();
                msktc.Text = rd10[5].ToString();
            }
            
        }

        
       
    }
}
