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
        private void frmdersprogrami_Load(object sender, EventArgs e)
        {
            kacincigun = (int)DateTime.Now.DayOfWeek;
            OleDbConnection con=new OleDbConnection(conn.baglan);
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
           OleDbCommand monday1=new OleDbCommand("select BRANSADI, DERS, SINIF, KAYITID FROM TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLDERSPROGRAMI.DERS=TBLBRANSLAR.BRANSID WHERE  TARIH=@P1 AND OGRETMEN=@P2 AND DERSSAATI=@P3", con);
            monday1.Parameters.AddWithValue("@P1", "Monday");
            monday1.Parameters.AddWithValue("@P2", ogretmenid);
            monday1.Parameters.AddWithValue("@P3", "1");
            OleDbDataReader dr1 = monday1.ExecuteReader();
            while (dr1.Read())
            {
                btnmonday1.Text = dr1[0].ToString();
                monday1dersid = int.Parse(dr1[1].ToString());
                monday1sinifid = int.Parse(dr1[2].ToString());
                monday1kayitid = int.Parse(dr1[3].ToString());
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
            con.Open();
            if (monday1dersid  != null&&monday1sinifid!=null)
            {
                OleDbCommand sonders = new OleDbCommand("SELECT TOP 1 GUNID, BRANSADI,  KAYITID FROM (TBLDERSPROGRAMI INNER JOIN TBLBRANSLAR ON TBLBRANSLAR.BRANSID=TBLDERSPROGRAMI.DERS) INNER JOIN TBLGUN ON TBLGUN.HAFTANINGUNU=TBLDERSPROGRAMI.TARIH WHERE OGRETMEN=@P1 AND SINIF=@P2 AND DERS=@P3 ORDER BY GUNID DESC ", con);
                sonders.Parameters.AddWithValue("@P1", ogretmenid);
                sonders.Parameters.AddWithValue("@P2", monday1sinifid);
                sonders.Parameters.AddWithValue("@P3", monday1dersid);
                OleDbDataReader drsonders = sonders.ExecuteReader();
                while (drsonders.Read())
                {
                    if(monday1kayitid==int.Parse(drsonders[2].ToString()))
                    {
                        btnmonday1.BackColor = Color.Red;
                        btnmonday1.Text = drsonders[1].ToString() + "  (SON DERS) ";
                    }
                }

            }


        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }
    }
}
