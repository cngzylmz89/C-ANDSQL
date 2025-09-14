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
    public partial class frmsekretergiris : Form
    {
        public frmsekretergiris()
        {
            InitializeComponent();
        }

        genel gnl = new genel();
        
        public void git()
        {
            frmsekreterdetay frmsek = new frmsekreterdetay();
            frmsek.sektcno = msksekretertc.Text;
            frmsek.Hide();
            frmsek.Show();

        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            frm.Show();
            this.Hide();
        }
        string capt;
        
        private void frmsekretergiris_Load(object sender, EventArgs e)
        {
            genel gnl = new genel();
            lblcaptca.Text = gnl.captcha(capt).ToString(); 
            
            
        }

        private void btncaptchadegistir_Click(object sender, EventArgs e)
        {
            lblcaptca.Text = gnl.captcha(capt).ToString();
        }

        private void lnkkayitol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsekreterkayit frmsekreterkay = new frmsekreterkayit();
            frmsekreterkay.Show();
            
        }
        sqlbaglan bgl = new sqlbaglan();
       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("select * from Tbl_sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            
            giris.Parameters.AddWithValue("@p1", msksekretertc.Text);
            giris.Parameters.AddWithValue("@p2", txtsekretersifre.Text);
            SqlDataReader komutgiris=giris.ExecuteReader();
            if (msksekretertc.Text != "" || txtsekretersifre.Text != "")
            {
                if (komutgiris.Read())
                {
                    if(captchasekreter.Text==lblcaptca.Text)
                    {
                        frmsekreterdetay frmsek = new frmsekreterdetay();
                        frmsek.sektcno = msksekretertc.Text;

                        frmsek.Show();
                        this.Visible=false;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen doğrulama kodunu doğru giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("TC kimlik numarası veya şifrenizi yanlış girdiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msksekretertc.Text = "";
                    txtsekretersifre.Text = "";
                    msksekretertc.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("TC kimlik numarası veya şifrenizi yanlış girdiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msksekretertc.Text = "";
                txtsekretersifre.Text = "";
                msksekretertc.Focus();

            }
            
        }

        
    }
}
