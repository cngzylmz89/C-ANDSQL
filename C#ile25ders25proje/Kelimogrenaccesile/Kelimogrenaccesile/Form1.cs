using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kelimogrenaccesile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CENGİZ\Desktop\c#allproject\C#ile25ders25proje\Kelimogrenaccesile\dbSozluk.accdb");
        public string adısoyadı;
        
            
private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into KULLANICI (ADISOYADI) VALUES(@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            OleDbCommand komut1 = new OleDbCommand("select ADISOYADI from KULLANICI  WHERE ADISOYADI=@P2", baglanti);
            komut1.Parameters.AddWithValue("@P2", textBox1.Text);
            OleDbDataReader rd = komut1.ExecuteReader();
            if (rd.Read() == false)
            {
                komut.ExecuteNonQuery();

                

            }
            else
            {
                Form2 fr = new Form2();
                fr.adısoyadı = textBox1.Text;
                fr.Show();
                this.Hide();

            }
            

            baglanti.Close();
        }
    }
}
