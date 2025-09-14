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

namespace YAKITPROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=.;Initial Catalog=TESTBENZIN;Integrated Security=True;Encrypt=False");

        private Label GetLblkursunsuz95()
        {
            return lblkursunsuz95;
        }

        void listeleyakitfiyat(Label lblkursunsuz95)
        {
            //KURŞUNSUZ95
            bgl.Open();
            SqlCommand komutfiyat = new SqlCommand("select  SATISFIYAT, STOK from TBLBENZIN WHERE ID=1", bgl);
            SqlDataReader dr = komutfiyat.ExecuteReader();
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[0].ToString();
                prgbarkrsnsz95.Value =Convert.ToInt32( dr[1]);
                lbldepo95.Text = dr[1].ToString();

            }
            bgl.Close();
            
            //kurşunsuz97
            bgl.Open();
            SqlCommand komutfiyat2 = new SqlCommand("select  SATISFIYAT,STOK from TBLBENZIN WHERE ID=4", bgl);
            SqlDataReader dr2 = komutfiyat2.ExecuteReader();
            while (dr2.Read())
            {
                lblkursunsuz97.Text = dr2[0].ToString();
                prgbarkrsnsz97.Value = Convert.ToInt32(dr2[1]);
                lbldepo97.Text = dr2[1].ToString();

            }
            bgl.Close();

            //eurodizel
            bgl.Open();
            SqlCommand komutfiyat3 = new SqlCommand("select  SATISFIYAT,STOK from TBLBENZIN WHERE ID=5", bgl);
            SqlDataReader dr3 = komutfiyat3.ExecuteReader();
            while (dr3.Read())
            {
                lbleurodizel10.Text = dr3[0].ToString();
                prgbareurodizel.Value = Convert.ToInt32(dr3[1]);
                lbldepoeuro10.Text = dr3[1].ToString();

            }
            bgl.Close();
            //yeni pro dizel

            bgl.Open();
            SqlCommand komutfiyat4 = new SqlCommand("select  SATISFIYAT, STOK from TBLBENZIN WHERE ID=2", bgl);
            SqlDataReader dr4 = komutfiyat4.ExecuteReader();
            while (dr4.Read())
            {
                lblyeniprodizel.Text = dr4[0].ToString();
                prgbarprodizel.Value = Convert.ToInt32(dr4[1]);
                lbldepoprodizel.Text = dr4[1].ToString();

            }
            bgl.Close();

            //gaz
            bgl.Open();
            SqlCommand komutfiyat5 = new SqlCommand("select  SATISFIYAT, STOK from TBLBENZIN WHERE ID=3", bgl);
            SqlDataReader dr5 = komutfiyat5.ExecuteReader();
            while (dr5.Read())
            {
                lblgaz.Text = dr5[0].ToString();
                prgbargaz.Value = Convert.ToInt32(dr5[1]);
                lbldepogaz.Text = dr5[1].ToString();

            }
            bgl.Close();

            bgl.Open();
            SqlCommand kasa = new SqlCommand("select  * from TBLKASA", bgl);
            SqlDataReader dr6 = kasa.ExecuteReader();
            while (dr6.Read())
            {
                lblkasa.Text = dr6[0].ToString();
                

            }
            bgl.Close();
        }           
        private void Form1_Load(object sender, EventArgs e)
        {
            listeleyakitfiyat(GetLblkursunsuz95());

            SqlDataAdapter da = new SqlDataAdapter("select PETROLTUR FROM TBLBENZIN", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "PETROLTUR";
            comboBox1.DisplayMember = "PETROLTUR";
            comboBox1.DataSource = dt;
        }

        public object litredegis(NumericUpDown nm, MaskedTextBox msk, Label lbl)
        {
            decimal fiyat, litre,  sonuc;

            fiyat=decimal.Parse(lbl.Text);
            litre=decimal.Parse(nm.Text);
            msk.Text = (((litre-1) * fiyat)/100).ToString();           
            return msk.Text;


        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            litredegis(numericUpDown1, mskkursunsuz95tutar, lblkursunsuz95);
        }

        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            bgl.Open();
            if(txtplaka.Text.Length <=10 && txtplaka.Text!="")
            
                {
                SqlCommand yakitkaydet = new SqlCommand("insert into TBLHAREKET (PLAKA, BENZINTURU, LITRE, FIYAT) VALUES(@P1,@P2,@P3,@P4)", bgl);
                if (numericUpDown1.Value > 0)
                {
                    yakitkaydet.Parameters.AddWithValue("@P1", txtplaka.Text);
                    yakitkaydet.Parameters.AddWithValue("@P2", "KURŞUNSUZ95");
                    yakitkaydet.Parameters.AddWithValue("@P3", numericUpDown1.Value);
                    yakitkaydet.Parameters.AddWithValue("@P4", mskkursunsuz95tutar.Text);
                    yakitkaydet.ExecuteNonQuery();
                    MessageBox.Show("Depo dolduruldu.");
                }
                else if (numericUpDown2.Value > 0)
                {
                    yakitkaydet.Parameters.AddWithValue("@P1", txtplaka.Text);
                    yakitkaydet.Parameters.AddWithValue("@P2", "KURŞUNSUZ97");
                    yakitkaydet.Parameters.AddWithValue("@P3", numericUpDown2.Value);
                    yakitkaydet.Parameters.AddWithValue("@P4", mskkursunsuz97tutar.Text);
                    yakitkaydet.ExecuteNonQuery();
                    MessageBox.Show("Depo dolduruldu.");

                }
                else if (numericUpDown3.Value > 0)
                {
                    yakitkaydet.Parameters.AddWithValue("@P1", txtplaka.Text);
                    yakitkaydet.Parameters.AddWithValue("@P2", "EURODIZEL10");
                    yakitkaydet.Parameters.AddWithValue("@P3", numericUpDown3.Value);
                    yakitkaydet.Parameters.AddWithValue("@P4", mskeurodizel10tutar.Text);
                    yakitkaydet.ExecuteNonQuery();
                    MessageBox.Show("Depo dolduruldu.");

                }
                else if (numericUpDown4.Value > 0)
                {
                    yakitkaydet.Parameters.AddWithValue("@P1", txtplaka.Text);
                    yakitkaydet.Parameters.AddWithValue("@P2", "YENIPRODIZEL");
                    yakitkaydet.Parameters.AddWithValue("@P3", numericUpDown4.Value);
                    yakitkaydet.Parameters.AddWithValue("@P4", mskyeniprodizeltutar.Text);
                    yakitkaydet.ExecuteNonQuery();
                    MessageBox.Show("Depo dolduruldu.");

                }
                else if (numericUpDown5.Value > 0)
                {
                    yakitkaydet.Parameters.AddWithValue("@P1", txtplaka.Text);
                    yakitkaydet.Parameters.AddWithValue("@P2", "GAZYAĞI");
                    yakitkaydet.Parameters.AddWithValue("@P3", numericUpDown5.Value);
                    yakitkaydet.Parameters.AddWithValue("@P4", mskgaztutar.Text);
                    yakitkaydet.ExecuteNonQuery();
                    MessageBox.Show("Depo dolduruldu.");

                }

            }
            bgl.Close();
            listeleyakitfiyat(GetLblkursunsuz95());
           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            litredegis(numericUpDown2, mskkursunsuz97tutar, lblkursunsuz97);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            litredegis(numericUpDown3, mskeurodizel10tutar, lbleurodizel10);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            litredegis(numericUpDown4, mskyeniprodizeltutar, lblyeniprodizel);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            litredegis(numericUpDown5, mskgaztutar, lblgaz);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komutyakit = new SqlCommand("INSERT INTO TBLDEPO (YAKITTUR, TOPLAMSTOK) VALUES(@P1,@P2)", bgl);
            komutyakit.Parameters.AddWithValue("@P2", numericUpDown6.Value);
            komutyakit.Parameters.AddWithValue("@P1", comboBox1.Text);
            if (comboBox1.Text != "")
            {
                switch (comboBox1.Text)
                {
                    case "KURŞUNSUZ95":
                        if ((prgbarkrsnsz95.Value+numericUpDown6.Value)<= 10000)
                        {
                            komutyakit.ExecuteNonQuery();
                            MessageBox.Show("YAKIT ALINDI");
                        }
                        else
                        {
                            MessageBox.Show("ALINAN YAKIT İLE TAM DOLULUK DURUMU AŞILIYOR.");
                        }
                            break;
                    case "KURŞUNSUZ97":
                        if ((prgbarkrsnsz97.Value + numericUpDown6.Value) <= 10000)
                        {
                            komutyakit.ExecuteNonQuery();
                            MessageBox.Show("YAKIT ALINDI");
                        }
                        else
                        {
                            MessageBox.Show("ALINAN YAKIT İLE TAM DOLULUK DURUMU AŞILIYOR.");
                        }
                        break;
                    case "YENIPRODIZEL":
                        if ((prgbarprodizel.Value + numericUpDown6.Value) <= 10000)
                        {
                            komutyakit.ExecuteNonQuery();
                            MessageBox.Show("YAKIT ALINDI");
                        }
                        else
                        {
                            MessageBox.Show("ALINAN YAKIT İLE TAM DOLULUK DURUMU AŞILIYOR.");
                        }
                        break;
                    case "EURODIZEL10":
                        if ((prgbareurodizel.Value + numericUpDown6.Value) <= 10000)
                        {
                            komutyakit.ExecuteNonQuery();
                            MessageBox.Show("YAKIT ALINDI");
                        }
                        else
                        {
                            MessageBox.Show("ALINAN YAKIT İLE TAM DOLULUK DURUMU AŞILIYOR.");
                        }
                        break;
                    case "GAZYAĞI":
                        if ((prgbargaz.Value + numericUpDown6.Value) <= 10000)
                        {
                            komutyakit.ExecuteNonQuery();
                            MessageBox.Show("YAKIT ALINDI");
                        }
                        else
                        {
                            MessageBox.Show("ALINAN YAKIT İLE TAM DOLULUK DURUMU AŞILIYOR.");
                        }
                        break;

                }

               
                
                
               
            }
            bgl.Close();
            listeleyakitfiyat(GetLblkursunsuz95());
        }
    }
}