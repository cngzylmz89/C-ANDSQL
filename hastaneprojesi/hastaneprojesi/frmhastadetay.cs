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
    public partial class frmhastadetay : Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }
        sqlbaglan bgl = new sqlbaglan();
        public string tc;
        public void randevuliste()
        {
            DataTable dt1 = new DataTable();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Randevular where RandevuBrans=@rn1 and RandevuDurum='False'", bgl.baglanti());
            komut2.Parameters.AddWithValue("@rn1", cmbbrans.Text);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = komut2;
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC='" + tc + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select Bransad from Tbl_branslar", bgl.baglanti());
            SqlDataReader rdkomut1 = komut1.ExecuteReader();
            while (rdkomut1.Read())
            {
                cmbbrans.Items.Add(rdkomut1[0]);
            }
            bgl.baglanti().Close();
            //ad çekme
            lbltckimlikno.Text = tc;
            SqlCommand adkmt = new SqlCommand("select  * from Tbl_Hastalar where Hastatc=@p1", bgl.baglanti());
            adkmt.Parameters.AddWithValue("@p1", lbltckimlikno.Text);
            SqlDataReader rdadkmt = adkmt.ExecuteReader();
            while (rdadkmt.Read())
            {
                lbladsoyad.Text = rdadkmt[1].ToString() + "" + rdadkmt[2].ToString();
            }

            bgl.baglanti().Close();

            //tablodan veri çekip datagridden gösterme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC='" + tc + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select Doktorad, Doktorsoyad from Tbl_doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader rdkomut3 = komut3.ExecuteReader();
            while (rdkomut3.Read())
            {
                cmbdoktor.Items.Add(rdkomut3[0] + " " + rdkomut3[1]);
            }
            bgl.baglanti().Close();

            randevuliste();
        }
        
        private void lnklblbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgidüzenlehasta fr = new frmbilgidüzenlehasta();
            fr.tcno=lbltckimlikno.Text.ToString();
            fr.Show();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        { //sqlcomman kullanarak şartlı ifade yazma
           
           // DataTable dt2=new DataTable();
           // SqlCommand komut3=new SqlCommand("select * from Tbl_Randevular where RandevuBrans=@rnb1 and RandevuDoktor=@rn2 and RandevuDurum='True'", bgl.baglanti());
           // komut3.Parameters.AddWithValue("@rnb1", cmbbrans.Text);
           // komut3.Parameters.AddWithValue("@rn2", cmbdoktor.Text);
          //  SqlDataAdapter da2=new SqlDataAdapter();
           // da2.SelectCommand=komut3;
           // da2.Fill(dt2);
          //  dataGridView2.DataSource=dt2;

            //sadece dataadapter kullanarak şartlı ifade yazma 
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='"+cmbbrans.Text+"'"+ "and RandevuDoktor='"+cmbdoktor.Text+"'"+ "and RandevuDurum='False'", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;



        }

        

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut4 = new SqlCommand("update Tbl_Randevular set HastaTC=@a1, HastaSikayet=@a2, RandevuDurum='True' where Randevuid='" + txtid.Text + "'", bgl.baglanti());
            komut4.Parameters.AddWithValue("@a1", lbltckimlikno.Text);
            komut4.Parameters.AddWithValue("@a2", rchsikayet.Text);
            
            if (txtid.Text != ""&& rchsikayet.Text!="")
            {
                komut4.ExecuteNonQuery();
                MessageBox.Show("Randevu alındı", "Bilgi");
                randevuliste();
                

            }
            else
            {
                MessageBox.Show("Lütfen aktif randevulardan randevu seçiniz ve şikayetinizi bildiriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            bgl.baglanti().Close();

           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbbrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

       
    }
}
