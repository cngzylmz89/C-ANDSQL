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

namespace MESAJPROGRAMI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void datagelenlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AD+' '+SOYAD AS 'ADI SOYADI', BASLIK, ICERIK FROM TBLMESAJLAR INNER JOIN TBLKISILER ON TBLKISILER.NUMARA=TBLMESAJLAR.GONDERICI  WHERE ALICI=" + numara.ToString(),connect.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.baglan().Close();
        }
        void datagidenlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT AD+' '+SOYAD AS 'ADI SOYADI', BASLIK, ICERIK FROM TBLMESAJLAR INNER JOIN TBLKISILER ON TBLKISILER.NUMARA=TBLMESAJLAR.ALICI  WHERE GONDERICI=" + numara.ToString(), connect.baglan());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connect.baglan().Close();
        }
        public string numara;
        baglanti connect = new baglanti();
        private void Form2_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            SqlCommand komutad = new SqlCommand("select AD+' '+SOYAD FROM TBLKISILER WHERE NUMARA=" + lblnumara.Text, connect.baglan());
            SqlDataReader rd = komutad.ExecuteReader();
            while (rd.Read())
            {
                lbladsoyad.Text = rd[0].ToString();
            }
            datagelenlistele();
            datagidenlistele();
            connect.baglan().Close();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            SqlCommand komutmesajgon = new SqlCommand("insert into TBLMESAJLAR (GONDERICI, ALICI, BASLIK, ICERIK) VALUES(@P1,@P2,@P3,@P4)", connect.baglan());
            komutmesajgon.Parameters.AddWithValue("@P1", lblnumara.Text);
            komutmesajgon.Parameters.AddWithValue("@P2", mskalici.Text);
            komutmesajgon.Parameters.AddWithValue("@P3", txtbaslik.Text);
            komutmesajgon.Parameters.AddWithValue("@P4", rchmesaj.Text);
            if(mskalici.Text!=""&& txtbaslik.Text != "" && rchmesaj.Text != "")
            {
                try
                {
                    komutmesajgon.ExecuteNonQuery();
                    MessageBox.Show("Mesajınız iletildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagidenlistele();
                }
                catch (Exception Hata )
                {

                    MessageBox.Show(Hata.ToString());
                }
            }
            else
            {
                MessageBox.Show("İlgili alanları doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rchmesaj.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rchmesaj.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
