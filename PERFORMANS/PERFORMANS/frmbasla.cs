using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERFORMANS
{
    public partial class frmbasla : Form
    {
        public frmbasla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmyoneticigiris frmyoneticigiris = new frmyoneticigiris();
            frmyoneticigiris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmogrtgiris frmogrtgiris = new frmogrtgiris();
            frmogrtgiris.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
