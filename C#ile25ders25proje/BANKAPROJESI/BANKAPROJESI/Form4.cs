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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        BANKAMATIKEntities2 db = new BANKAMATIKEntities2();
        connect baglan = new connect();
        public int hesap;
        private void Form4_Load(object sender, EventArgs e)
        {
            
            
            
            var ktgr = (from x in db.TBLHAREKET
                        where x.GONDEREN == hesap
                        select new
                        {

                            x.ID,
                            x.GONDEREN,
                            x.ALICI,
                            x.TUTAR


                        }
            ).ToList();

            dataGridView1.DataSource = ktgr;
        }
    }
}
