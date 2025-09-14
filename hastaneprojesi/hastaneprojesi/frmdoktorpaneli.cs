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
    public partial class frmdoktorpaneli : Form
    {
        public frmdoktorpaneli()
        {
            InitializeComponent();
        }
        public void yenileme2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Doktorad, Doktorsoyad, Doktorbrans, Doktortc, Doktorsifre from Tbl_doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        sqlbaglan bgl = new sqlbaglan();
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsorgula = new SqlCommand("select * from Tbl_doktorlar where Doktortc=@a1", bgl.baglanti());
            kmtsorgula.Parameters.AddWithValue("@a1", msktc.Text);
            SqlDataReader rdsorgula = kmtsorgula.ExecuteReader();
            SqlCommand kmtdrekle = new SqlCommand("insert into Tbl_doktorlar (Doktorad, Doktorsoyad, Doktorbrans, Doktortc, Doktorsifre) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
            kmtdrekle.Parameters.AddWithValue("@p1", txtad.Text);
            kmtdrekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kmtdrekle.Parameters.AddWithValue("@p3", cmbbrans.Text);
            kmtdrekle.Parameters.AddWithValue("@p4", msktc.Text);
            kmtdrekle.Parameters.AddWithValue("@p5", txtsifre.Text);
            if (txtad.Text != "" && txtsoyad.Text != "" && cmbbrans.Text != "" && msktc.Text != "" && txtsifre.Text != "")
            {
                if(rdsorgula.Read())
                {
                    MessageBox.Show("Kullanıcı zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    kmtdrekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt yapıldı" + " Şifreniz:" + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yenileme2();
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz girdinizden emin olunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
            
        }

        private void frmdoktorpaneli_Load(object sender, EventArgs e)
        {
            SqlCommand komutbransgetir = new SqlCommand("select Bransad from Tbl_branslar", bgl.baglanti());
            SqlDataReader rdgetir = komutbransgetir.ExecuteReader();
            while (rdgetir.Read())
            {
                cmbbrans.Items.Add(rdgetir[0]);
            }

            yenileme2();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            txtad.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            msktc.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();

        }
        
        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Doktorlar where Doktortc=@d1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@d1", msktc.Text);
            if (msktc.Text != "")
            {
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenileme2();
                
            }

            else
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_doktorlar set Doktorad=@a1, Doktorsoyad=@a2, Doktorbrans=@a3, DoktorTC=@a4, Doktorsifre=@a5 where DoktorTC=@a4", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbbrans.Text);
            komutguncelle.Parameters.AddWithValue("@a4", msktc.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtsifre.Text);

            if (msktc.Text != "")
            {
                komutguncelle.ExecuteNonQuery();
                yenileme2();
                MessageBox.Show("Kayıtlar güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.baglanti().Close();
        }


    }
}
 