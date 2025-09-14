using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
        public  class EntityPersonel
    {

        private int id;
        private string Ad;
        private string Soyad;
        private string Sehir;
        private string gorev;
        private short maas;

        public int Id { get => id; set => id = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Sehir1 { get => Sehir; set => Sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
    }
}
