using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaporala_Oyunu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlıs;
        int sure = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                sure = 60;
                timer1.Stop();
                textBox1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsure.Text = sure.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "anadolu")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }
                        
                        
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cengiz")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 4:
                        if (textBox1.Text == "danimarka")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 5:
                        if (textBox1.Text == "edirne")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 6:
                        if (textBox1.Text == "futbol")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 7:
                        if (textBox1.Text == "gaziantep")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 8:
                        if (textBox1.Text == "harika")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 9:
                        if (textBox1.Text == "ığdır")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 10:
                        if (textBox1.Text == "iğne")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 12:
                        if (textBox1.Text == "kayseri")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 13:
                        if (textBox1.Text == "mars")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                            textBox1.Text = "";
                        }


                        break;
                    case 14:
                        if (textBox1.Text == "newton")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 15:
                        if (textBox1.Text == "ordu")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 16:
                        if (textBox1.Text == "rize")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 17:
                        if (textBox1.Text == "samanyolu")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 18:
                        if (textBox1.Text == "tabiat")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 19:
                        if (textBox1.Text == "ulak")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 20:
                        if (textBox1.Text == "vali")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
                    case 21:
                        if (textBox1.Text == "yıl")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            lbldogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlıs++;
                            lblyanlis.Text = yanlıs.ToString();
                        }


                        break;
               }
                textBox1.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Enabled = true;
            sure = 60;
            lblsure.Text = sure.ToString();
            timer1.Start();

                linkLabel1.Text = "SIRADAKİ SORU";
            soruno++;
            textBox1.Focus();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye karasının ismi nedir?";
                button1.BackColor = Color.Yellow;
                button23.Text = button1.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İskender yemeğinin en iyi yapıldığı ilimiz hangisidir?";
                button2.BackColor = Color.Yellow;
                button23.Text = button2.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Tarihin gördüğü en büyük hükümdar hangisidir?";
                button3.BackColor = Color.Yellow;
                button23.Text = button3.Text;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Bir baltık ülkesi";
                button4.BackColor = Color.Yellow;
                button23.Text = button4.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Selimiye Camii hangi ilimizdedir?";
                button5.BackColor = Color.Yellow;
                button23.Text = button5.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Ayakla oynanan bir spor türü?";
                button6.BackColor = Color.Yellow;
                button23.Text = button6.Text;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dondurmasıyla meşhur ilimizin ismi nedir";
                button7.BackColor = Color.Yellow;
                button23.Text = button7.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Mükemmel anlamını veren eş anlamlı kelime?";
                button8.BackColor = Color.Yellow;
                button23.Text = button8.Text;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "I ile başlayan ilimizin adı nedir?";
                button9.BackColor = Color.Yellow;
                button23.Text = button9.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "İnce delici bir alet?";
                button10.BackColor = Color.Yellow;
                button23.Text = button10.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Kırsaldaki bir kolluk kuvveti?";
                button11.BackColor = Color.Yellow;
                button23.Text = button11.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Pastırmasıyla ünlü şehrimiz?";
                button12.BackColor = Color.Yellow;
                button23.Text = button12.Text;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Dünya'ya en yakın gezegenin ismi nedir?";
                button13.BackColor = Color.Yellow;
                button23.Text = button13.Text;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Çekim kuvvetini bulan bilim adamının ismi?";
                button14.BackColor = Color.Yellow;
                button23.Text = button14.Text;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Askeri bir topluluk adı?";
                button15.BackColor = Color.Yellow;
                button23.Text = button15.Text;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Çayıyla meşhur ilimizin ismi?";
                button16.BackColor = Color.Yellow;
                button23.Text = button16.Text;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "İçinde bulunduğumuz galaksinin ismi?";
                button17.BackColor = Color.Yellow;
                button23.Text = button17.Text;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Doğa kelimesinin eş anlamlısı?";
                button18.BackColor = Color.Yellow;
                button23.Text = button18.Text;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Eski dilde ulaştıran, getiren anlamındaki kelime?";
                button19.BackColor = Color.Yellow;
                button23.Text = button19.Text;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Bir ildeki en üst devlet amiri?";
                button20.BackColor = Color.Yellow;
                button23.Text = button20.Text;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Sene kelimesinin eş anlamlısı nedir?";
                button21.BackColor = Color.Yellow;
                button23.Text = button21.Text;
            }



        }
    }
}
