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
using System.Xml.Linq;

namespace PERFORMANS
{
    public partial class frmdersprogrami : Form
    {
        public frmdersprogrami()
        {
            InitializeComponent();
        }
        public string ogretmentc;
        baglantisinif conn=new baglantisinif();
        public int ogretmenid;
        int kacincigun;


        int monday1dersid;
        int monday1sinifid;
        int monday1kayitid;

        int monday2dersid;
        int monday2sinifid;
        int monday2kayitid;

        int monday3dersid;
        int monday3sinifid;
        int monday3kayitid;

        int monday4dersid;
        int monday4sinifid;
        int monday4kayitid;

        int monday5dersid;
        int monday5sinifid;
        int monday5kayitid;

        int monday6dersid;
        int monday6sinifid;
        int monday6kayitid;

        int monday7dersid;
        int monday7sinifid;
        int monday7kayitid;

        int tuesday1dersid;
        int tuesday1sinifid;
        int tuesday1kayitid;

        int tuesday2dersid;
        int tuesday2sinifid;
        int tuesday2kayitid;

        int tuesday3dersid;
        int tuesday3sinifid;
        int tuesday3kayitid;

        int tuesday4dersid;
        int tuesday4sinifid;
        int tuesday4kayitid;

        int tuesday5dersid;
        int tuesday5sinifid;
        int tuesday5kayitid;

        int tuesday6dersid;
        int tuesday6sinifid;
        int tuesday6kayitid;

        int tuesday7dersid;
        int tuesday7sinifid;
        int tuesday7kayitid;

        public string sifrele(string s)
        {
            byte[] sdizi = ASCIIEncoding.ASCII.GetBytes(s);
            string sifreli = Convert.ToBase64String(sdizi);
            return sifreli;
        }

        public string sifrecoz(string s)
        {
            byte[] sdizi = Convert.FromBase64String(s);
            string sifresiz = ASCIIEncoding.ASCII.GetString(sdizi);
            return sifresiz;
        }

        void dersprogramigetir()
        {
            kacincigun = (int)DateTime.Now.DayOfWeek;
            OleDbConnection con = new OleDbConnection(conn.baglan);
            con.Open();
            OleDbCommand komutogrtid = new OleDbCommand("select OGRETMENID FROM TBLOGRETMENLER WHERE TCKIMLIKNO=@P1", con);
            komutogrtid.Parameters.AddWithValue("@P1", sifrele(ogretmentc));
            OleDbDataReader drid = komutogrtid.ExecuteReader();
            while (drid.Read())
            {
                ogretmenid = int.Parse(drid[0].ToString());
            }
            con.Close();
            //pazartesi 1.saat
            con.Open();
            OleDbCommand monday1 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday1.Parameters.AddWithValue("@P1", "Monday");
            monday1.Parameters.AddWithValue("@P2", ogretmenid);
            monday1.Parameters.AddWithValue("@P3", "1");
            OleDbDataReader dr1 = monday1.ExecuteReader();
            while (dr1.Read())
            {
                btnmonday1.Text = dr1[0].ToString()+" " + dr1[3].ToString();
                monday1dersid = int.Parse(dr1[1].ToString());
                monday1sinifid = int.Parse(dr1[2].ToString());
                monday1kayitid = int.Parse(dr1[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday1olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday1olc.Parameters.AddWithValue("@P1", "Monday");
            monday1olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday1olc.Parameters.AddWithValue("@P3", "1");
            OleDbDataReader dr1olc = monday1olc.ExecuteReader();
            while (dr1olc.Read())
            {
                if (dr1olc[0].ToString() == "True")
                {
                    btnmonday1.BackColor = Color.Green;
                }
                else
                {
                    btnmonday1.BackColor = Color.Orange;
                }
            }
            con.Close();
           
            //pazartesi 2.saat



            con.Open();
            OleDbCommand monday2 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday2.Parameters.AddWithValue("@P1", "Monday");
            monday2.Parameters.AddWithValue("@P2", ogretmenid);
            monday2.Parameters.AddWithValue("@P3", "2");
            OleDbDataReader dr2 = monday2.ExecuteReader();
            while (dr2.Read())
            {
                btnmonday2.Text = dr2[0].ToString()+ " " + dr2[3].ToString();
                monday2dersid = int.Parse(dr2[1].ToString());
                monday2sinifid = int.Parse(dr2[2].ToString());
                monday2kayitid = int.Parse(dr2[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday2olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday2olc.Parameters.AddWithValue("@P1", "Monday");
            monday2olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday2olc.Parameters.AddWithValue("@P3", "2");
            OleDbDataReader dr2olc = monday2olc.ExecuteReader();
            while (dr2olc.Read())
            {
                if (dr2olc[0].ToString() == "True")
                {
                    btnmonday2.BackColor = Color.Green;
                }
                else
                {
                    btnmonday2.BackColor = Color.Orange;
                }
            }
            con.Close();
           

            //pazartesi 3.saat



            con.Open();
            OleDbCommand monday3 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday3.Parameters.AddWithValue("@P1", "Monday");
            monday3.Parameters.AddWithValue("@P2", ogretmenid);
            monday3.Parameters.AddWithValue("@P3", "3");
            OleDbDataReader dr3 = monday3.ExecuteReader();
            while (dr3.Read())
            {
                btnmonday3.Text = dr3[0].ToString()+ " " + dr3[3].ToString();
                monday3dersid = int.Parse(dr3[1].ToString());
                monday3sinifid = int.Parse(dr3[2].ToString());
                monday3kayitid = int.Parse(dr3[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday3olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday3olc.Parameters.AddWithValue("@P1", "Monday");
            monday3olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday3olc.Parameters.AddWithValue("@P3", "3");
            OleDbDataReader dr3olc = monday3olc.ExecuteReader();
            while (dr3olc.Read())
            {
                if (dr3olc[0].ToString() == "True")
                {
                    btnmonday3.BackColor = Color.Green;
                }
                else
                {
                    btnmonday3.BackColor = Color.Orange;
                }
            }
            con.Close();
            


            //pazartesi 4.saat



            con.Open();
            OleDbCommand monday4 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday4.Parameters.AddWithValue("@P1", "Monday");
            monday4.Parameters.AddWithValue("@P2", ogretmenid);
            monday4.Parameters.AddWithValue("@P3", "4");
            OleDbDataReader dr4 = monday4.ExecuteReader();
            while (dr4.Read())
            {
                btnmonday4.Text = dr4[0].ToString()+ " " + dr4[3].ToString();
                monday4dersid = int.Parse(dr4[1].ToString());
                monday4sinifid = int.Parse(dr4[2].ToString());
                monday4kayitid = int.Parse(dr4[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday4olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday4olc.Parameters.AddWithValue("@P1", "Monday");
            monday4olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday4olc.Parameters.AddWithValue("@P3", "4");
            OleDbDataReader dr4olc = monday4olc.ExecuteReader();
            while (dr4olc.Read())
            {
                if (dr4olc[0].ToString() == "True")
                {
                    btnmonday4.BackColor = Color.Green;
                }
                else
                {
                    btnmonday4.BackColor = Color.Orange;
                }
            }
            con.Close();

            //pazartesi 5.saat



            con.Open();
            OleDbCommand monday5 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday5.Parameters.AddWithValue("@P1", "Monday");
            monday5.Parameters.AddWithValue("@P2", ogretmenid);
            monday5.Parameters.AddWithValue("@P3", "5");
            OleDbDataReader dr5 = monday5.ExecuteReader();
            while (dr5.Read())
            {
                btnmonday5.Text = dr5[0].ToString() + " " + dr5[3].ToString();
                monday5dersid = int.Parse(dr5[1].ToString());
                monday5sinifid = int.Parse(dr5[2].ToString());
                monday5kayitid = int.Parse(dr5[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday5olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday5olc.Parameters.AddWithValue("@P1", "Monday");
            monday5olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday5olc.Parameters.AddWithValue("@P3", "5");
            OleDbDataReader dr5olc = monday5olc.ExecuteReader();
            while (dr5olc.Read())
            {
                if (dr5olc[0].ToString() == "True")
                {
                    btnmonday5.BackColor = Color.Green;
                }
                else
                {
                    btnmonday5.BackColor = Color.Orange;
                }
            }
            con.Close();


            //pazartesi 6.saat



            con.Open();
            OleDbCommand monday6 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday6.Parameters.AddWithValue("@P1", "Monday");
            monday6.Parameters.AddWithValue("@P2", ogretmenid);
            monday6.Parameters.AddWithValue("@P3", "6");
            OleDbDataReader dr6 = monday6.ExecuteReader();
            while (dr6.Read())
            {
                btnmonday6.Text = dr6[0].ToString() + " " + dr6[3].ToString();
                monday6dersid = int.Parse(dr6[1].ToString());
                monday6sinifid = int.Parse(dr6[2].ToString());
                monday6kayitid = int.Parse(dr6[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday6olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday6olc.Parameters.AddWithValue("@P1", "Monday");
            monday6olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday6olc.Parameters.AddWithValue("@P3", "6");
            OleDbDataReader dr6olc = monday6olc.ExecuteReader();
            while (dr6olc.Read())
            {
                if (dr6olc[0].ToString() == "True")
                {
                    btnmonday6.BackColor = Color.Green;
                }
                else
                {
                    btnmonday6.BackColor = Color.Orange;
                }
            }
            con.Close();

            //pazartesi 7.saat



            con.Open();
            OleDbCommand monday7 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday7.Parameters.AddWithValue("@P1", "Monday");
            monday7.Parameters.AddWithValue("@P2", ogretmenid);
            monday7.Parameters.AddWithValue("@P3", "7");
            OleDbDataReader dr7 = monday7.ExecuteReader();
            while (dr7.Read())
            {
                btnmonday7.Text = dr7[0].ToString() + " " + dr7[3].ToString();
                monday7dersid = int.Parse(dr7[1].ToString());
                monday7sinifid = int.Parse(dr7[2].ToString());
                monday7kayitid = int.Parse(dr7[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand monday7olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday7olc.Parameters.AddWithValue("@P1", "Monday");
            monday7olc.Parameters.AddWithValue("@P2", ogretmenid);
            monday7olc.Parameters.AddWithValue("@P3", "7");
            OleDbDataReader dr7olc = monday7olc.ExecuteReader();
            while (dr7olc.Read())
            {
                if (dr7olc[0].ToString() == "True")
                {
                    btnmonday7.BackColor = Color.Green;
                }
                else
                {
                    btnmonday7.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 1.saat
            con.Open();
            OleDbCommand tuesday1 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday1.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday1.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday1.Parameters.AddWithValue("@P3", "1");
            OleDbDataReader drtuesday1 = tuesday1.ExecuteReader();
            while (drtuesday1.Read())
            {
                btntuesday1.Text = drtuesday1[0].ToString() + " " + drtuesday1[3].ToString();
                tuesday1dersid = int.Parse(drtuesday1[1].ToString());
                tuesday1sinifid = int.Parse(drtuesday1[2].ToString());
                tuesday1kayitid = int.Parse(drtuesday1[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday1olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday1olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday1olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday1olc.Parameters.AddWithValue("@P3", "1");
            OleDbDataReader drtuesday1olc = tuesday1olc.ExecuteReader();
            while (drtuesday1olc.Read())
            {
                if (drtuesday1olc[0].ToString() == "True")
                {
                    btntuesday1.BackColor = Color.Green;
                }
                else
                {
                    btntuesday1.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 2.saat
            con.Open();
            OleDbCommand tuesday2 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday2.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday2.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday2.Parameters.AddWithValue("@P3", "2");
            OleDbDataReader drtuesday2 = tuesday2.ExecuteReader();
            while (drtuesday2.Read())
            {
                btntuesday2.Text = drtuesday2[0].ToString() + " " + drtuesday2[3].ToString();
                tuesday2dersid = int.Parse(drtuesday2[1].ToString());
                tuesday2sinifid = int.Parse(drtuesday2[2].ToString());
                tuesday2kayitid = int.Parse(drtuesday2[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday2olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday2olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday2olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday2olc.Parameters.AddWithValue("@P3", "2");
            OleDbDataReader drtuesday2olc = tuesday2olc.ExecuteReader();
            while (drtuesday2olc.Read())
            {
                if (drtuesday2olc[0].ToString() == "True")
                {
                    btntuesday2.BackColor = Color.Green;
                }
                else
                {
                    btntuesday2.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 3.saat
            con.Open();
            OleDbCommand tuesday3 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday3.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday3.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday3.Parameters.AddWithValue("@P3", "3");
            OleDbDataReader drtuesday3 = tuesday3.ExecuteReader();
            while (drtuesday3.Read())
            {
                btntuesday3.Text = drtuesday3[0].ToString() + " " + drtuesday3[3].ToString();
                tuesday3dersid = int.Parse(drtuesday3[1].ToString());
                tuesday3sinifid = int.Parse(drtuesday3[2].ToString());
                tuesday3kayitid = int.Parse(drtuesday3[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday3olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday3olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday3olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday3olc.Parameters.AddWithValue("@P3", "3");
            OleDbDataReader drtuesday3olc = tuesday3olc.ExecuteReader();
            while (drtuesday3olc.Read())
            {
                if (drtuesday3olc[0].ToString() == "True")
                {
                    btntuesday3.BackColor = Color.Green;
                }
                else
                {
                    btntuesday3.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 4.saat
            con.Open();
            OleDbCommand tuesday4 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday4.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday4.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday4.Parameters.AddWithValue("@P3", "4");
            OleDbDataReader drtuesday4 = tuesday4.ExecuteReader();
            while (drtuesday4.Read())
            {
                btntuesday4.Text = drtuesday4[0].ToString() + " " + drtuesday4[3].ToString();
                tuesday4dersid = int.Parse(drtuesday4[1].ToString());
                tuesday4sinifid = int.Parse(drtuesday4[2].ToString());
                tuesday4kayitid = int.Parse(drtuesday4[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday4olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday4olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday4olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday4olc.Parameters.AddWithValue("@P3", "4");
            OleDbDataReader drtuesday4olc = tuesday4olc.ExecuteReader();
            while (drtuesday4olc.Read())
            {
                if (drtuesday4olc[0].ToString() == "True")
                {
                    btntuesday4.BackColor = Color.Green;
                }
                else
                {
                    btntuesday4.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 5.saat
            con.Open();
            OleDbCommand tuesday5 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday5.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday5.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday5.Parameters.AddWithValue("@P3", "5");
            OleDbDataReader drtuesday5 = tuesday5.ExecuteReader();
            while (drtuesday5.Read())
            {
                btntuesday5.Text = drtuesday5[0].ToString() + " " + drtuesday5[3].ToString();
                tuesday5dersid = int.Parse(drtuesday5[1].ToString());
                tuesday5sinifid = int.Parse(drtuesday5[2].ToString());
                tuesday5kayitid = int.Parse(drtuesday5[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday5olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday5olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday5olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday5olc.Parameters.AddWithValue("@P3", "5");
            OleDbDataReader drtuesday5olc = tuesday5olc.ExecuteReader();
            while (drtuesday5olc.Read())
            {
                if (drtuesday5olc[0].ToString() == "True")
                {
                    btntuesday5.BackColor = Color.Green;
                }
                else
                {
                    btntuesday5.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 6.saat
            con.Open();
            OleDbCommand tuesday6 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday6.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday6.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday6.Parameters.AddWithValue("@P3", "6");
            OleDbDataReader drtuesday6 = tuesday6.ExecuteReader();
            while (drtuesday6.Read())
            {
                btntuesday6.Text = drtuesday6[0].ToString() + " " + drtuesday6[3].ToString();
                tuesday6dersid = int.Parse(drtuesday6[1].ToString());
                tuesday6sinifid = int.Parse(drtuesday6[2].ToString());
                tuesday6kayitid = int.Parse(drtuesday6[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday6olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday6olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday6olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday6olc.Parameters.AddWithValue("@P3", "6");
            OleDbDataReader drtuesday6olc = tuesday6olc.ExecuteReader();
            while (drtuesday6olc.Read())
            {
                if (drtuesday6olc[0].ToString() == "True")
                {
                    btntuesday6.BackColor = Color.Green;
                }
                else
                {
                    btntuesday6.BackColor = Color.Orange;
                }
            }
            con.Close();

            //salı 7.saat
            con.Open();
            OleDbCommand tuesday7 = new OleDbCommand("select BRANSADI, DERS, SINIF,SINIFAD, KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID=TBLDERSPROGRAMI.SINIF WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday7.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday7.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday7.Parameters.AddWithValue("@P3", "7");
            OleDbDataReader drtuesday7 = tuesday7.ExecuteReader();
            while (drtuesday7.Read())
            {
                btntuesday7.Text = drtuesday7[0].ToString() + " " + drtuesday7[3].ToString();
                tuesday7dersid = int.Parse(drtuesday7[1].ToString());
                tuesday7sinifid = int.Parse(drtuesday7[2].ToString());
                tuesday7kayitid = int.Parse(drtuesday7[4].ToString());
            }

            con.Close();
            con.Open();
            OleDbCommand tuesday7olc = new OleDbCommand("select OLCDURUM FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            tuesday7olc.Parameters.AddWithValue("@P1", "Tuesday");
            tuesday7olc.Parameters.AddWithValue("@P2", ogretmenid);
            tuesday7olc.Parameters.AddWithValue("@P3", "7");
            OleDbDataReader drtuesday7olc = tuesday7olc.ExecuteReader();
            while (drtuesday7olc.Read())
            {
                if (drtuesday7olc[0].ToString() == "True")
                {
                    btntuesday7.BackColor = Color.Green;
                }
                else
                {
                    btntuesday7.BackColor = Color.Orange;
                }
            }
            con.Close();
        }
        private void frmdersprogrami_Load(object sender, EventArgs e)
        {
            dersprogramigetir();

        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

       
    }
}
