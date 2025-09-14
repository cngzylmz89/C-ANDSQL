using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace sinemafilmarsiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilmArsivimEntities db = new FilmArsivimEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=CNGZSLMAYSNR\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True;Encrypt=False");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLFILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //var filmler=db.TBLFILMLER.ToList();
            //dataGridView1.DataSource = filmler;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void rchlink_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    listele();
            //    if (txtfimad.Text != "" && txtkategori.Text != "" && rchlink.Text != "")
            //    {
            //        TBLFILMLER TT = new TBLFILMLER();
            //        TT.AD = txtfimad.Text;
            //        TT.KATEGORI = txtkategori.Text;
            //        TT.LINK = rchlink.Text;
            //        db.TBLFILMLER.Add(TT);
            //        db.SaveChanges();
            //        MessageBox.Show("Film eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lütfen ilgili yerleri doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}

            
            if (e.KeyCode == Keys.Enter)
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into TBLFILMLER (AD, KATEGORI, LINK) VALUES(@P1, @P2, @P3)", baglanti);
                komutkaydet.Parameters.AddWithValue("@P1", txtfimad.Text);
                komutkaydet.Parameters.AddWithValue("@P2", txtkategori.Text);
                komutkaydet.Parameters.AddWithValue("@P3", rchlink.Text);
                if (txtfimad.Text != "" && txtkategori.Text != "" && rchlink.Text != "")
                {
                    komutkaydet.ExecuteNonQuery();
                    MessageBox.Show("Film eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lütfen ilgili yerleri doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
                listele();
            }
            
        }
        string link;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            link = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
            

        }
        
        private void btntamekran_Click(object sender, EventArgs e)
        {
            if (link != "")
            {
                tamekran fr = new tamekran();
                fr.tam = link;
                fr.Show();
            }
            
        }
        
        private void bntrenkdegistir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a;
            a = rnd.Next(1, 10);

            switch (a)
            {
                case 1:this.BackColor = Color.Yellow;
                    break;
                case 2: this.BackColor = Color.Red;
                    break;
                case 3: this.BackColor = Color.Purple;
                    break;
                case 4:
                    this.BackColor = Color.PowderBlue;
                    break;
                case 5:
                    this.BackColor = Color.RoyalBlue;
                    break;
                case 6:
                    this.BackColor = Color.SaddleBrown;
                    break;
                case 7:
                    this.BackColor = Color.Sienna;
                    break;
                case 8:
                    this.BackColor = Color.Snow;
                    break;
                case 9:
                    this.BackColor = Color.SpringGreen;
                    break;
                case 10:
                    this.BackColor = Color.Teal;
                    break;

            }

        }

        private void btnhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Cengiz YILMAZ tarafından 04/07/2025 yılında kodlanmıştır.");
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
