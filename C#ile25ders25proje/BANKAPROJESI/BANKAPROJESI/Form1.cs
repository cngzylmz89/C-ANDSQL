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

namespace BANKAPROJESI
{
    public partial class Form1 : Form
    {
        BANKAMATIKEntities2 db = new BANKAMATIKEntities2();
        public Form1()
        {
            InitializeComponent();
        }
        connect baglan = new connect();

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komutoku = new SqlCommand("select * FROM TBLKISILER WHERE HESAPNO=@P1 AND SIFRE=@P2", baglan.baglanti());
            komutoku.Parameters.AddWithValue("@P1", txthesapno.Text);
            komutoku.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader rd = komutoku.ExecuteReader();
            if (rd.Read())
            {
                Form2 fr = new Form2();
                fr.hesapno = txthesapno.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            

            
        }

        private void lnkkaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sorgu = (from x in db.TBLKISILER where x.HESAPNO == int.Parse(txthesapno.Text.ToString()) select x);
            try
            {
                if (txthesapno.Text != "")
                {
                    if (sorgu.Any() != true)
                    {
                        Form3 fr = new Form3();
                        fr.Show();
                        this.Hide();
                    }
                    else
                    {

                        MessageBox.Show("Kullanıcı kaydı zaten var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            

           
        }
    }
}