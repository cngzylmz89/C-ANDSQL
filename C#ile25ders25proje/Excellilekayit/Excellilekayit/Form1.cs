using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Excellilekayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CENGİZ\Desktop\OGRENCIKAYIT.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';");
        //BAGLANTI ADRESİNİ  https://www.connectionstrings.com/excel/ adresinden alıyoruz. Datasource  kısmını excell dosyamızın dosya yolundan alıp yapıştırıyoruz. Properties kısmı tek tınakla olacak.

        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select *  from [SAYFA1$]", bgl);
            //oledb ile aynı özelliklere sahip. SADECE tablo ismini sayfa adını yukarıdaki yazıyoruz.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            bgl.Open();
            OleDbCommand komutsayioku = new OleDbCommand("select count(*) from [SAYFA1$]", bgl);
            OleDbDataReader dr = komutsayioku.ExecuteReader();
            while (dr.Read())
            {
                kayitsayi= int.Parse(dr[0].ToString())+1;
            }
            bgl.Close();
        }
        int kayitsayi;
        private void btnkaydet_Click(object sender, EventArgs e)
        {


            bgl.Open();

            OleDbCommand komutkaydet = new OleDbCommand("insert into [SAYFA1$] (SIRANO,ADISOYADI, BABAADI, ANNEADI, TELNO, ADRES) values(@P0,@P1,@P2,@P3,@P4,@P5)", bgl);
            komutkaydet.Parameters.AddWithValue("@P0", kayitsayi);
            komutkaydet.Parameters.AddWithValue("@P1", txtadisoyadi.Text);
            komutkaydet.Parameters.AddWithValue("@P2", txtbabaadi.Text);
            komutkaydet.Parameters.AddWithValue("@P3", txtanneadi.Text);
            komutkaydet.Parameters.AddWithValue("@P4", txttelno.Text);
            komutkaydet.Parameters.AddWithValue("@P5", rchadres.Text);
            DialogResult result1 = MessageBox.Show(txtadisoyadi.Text + " adlı öğrenci kaydedilecek. Onaylıyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtadisoyadi.Text != "" && txtbabaadi.Text != "" && txtanneadi.Text != "" && txttelno.Text != "" && rchadres.Text != "" && result1 == DialogResult.Yes)
            {
                komutkaydet.ExecuteNonQuery();
                MessageBox.Show("Öğrenci kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen ilgili yerleri doldurunuz.");


                bgl.Close();
            }
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsirano.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtadisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbabaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtanneadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttelno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            rchadres.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            secsirano=int.Parse(txtsirano.Text);
        }
        int secsirano;
        private void btnsil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            OleDbCommand komutsil = new OleDbCommand("UPDATE [SAYFA1$] SET ADISOYADI=@a1, BABAADI=@a2, ANNEADI=@a3, TELNO=@a4, ADRES=@a5 WHERE SIRANO=@p1", bgl);
            komutsil.Parameters.AddWithValue("@p1",int.Parse(txtsirano.Text));
            komutsil.Parameters.AddWithValue("@a1", txtadisoyadi.Text);
            komutsil.Parameters.AddWithValue("@a2", txtbabaadi.Text);
            komutsil.Parameters.AddWithValue("@a3", txtanneadi.Text);
            komutsil.Parameters.AddWithValue("@a4", txttelno.Text);
            komutsil.Parameters.AddWithValue("@a5", rchadres.Text);

            DialogResult result= MessageBox.Show(txtsirano.Text + " sıra numaralı öğrenci silinecek. Onaylıyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtsirano.Text != ""&&result==DialogResult.Yes)
            {
                komutsil.ExecuteNonQuery(); 
            }
            
            bgl.Close();
            listele();
        }
    }
    }

