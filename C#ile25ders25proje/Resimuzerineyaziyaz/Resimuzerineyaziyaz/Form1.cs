using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Resimuzerineyaziyaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim=openFileDialog1.FileName;
        }
        Color renk;
        private void btnrenksec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color; 
        }
        Bitmap bmp;
        private void btnyazdir_Click(object sender, EventArgs e)
        {
            bmp=new Bitmap(resim);  
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawString(txtmetin.Text,new Font("JOKERMAN",Convert.ToInt16(txtboyut.Text), FontStyle.Bold),new SolidBrush(renk),20,30);
            pictureBox1.Image = bmp; 

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RESİM|.PNG";
         saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
