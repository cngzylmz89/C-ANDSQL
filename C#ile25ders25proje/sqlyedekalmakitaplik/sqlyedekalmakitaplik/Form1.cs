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

namespace sqlyedekalmakitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=SQLYEDEKALMAKITAP;Integrated Security=True;Encrypt=False");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblkıtapbılgı", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.Open();
            SqlCommand komutsayac = new SqlCommand("select * from KITAPSAYAC", bgl);
            SqlDataReader rd = komutsayac.ExecuteReader();
            while (rd.Read())
            {
                int a = Convert.ToInt16(rd[0]);
                label6.Text =(a-1).ToString() ;
            }
            bgl.Close();

            txtkitapid.Text = "";
            txtkitabinadi.Text = "";
            txtkitabinyazari.Text = "";
            txtkitabinyayinevi.Text = "";
            txtsayfasayisi.Text = "";

            txtkitapid.Focus();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kitapkayit = new SqlCommand("insert into TBLKITAPBILGI (KITAPAD, KITAPYAZAR, KITAPYAYINEVI, KITAPSAYFA) VALUES(@P1,@P2,@P3,@P4)", bgl);
            kitapkayit.Parameters.AddWithValue("@P1", txtkitabinadi.Text);
            kitapkayit.Parameters.AddWithValue("@P2", txtkitabinyazari.Text);
            kitapkayit.Parameters.AddWithValue("@P3", txtkitabinyayinevi.Text);
            kitapkayit.Parameters.AddWithValue("@P4", txtsayfasayisi.Text);
            DialogResult result1 = MessageBox.Show(txtkitabinadi.Text + " adlı kitap kaydedilecek onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (txtkitabinadi.Text != "" && txtkitabinyazari.Text != "" && txtkitabinyayinevi.Text != "" && txtsayfasayisi.Text != ""&&result1==DialogResult.Yes)
            {
                kitapkayit.ExecuteNonQuery();
                MessageBox.Show("Kitap kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else { MessageBox.Show("Lütfen ilgili yerleri doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            bgl.Close();
            listele();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkitapid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkitabinadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtkitabinyazari.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtkitabinyayinevi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsayfasayisi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komutsil = new SqlCommand("delete from TBLKITAPBILGI WHERE ID=" + txtkitapid.Text, bgl);
            DialogResult result2 = MessageBox.Show(txtkitapid.Text + " numaralı kitap silinecek. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtkitapid.Text != ""&& result2==DialogResult.Yes)
            {
                komutsil.ExecuteNonQuery();
                MessageBox.Show(txtkitapid.Text + " id numaralı kitap silindi.");
            }
            bgl.Close();
            
            listele();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(button1.Text=="KİTAP LİSTESİ")
            {
                groupBox2.Text = "KİTAP LİSTESİ";
                button1.Text = "SİLİNENLER LİSTESİ";
                SqlDataAdapter da = new SqlDataAdapter("select * from tblkıtapbılgı", bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            else if(button1.Text=="SİLİNENLER LİSTESİ")
            {
                groupBox2.Text = "SİLİNENLER LİSTESİ";
                button1.Text = "KİTAP LİSTESİ";

                SqlDataAdapter da2 = new SqlDataAdapter("select * from KITAPYEDEK", bgl);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
        }
    }
}
