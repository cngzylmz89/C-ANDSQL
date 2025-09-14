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
    public partial class frmbrans : Form
    {
        public frmbrans()
        {
            InitializeComponent();
        }
        sqlbaglan bgl = new sqlbaglan();
        public void bransgoster()
        {
            SqlCommand komut3 = new SqlCommand("select Bransad from Tbl_branslar", bgl.baglanti());
            SqlDataReader rd3 = komut3.ExecuteReader();
            while(rd3.Read())
            {
                
                cmbbransad.Items.Add(rd3[0]);
            }
            bgl.baglanti().Close();
        }
        public void datagripgor()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("select * from Tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut1 = new SqlCommand("insert into Tbl_branslar (Bransad) values(@b1)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@b1", cmbbransad.Text);
            SqlCommand komut2 = new SqlCommand("select Bransad from Tbl_branslar where Bransid=@b2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b2", txtbransid.Text);
            SqlDataReader rd2 = komut2.ExecuteReader();

            if (rd2.Read())
            {
                MessageBox.Show(cmbbransad.Text + " " + "adı zaten kayıtlı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                komut1.ExecuteNonQuery();
                MessageBox.Show("Brans eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bgl.baglanti().Close();
            cmbbransad.Items.Clear();
            bransgoster();
            datagripgor();
        }

        private void frmbrans_Load(object sender, EventArgs e)
        {
            bransgoster();
            datagripgor();
        }

        private void cmbbransad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("select Bransid from Tbl_branslar where Bransad=@b3", bgl.baglanti());
            komut4.Parameters.AddWithValue("@b3", cmbbransad.Text);
            SqlDataReader rd4 = komut4.ExecuteReader();
            while (rd4.Read())
            {
                txtbransid.Text = rd4[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("delete from Tbl_branslar where Bransad=@b4", bgl.baglanti());
            komut5.Parameters.AddWithValue("@b4", cmbbransad.Text);
            if (cmbbransad.Text != "")
            {
                komut5.ExecuteNonQuery();
                MessageBox.Show("Brans silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
            cmbbransad.Items.Clear();
            bransgoster();
            datagripgor();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("update Tbl_branslar set Bransad=@b5 where Bransid=@i1", bgl.baglanti());
            komut6.Parameters.AddWithValue("@b5", cmbbransad.Text);
            komut6.Parameters.AddWithValue("@i1", txtbransid.Text);
            if (cmbbransad.Text != "")
            {
                komut6.ExecuteNonQuery();
                MessageBox.Show("Brans güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
            cmbbransad.Items.Clear();
            bransgoster();
            datagripgor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            txtbransid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            cmbbransad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
        }



        
    }
}
