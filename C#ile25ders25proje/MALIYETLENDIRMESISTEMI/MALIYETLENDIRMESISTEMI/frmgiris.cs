using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MALIYETLENDIRMESISTEMI
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmsat fr=new frmsat(); 
            fr.Show();
               
        }
    }
}
