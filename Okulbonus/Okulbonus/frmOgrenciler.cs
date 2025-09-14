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
    public partial class frmOgrenciler : Form
    {
        public frmOgrenciler()
        {
            InitializeComponent();
        }
        void cinsiyet()
        {
            if (rdyerkek.Checked == true)
            {
                c = "ERKEK";
            }
            if (rdykiz.Checked == true)
            {
                c = "KIZ";
            }
        }
        void liste()
        {
            dataGridView3.DataSource = ds.ÖĞRENCİLİSTELE();
            dataGridView3.Columns["OGRKULUP"].Visible = false;//OGRKULUP columunu gizliyoruz
            dataGridView3.Columns["OGRID"].HeaderText = "ÖĞRENCİ İD";//columun textini değiştirir.

            dataGridView3.Columns["OGRAD"].HeaderText = "ÖĞRENCİ ADI";
            dataGridView3.Columns["OGRSOYAD"].HeaderText = "ÖĞRENCİ SOYAD";
            dataGridView3.Columns["OGRCİNSİYET"].HeaderText = "ÖĞRENCİ CİNSİYETİ";
            dataGridView3.Columns["KULUPAD"].HeaderText = "ÖĞRENCİ KULÜBÜ";
        }
        private void rdyerkek_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Erkek";
        }

        private void rdykiz_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "Kız";
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmOgretmen frm = new frmOgretmen();
            frm.Show();
            this.Close();
        }
        SqlConnection bgl = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=OKULBONUS;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void frmOgrenciler_Load(object sender, EventArgs e)
        {
            liste();
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULUPLER", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbkulup.DisplayMember = "KULUPAD";//comboxta görünen öge adı
            cmbkulup.ValueMember = "KULUPID";// comboxta arkaplanda dönen değer tablodaki hangi sütundan
            cmbkulup.DataSource = dt;
            bgl.Close();
        }
        string c = "";
        private void btnogrenciekle_Click(object sender, EventArgs e)
        {
            cinsiyet();
            ds.OgrenciEkle(txtogrenciadi.Text, txtogrencisoyad.Text, byte.Parse(cmbkulup.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci eklendi.");
            liste();

        }

        private void btnogrencisil_Click(object sender, EventArgs e)
        {
            if (mskogrenciid.Text != "")
            {
                ds.OgrenciSil(Convert.ToInt16(mskogrenciid.Text));
                MessageBox.Show("Öğrenci silindi");

            }
            else
            {
                MessageBox.Show("Lütfen öğrenci seçiniz.");
            }
            liste();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskogrenciid.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtogrenciadi.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtogrencisoyad.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbkulup.SelectedValue = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString() == "ERKEK")
            {
                rdyerkek.Checked = true;
            }
            if (dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString() == "KIZ")
            {
                rdykiz.Checked = true;
            }
            cinsiyet();
        }

        private void btnogrenciguncelle_Click(object sender, EventArgs e)
        {
            cinsiyet();
            if (mskogrenciid.Text != "")
            {
                ds.OgrenciGuncelle(txtogrenciadi.Text, txtogrencisoyad.Text, byte.Parse(cmbkulup.SelectedValue.ToString()), c, int.Parse(mskogrenciid.Text));
                MessageBox.Show("Öğrenci bilgileri güncellendi");
                liste();
            }


        }

        private void btnogrenciara_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = ds.OgrenciGet(txtara.Text);
        }




        private void txtara_TextChanged(object sender, EventArgs e)
        {
            bgl.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLOGRENCILER where OGRAD like '%" + txtara.Text + "%'", bgl);
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
            bgl.Close();
        }

        
    }
}
