using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglan bgl = new sqlbaglan();
        

        public void listele()
        {
            
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1=new SqlDataAdapter("select * from Tbl_Kitaplik", bgl.Adres);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
        
        //public void bilgigetir()
        //{
        //    int id = Convert.ToInt16(mskkitapid.Text);
        //    baglanti.Open();
            
        //    OleDbCommand komut4 = new OleDbCommand("select * from Tbl_Kitaplik where Kitapid="+id, baglanti);
        //    OleDbDataReader rd4 = komut4.ExecuteReader();

        //    while (rd4.Read())
        //    {
        //        if(mskkitapid.Text!="")
        //        {
        //           // txtkitapad.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[1].Value.ToString();
        //            txtyazar.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[2].Value.ToString();
        //            txtyayinevi.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[3].Value.ToString();
        //            msksayfa.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[5].Value.ToString();
        //            cmbtur.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[4].Value.ToString();
        //            label7.Text = dataGridView1.Rows[Convert.ToInt16(mskkitapid.Text)].Cells[6].Value.ToString();
        //        }
                    
               
                
        //    }
        //    baglanti.Close();
            
            
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            mskkitapid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtkitapad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtyayinevi.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            msksayfa.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            cmbtur.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
           

        }
        
       
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut1 = new SqlCommand("insert into Tbl_Kitaplik (Kitapad, Yazar, Yayinevi, Tur, SayfaSayisi) values (@a1, @a2, @a3, @a4, @a5)", conn);
                komut1.Parameters.AddWithValue("@a1", txtkitapad.Text);
                komut1.Parameters.AddWithValue("@a2", txtyazar.Text);
                komut1.Parameters.AddWithValue("@a3", txtyayinevi.Text);
                komut1.Parameters.AddWithValue("@a4", cmbtur.Text);
                komut1.Parameters.AddWithValue("@a5", msksayfa.Text);

                if (txtkitapad.Text != "" && txtyazar.Text != "" && txtyayinevi.Text != "" && cmbtur.Text != "" && msksayfa.Text != "")
                {
                    komut1.ExecuteNonQuery();
                    MessageBox.Show("Kitap kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
                listele();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.ToString());
            }
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut2=new SqlCommand("delete from Tbl_Kitaplik where Kitapid=@p1", conn);
            komut2.Parameters.AddWithValue("@p1", mskkitapid.Text);
            if (mskkitapid.Text != "")
            {
                komut2.ExecuteNonQuery();
                MessageBox.Show("Kitap silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut4=new SqlCommand ("select * from Tbl_Kitaplik where Kitapid=@z"  ,conn);
            komut4.Parameters.AddWithValue("@z", mskkitapid.Text);
            SqlDataReader rd4 = komut4.ExecuteReader();
            SqlCommand komut3=new SqlCommand ("update Tbl_Kitaplik set Kitapad=@k1, Yazar=@k2, Yayinevi=@k3, Tur=@k4, SayfaSayisi=@k5 where Kitapid=@k7" , conn);
            komut3.Parameters.AddWithValue("@k7", mskkitapid.Text);
            komut3.Parameters.AddWithValue("@k1", txtkitapad.Text);
            komut3.Parameters.AddWithValue("@k2", txtyazar.Text);
            komut3.Parameters.AddWithValue("@k3", txtyayinevi.Text);
            komut3.Parameters.AddWithValue("@k4", cmbtur.Text);
            komut3.Parameters.AddWithValue("@k5", msksayfa.Text);
            
            while (rd4.Read())
            {
                
              komut3.ExecuteNonQuery();
              MessageBox.Show("Kitap güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            conn.Close();
            listele();
        }

       

        private void btnbul_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt3=new DataTable();
            SqlCommand komut6=new SqlCommand ("Select * from Tbl_Kitaplik where Kitapad=@a1", conn);
            komut6.Parameters.AddWithValue("@a1", txtbul.Text );
            SqlDataAdapter da3 = new SqlDataAdapter(komut6);
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            conn.Close();
        }

        private void txtbul_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            DataTable dt3 = new DataTable();
            SqlCommand komut6=new SqlCommand ("Select * from Tbl_Kitaplik where Kitapad like '%"+txtbul.Text+"%'", conn);
            SqlDataAdapter da3=new SqlDataAdapter(komut6);
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            conn.Close();
        }

       

        

        

        

       

        
        
    }
}
