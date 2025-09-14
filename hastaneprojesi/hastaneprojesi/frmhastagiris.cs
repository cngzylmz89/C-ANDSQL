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
    public partial class frmhastagiris : Form
    {
        public frmhastagiris()
        {
            InitializeComponent();
        }
        string cpthasta;
        private void frmhastagiris_Load(object sender, EventArgs e)
        {
            genel gnl = new genel();
            lblcaptchahasta.Text = gnl.captcha(cpthasta);
            
        }
        sqlbaglan bgl = new sqlbaglan();

        private void btncaptchadegistir_Click(object sender, EventArgs e)
        {
            genel gnl = new genel();
            lblcaptchahasta.Text = gnl.captcha(cpthasta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmgiris frmgiris = new frmgiris();
            frmgiris.Show();
            this.Hide();
        }

        private void lnklbluyeol_MouseHover(object sender, EventArgs e)
        {
            lnklbluyeol.BackColor = Color.Yellow;

        }

        private void lnklbluyeol_MouseLeave(object sender, EventArgs e)
        {
            lnklbluyeol.BackColor = Color.Azure;
        }

        private void lnklbluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayit frmhskyt = new frmhastakayit();
            frmhskyt.Show();
            this.Hide();
        }
        frmhastadetay hstdty = new frmhastadetay();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmtgiris = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1 and Hastasifre=@p2", bgl.baglanti());
            kmtgiris.Parameters.AddWithValue("@p1", txthastatc.Text);
            kmtgiris.Parameters.AddWithValue("@p2", txthastasifre.Text);
            SqlDataReader kmtgirisrd = kmtgiris.ExecuteReader();
            if (kmtgirisrd.Read())
            {
               if(captchahasta.Text==lblcaptchahasta.Text)
               {
                   hstdty.tc = txthastatc.Text;
                   hstdty.Show();
                   this.Hide();
               }
               else
               {
                   MessageBox.Show("Lütfen doğrulama kodunu eksiksiz giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   captchahasta.Text = "";
               }
                
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthastasifre.Text = "";
                txthastatc.Text = "";
                txthastatc.Focus();
            }
            bgl.baglanti().Close();
        }

        
    }
}
