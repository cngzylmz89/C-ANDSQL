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
    public partial class frmdoktordetay : Form
    {
        public frmdoktordetay()
        {
            InitializeComponent();
        }

        public string doktortc;
        sqlbaglan bgl = new sqlbaglan();
        private void frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbldoktortc.Text = doktortc;

            SqlCommand komut1 = new SqlCommand("select Doktorad, Doktorsoyad from Tbl_Doktorlar where  DoktorTC='" + doktortc + "'", bgl.baglanti());
            SqlDataReader rd1 = komut1.ExecuteReader();
            while (rd1.Read())
            {
                lbladsoyaddoktor.Text = rd1[0] + " " + rd1[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDurum='True' and RandevuDoktor='" + lbladsoyaddoktor.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            rchsikayetdoktor.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frmduyurular frm = new frmduyurular();
            frm.Show();
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            
            frmbilgiduzenledoktor frm = new frmbilgiduzenledoktor();
            frm.doktoruntc=doktortc;
            frm.Show();
        }

        private void btninternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            frm.Show();
            this.Hide();
        }
    }
}
