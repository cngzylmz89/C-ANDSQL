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
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglan bgl = new sqlbaglan();
        
        frmdoktordetay frmdr = new frmdoktordetay();
        
       
        
        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmtgiris = new SqlCommand("select * from Tbl_doktorlar where Doktortc=@p1 and Doktorsifre=@p2", bgl.baglanti());
            kmtgiris.Parameters.AddWithValue("@p1", txtdoktortc.Text);
            kmtgiris.Parameters.AddWithValue("@p2", txtdoktorsifre.Text);
            SqlDataReader rdgiris = kmtgiris.ExecuteReader();
            if ( txtdoktorsifre.Text!="" && txtdoktortc.Text!="")
            {
                if (rdgiris.Read()  )
                {
                    frmdoktordetay frm = new frmdoktordetay();
                    frm.doktortc = txtdoktortc.Text;
                    frm.Show();
                    this.Hide();
               }
                else
                {

                    MessageBox.Show("Kullanıcı bulunamadı. Lütfen bilgirinizi doğru girdiğinizden emin olunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdoktortc.Text = "";
                    txtdoktorsifre.Text = "";
                    txtdoktortc.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı ve şifrenizi giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdoktortc.Text = "";
                txtdoktorsifre.Text = "";
                txtdoktortc.Focus();
            }
            bgl.baglanti().Close();


        }



        public string s { get; set; }

        
    }
}
