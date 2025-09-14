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

namespace Okulbonus
{
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter nt =new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=OKULBONUS;Integrated Security=True");
        void listele()
        {
            dataGridView1.DataSource = nt.NotListesi(int.Parse(mskogrenciid.Text));
            dataGridView1.Columns["DERSID"].Visible = false;
        }
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            frmOgretmen frm = new frmOgretmen();
            this.Close();
            frm.Show();
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            bgl.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", bgl);
            da.Fill(dt);

            cmbders.DisplayMember = "DERSAD";
            cmbders.ValueMember = "DERSID";
            cmbders.DataSource = dt;
            bgl.Close();
           
        }

        private void pckbxogrbul_Click(object sender, EventArgs e)
        {
            if (mskogrenciid.Text != "")
            {
                listele();
            }
            else
            {
                MessageBox.Show("Lütfen öğrenci id'yi giriniz.");
            }
        }
        int ortalama;
        string durum;
        int proje;
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            ortalama = (int.Parse(msksinav1.Text) + int.Parse(msksinav2.Text) + int.Parse(msksinav3.Text) + int.Parse(mskproje.Text)) / 4;
            mskortalama.Text=ortalama.ToString();
            if (ortalama >= 70)
            {
                durum = "True";
                if(durum=="True")
                txtdurum.Text = "GEÇTİ";
                txtdurum.BackColor = Color.Blue;
            }
            else
            {
                durum = "False";
                if (durum == "False")
                {
                    txtdurum.Text = "KALDI";
                    txtdurum.BackColor = Color.Red;
                }
                
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbders.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            msksinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            msksinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            msksinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            mskproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            mskortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString()=="True")
            {
                txtdurum.Text = "GEÇTİ";
                txtdurum.BackColor = Color.Blue;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "False")
            {
                txtdurum.Text = "KALDI";
                txtdurum.BackColor = Color.Red;

            }
 
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int r;
            bgl.Open();
            SqlCommand komut = new SqlCommand("select count(DERSID) from TBLNOTLAR where OGRID=@P1 and DERSID=@P2", bgl);
            komut.Parameters.AddWithValue("@P1", mskogrenciid.Text);
            komut.Parameters.AddWithValue("@P2", cmbders.SelectedValue.ToString());
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                r = Convert.ToInt16(rd[0].ToString());
                if (r>=1)
                {
                    nt.NotGuncelle(byte.Parse(cmbders.SelectedValue.ToString()), byte.Parse(msksinav1.Text), byte.Parse(msksinav2.Text), byte.Parse(msksinav3.Text), byte.Parse(mskproje.Text), decimal.Parse(mskortalama.Text), bool.Parse(durum), int.Parse(mskogrenciid.Text));
                    MessageBox.Show("Notlar güncellendi.");
                    listele();
                }
                if (r<1)
                {
                    nt.NotEkleme(byte.Parse(cmbders.SelectedValue.ToString()), int.Parse(mskogrenciid.Text), byte.Parse(msksinav1.Text), byte.Parse(msksinav2.Text), byte.Parse(msksinav3.Text), byte.Parse(mskproje.Text), decimal.Parse(mskortalama.Text), bool.Parse(durum));
                    MessageBox.Show("Notlar kaydedildi.");
                    listele();
                }

            }

            bgl.Close();


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {

            msksinav1.Text = "";
            msksinav2.Text = "";
            msksinav3.Text ="" ;
            mskproje.Text ="" ;
            mskortalama.Text = "";
            txtdurum.Text = "";
            txtdurum.BackColor = Color.White;
            

            cmbders.Focus();
        }
        
       

       
    }
}
