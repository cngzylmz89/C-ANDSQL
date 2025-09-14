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
using System.Data.SqlTypes;


namespace MALIYETLENDIRMESISTEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        baglan con= new baglan();
        private void btnekle_Click(object sender, EventArgs e)
        {
            

            if (txturun.Text != "")
            {

                SqlCommand URUNMALZEME = new SqlCommand("insert into TBLURUNMALZEMEDETAY (URUNID, URUNMALZEME, URUNMALMIKTAR, URUNMALFIYAT, URUNADET) VALUES(@P1,@P2,@P3,@P4,@P5)", con.baglanti());
                URUNMALZEME.Parameters.AddWithValue("@P1", byte.Parse(txturun.Text));
                URUNMALZEME.Parameters.AddWithValue("@P2", short.Parse(cmbmalzeme.SelectedValue.ToString()));
                URUNMALZEME.Parameters.AddWithValue("@P3", decimal.Parse(numericUpDown1.Value.ToString()));
                URUNMALZEME.Parameters.AddWithValue("@P4", decimal.Parse(txtmaliyet.Text));
                URUNMALZEME.Parameters.AddWithValue("@P5", byte.Parse(nmurunadet.Value.ToString()));
                URUNMALZEME.ExecuteNonQuery();
                MessageBox.Show("Ürüne malzeme eklendi.");

                listBox1.Items.Add("MALZEME ADI: " + cmbmalzeme.Text + ", " + "FİYAT: " + txtmaliyet.Text + ", MALZEME MİKTARI: " + numericUpDown1.Value);
            }
            else { MessageBox.Show("Lütfen ürün listesinden ürün seçiniz."); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ID, MALZEMEADI from TBLMALZEMELER", con.baglanti());
            DataTable dt=new DataTable();  
            da.Fill(dt);
            cmbmalzeme.DisplayMember = "MALZEMEADI";
            cmbmalzeme.ValueMember = "ID";
            cmbmalzeme.DataSource = dt;
            
        }
        int miktar;
        decimal fiyat;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand fiyatoku=new SqlCommand("select FIYAT from TBLMALZEMELER WHERE ID="+cmbmalzeme.SelectedValue,con.baglanti());
            SqlDataReader rd=fiyatoku.ExecuteReader();
            while (rd.Read())
            {
                miktar=int.Parse(numericUpDown1.Value.ToString());
                fiyat = decimal.Parse(rd[0].ToString());
                txtmaliyet.Text = (miktar*fiyat).ToString();
            }
            con.baglanti().Close();
        }
        TESTMALIYETEntities db=new TESTMALIYETEntities();
        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Ürün kaydedilecek. Onaylıyor musunuz?","Bilgi",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes&&txtmalzemead.Text!=""&&txtmalzemefiyat.Text!=""&&txtmalzemestok.Text!="")
            {
                TBLMALZEMELER T = new TBLMALZEMELER();
                T.MALZEMEADI = txtmalzemead.Text;
                T.STOK = short.Parse(txtmalzemestok.Text);
                T.FIYAT = decimal.Parse(txtmalzemestok.Text);
                T.NOTLAR = txtmalzemenotlar.Text;
                db.TBLMALZEMELERs.Add(T);
                db.SaveChanges();
                MessageBox.Show("Ürün kaydedildi.");

               

                
            }
            
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Ürün kaydedilecek. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && txturunad.Text != "" )
            {
                TBLURUNLER T = new TBLURUNLER();
                T.AD = txturunad.Text;
                T.URETIMTARIHI = dtpurtarih.Value;
                T.SNTUKETIMTARIHI= dtpurtarih.Value;
                db.TBLURUNLERs.Add(T);
                db.SaveChanges();
                MessageBox.Show("Ürün kaydedildi.");
            }
        }

        private void btnurunlistele_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "ÜRÜN LİSTESİ";
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", con.baglanti());
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (groupBox2.Text)
            {
                case "ÜRÜN LİSTESİ":
                    txturun.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    mskurunıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txturunad.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txturunstok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txturunmfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txturunsfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpurtarih.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dtpsnttarih.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    break;
                case "MALZEME LİSTESİ":
                    mskıdmalzeme.Text=dataGridView1.Rows[e.RowIndex ].Cells[0].Value.ToString();
                    txtmalzemead.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtmalzemestok.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtmalzemefiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtmalzemenotlar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    break;

                
            }
        }

        private void btnmalzemelistele_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "MALZEME LİSTESİ";
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", con.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "ÜRÜN DETAY LİSTESİ";
            SqlDataAdapter da = new SqlDataAdapter("select * from URUNLISTESI", con.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "KASA";
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKASA", con.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            frmgiris fr=new frmgiris();
            fr.Show();
            this.Close();
        }

        private void txturun_TextChanged(object sender, EventArgs e)
        {
            if(txturun.Text!=""&&groupBox2.Text=="ÜRÜN DETAY LİSTESİ")
            {
                groupBox2.Text = "ÜRÜN DETAY LİSTESİ";
                SqlDataAdapter da = new SqlDataAdapter("select * from DBO.URUNGETIR(" + txturun.Text + ")", con.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }

        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            if (mskurunıd.Text != "")
            {
                TBLURUNLER T = new TBLURUNLER();
                int a = int.Parse(mskurunıd.Text);
                var ktgr = db.TBLURUNLERs.Find(a);
                ktgr.AD = txturunad.Text;
                ktgr.URETIMTARIHI = dtpurtarih.Value;
                ktgr.SNTUKETIMTARIHI = dtpsnttarih.Value;
                db.SaveChanges();
                MessageBox.Show(a + " numaralı ürün güncellendi.");
            }
            
        }
    }
}
