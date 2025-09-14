using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.OleDb;

namespace SQLSORGULARICALISTIRMA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }
        string db;
        string adres;




        private void button1_Click(object sender, EventArgs e)
        {
            db = textBox1.Text;
            adres= @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CENGİZ\Desktop\PERFORMANSISTEMI.accdb";
            //
            //Data Source=.;Initial Catalog=" + db + ";Integrated Security=True;Encrypt=False
            if (textBox1.Text !="")
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection(adres);
                    string komut = richTextBox1.Text;
                    baglanti.Open();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                }
                catch (Exception HATA)
                {

                    MessageBox.Show(HATA.ToString());
                }
                
                
            }
            else
            {
                MessageBox.Show("Lütfen database giriniz.");
            }

            
        }
    }
}

