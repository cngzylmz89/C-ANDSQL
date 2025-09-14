using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okulbonus
{
    public partial class frmdersler : Form
    {
        public frmdersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();

        private void frmdersler_Load(object sender, EventArgs e)
        {


            dataGridView2.DataSource = ds.DersListele();
        }
        
        private void btnselect_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ds.DersListele();//LİSTELEME
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtdersad.Text);//parametreye bilgiyi nereden alacağını yazıyoruz.
            dataGridView2.DataSource = ds.DersListele();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtdersad.Text, byte.Parse(mskid.Text));//  iki tane parametre var. ilki string, ikincisi byte türünde. mskid byte değeri olduğu için
            //byte çeviriyoruz.
            dataGridView2.DataSource = ds.DersListele();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(mskid.Text));
            dataGridView2.DataSource = ds.DersListele();
        }

        

        
        
    }
}
