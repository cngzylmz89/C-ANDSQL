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
using System.Xml.Linq;


namespace TELEFONVEMAILUYGULAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=KISILER;Integrated Security=True;Encrypt=False");
        KISILEREntities db = new KISILEREntities();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UPPER(ID) AS 'NUMARA', UPPER(ADI) AS 'ADI', UPPER(SOYADI) AS 'SOYADI' FROM TBLKISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //var ktgr = db.TBLKISILERs.ToList();
            //dataGridView1.DataSource = ktgr;

        }
        void temizle()
        {
            mskid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktel.Text = "";
            txtmail.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && msktel.Text != "" && txtmail.Text != "")
            {
                try
                {
                    TBLKISILER T = new TBLKISILER();
                    T.ADI = txtad.Text;
                    T.SOYADI = txtsoyad.Text;
                    T.TELEFON = msktel.Text;
                    T.MAİL = txtmail.Text;
                    db.TBLKISILERs.Add(T);
                    db.SaveChanges();
                    listele();
                    temizle();
                }
                catch (Exception HATA)
                {

                    MessageBox.Show(HATA.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz");
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (mskid.Text != "")

            {
                DialogResult result1 = MessageBox.Show(mskid.Text + " numaralı kayıt silinecek onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    int a = Convert.ToInt16(mskid.Text);
                    var ktr = db.TBLKISILERs.Find(a);
                    db.TBLKISILERs.Remove(ktr);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt silindi");
                    listele();
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Tablodan kayıt seçiniz?", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (mskid.Text != "")

            {
                DialogResult result1 = MessageBox.Show(mskid.Text + " numaralı kayıt güncellenecek onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {

                    int a = Convert.ToInt16(mskid.Text);
                    var ktr = db.TBLKISILERs.Find(a);
                    ktr.ADI = txtad.Text;
                    ktr.SOYADI = txtsoyad.Text;
                    ktr.TELEFON = msktel.Text;
                    ktr.MAİL = txtmail.Text;

                    db.SaveChanges();
                    MessageBox.Show("Kayıt güncellendi");
                    listele();
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Tablodan kayıt seçiniz?", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //msktel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
