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
    public partial class frmkulup : Form
    {
        public frmkulup()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=OKULBONUS;Integrated Security=True");
        public void listele()
        {
            bgl.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLKULUPLER", bgl);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.Close();
        }
        private void frmkulup_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // e datagridin cursor olan yani farenin üzerinde olduğu yerdir. e.RowIndex üzerinde
            //olunan yerin sıra indeksi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand insert = new SqlCommand("insert into TBLKULUPLER (KULUPAD) values(@a1)", bgl);
            insert.Parameters.AddWithValue("@a1", txtkulupad.Text);
            DialogResult result1 = MessageBox.Show("Kulüp kaydedilecek onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                try
                {
                    insert.ExecuteNonQuery();
                MessageBox.Show("Kulüp kaydedildi", "Bilgi");
                }
                catch (Exception hata)
                {
                    
                    MessageBox.Show(hata.ToString());
                }
                
            }

            bgl.Close();
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand update = new SqlCommand("update TBLKULUPLER set KULUPAD=@a1 where KULUPID=@a2", bgl);
            update.Parameters.AddWithValue("@a2", mskid.Text);
            update.Parameters.AddWithValue("@a1", txtkulupad.Text);
            DialogResult result1 = MessageBox.Show("Kulüp güncellenecek. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Kulüp güncellendi", "Bilgi");
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.ToString());
                }
                
            }
                

            bgl.Close();
            listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand delete = new SqlCommand("delete from TBLKULUPLER where KULUPID=@k1", bgl);
            delete.Parameters.AddWithValue("@k1", mskid.Text);
            DialogResult result3 = MessageBox.Show("Kulüp silinecek. Onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result3 == DialogResult.Yes)
            {
                try
                {
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Kulüp silindi.", "Bilgi");
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                    
                }
                
            }

            bgl.Close();
            listele();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
