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


namespace MALIYETLENDIRMESISTEMI
{
    public partial class frmsat : Form
    {
        public frmsat()
        {
            InitializeComponent();
        }
        baglan con=new baglan();
        void satislistele()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLURUNSATIS", con.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        void urunlistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", con.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmsat_Load(object sender, EventArgs e)
        {
            satislistele();
            urunlistele();

        }
        TESTMALIYETEntities db=new TESTMALIYETEntities();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txturunfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
        decimal fiyat;
        int adet;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (txturunfiyat.Text != "")
            {
                fiyat = decimal.Parse(txturunfiyat.Text);
                adet = int.Parse(numericUpDown1.Value.ToString());
                txttutar.Text = (fiyat * adet).ToString()+ " ₺";
            }
            
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            if (txtaliciadsoyad.Text != "" && mskalicitelefon.Text !=""&& txturunid.Text != "")
            {
                TBLURUNSATIS T = new TBLURUNSATIS();
                T.ALICIADSOYAD = txtaliciadsoyad.Text;
                T.ALICITELEFON = mskalicitelefon.Text;
                T.ALICIADRES = rchaliciadres.Text;
                T.URUNID = byte.Parse(txturunid.Text.ToString());
                T.URUNFIYAT = decimal.Parse(txturunfiyat.Text.ToString());
                T.URUNADET = short.Parse(numericUpDown1.Value.ToString());
                db.TBLURUNSATIS.Add(T);
                db.SaveChanges();
                MessageBox.Show("Ürün satıldı.");
                satislistele();
                urunlistele();
            }
            
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsatisid.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            if (txtsatisid.Text != "")
            {
                int a=Convert.ToInt32(txtsatisid.Text);
                var ktgr = db.TBLURUNSATIS.Find(a);
                db.TBLURUNSATIS.Remove(ktgr);
                db.SaveChanges();
                MessageBox.Show(txtsatisid.Text + " numaralı satış iptal edildi.");
                satislistele();
                urunlistele() ; 
            }
        }
    }
}
