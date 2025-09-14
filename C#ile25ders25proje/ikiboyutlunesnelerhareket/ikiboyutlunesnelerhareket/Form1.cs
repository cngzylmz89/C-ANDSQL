using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiboyutlunesnelerhareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad2 && pictureBox1.Top<388)
            {
                pictureBox1.Top += 5;//pictureboxın üstünü 5 er artırır.
            }

            if (e.KeyCode == Keys.NumPad8 && pictureBox1.Top>0)
            {
                pictureBox1.Top -= 5;
            }

            if(e.KeyCode==Keys.NumPad4&& pictureBox1.Left > 0)
            {
                pictureBox1.Left -= 5;//pictureboxın solunu 5 er azaltır.
            }
            
            if(e.KeyCode==Keys.NumPad6&& pictureBox1.Left <= 723)
            {
                pictureBox1.Left += 5;
            }

            


        }
    }
}
