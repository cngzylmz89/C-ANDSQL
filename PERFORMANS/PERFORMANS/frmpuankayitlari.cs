using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PERFORMANS
{
    public partial class frmpuankayitlari : Form
    {
        public frmpuankayitlari()
        {
            InitializeComponent();
        }
        public int haftaal(DateTime dtPassed)
        {

            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;

        }
        public string datasec;
baglantisinif conn=new baglantisinif();
        private void frmpuankayitlari_Load(object sender, EventArgs e)
        {
            int hafta = haftaal(DateTime.Now);
            OleDbConnection con = new OleDbConnection(conn.baglan);
            if (datasec == "puankayitlari")
            {
                con.Open();
                OleDbDataAdapter puankayitlari = new OleDbDataAdapter("SELECT     NOTID AS 'NOT NUMARASI',    BRANSADI AS 'DERS ADI',    SAATAD AS 'DERS SAATİ',    SINIFAD AS 'SINIF',    OGRENCIADISOYADI AS 'ÖĞRENCİNİN ADI SOYADI',    OGRENCINUMARASI AS 'ÖĞRENCİ NUMARASI',   TARIH AS 'TARİH',\r\n    [1_OLCUT],    [2_OLCUT],    [3_OLCUT],    [4_OLCUT],    [5_OLCUT],    UYARIVARYOK,    UYARI,   TOPLAMPUAN,    HAFTA  FROM    (        (            (               TBLNOTLAR                INNER JOIN TBLBRANSLAR ON TBLBRANSLAR.BRANSID = TBLNOTLAR.BRANS            )           INNER JOIN TBLSAATLER ON TBLSAATLER.SAATID = TBLNOTLAR.DERSSAATI        )       INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID = TBLNOTLAR.SINIF    )    INNER JOIN TBLOGRENCILER ON TBLOGRENCILER.OGRENCIID = TBLNOTLAR.OGRENCININID ", con);
                DataTable dataTable = new DataTable();
                puankayitlari.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else if (datasec == "puanlanmamisdersler")
            {
                
                con.Open();
                OleDbCommand puanlanmamisdersler = new OleDbCommand("SELECT KAYITID AS 'SIRA NUMARASI', GUNLER AS 'GÜN', SINIFAD AS 'SINIF', SAATAD AS 'DERS SAATİ', BRANSADI AS 'DERS ADI', ADISOYADI AS 'ÖĞRETMEN', OLCDURUM AS 'ÖLÇÜM DURUMU' FROM ((   ( (   TBLDERSPROGRAMI INNER JOIN TBLGUN ON TBLGUN.HAFTANINGUNU = TBLDERSPROGRAMI.TARIH   ) INNER JOIN TBLSINIFLAR ON TBLSINIFLAR.SINIFID = TBLDERSPROGRAMI.SINIF) INNER JOIN TBLSAATLER ON TBLSAATLER.SAATID = TBLDERSPROGRAMI.DERSSAATI) INNER JOIN TBLBRANSLAR ON TBLBRANSLAR.BRANSID = TBLDERSPROGRAMI.DERS) INNER JOIN TBLOGRETMENLER ON TBLOGRETMENLER.OGRETMENID = TBLDERSPROGRAMI.OGRETMEN WHERE OLCDURUM=@O1 ORDER BY KAYITID ASC", con);
                puanlanmamisdersler.Parameters.AddWithValue("@O1", false);
                OleDbDataAdapter puanlanmamisderslerdata = new OleDbDataAdapter();
                puanlanmamisderslerdata.SelectCommand= puanlanmamisdersler;
                DataTable dataTable = new DataTable();
                puanlanmamisderslerdata.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();

            }
            
            
        }
    }
}
