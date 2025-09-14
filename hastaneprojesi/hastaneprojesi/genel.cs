using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneprojesi
{
    class genel
    {
        public string captcha(string s)
        {
            Random rnd = new Random();

            string[] bykhrf = { "A", "B", "K", "Ş", "R", "M" };
            string[] kckhrf = { "k", "l", "n", "f", "o", "q" };
            char[] krk = { '.', '*', '+', '>' };

            int sy1 = rnd.Next(1, 10);
            int sy2 = rnd.Next(1, 10);

           int buyk = rnd.Next(1, bykhrf.Length);
           int  kck = rnd.Next(1, kckhrf.Length);
           int  kark = rnd.Next(1, krk.Length);

           
           s=bykhrf[buyk].ToString()+kckhrf[kck].ToString()+krk[kark].ToString() + sy1.ToString() + sy2.ToString();
           string sonuc = s;
           return sonuc;
        }

        public void kapat2()
        {

            frmRandevuListesi rndkapat = new frmRandevuListesi();
            rndkapat.Hide();
        }

        public void kapat()
        {

            frmsekreterdetay sekkapat = new frmsekreterdetay();
            sekkapat.Hide();
        }


        internal string captcha(System.Windows.Forms.TextBox captchadoktoru)
        {
            throw new NotImplementedException();
        }
    }
}
