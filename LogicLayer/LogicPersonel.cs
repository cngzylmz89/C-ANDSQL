using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityClass> LLPersonellistesi()
        {
            return DALPersonel.Personellistesi();
        }

        public static int LLPersonelEkle(EntityClass p)//Dalpersonel sınıfında oluşturduğumuz türden bir metotu oluşturuyoruz.
        {//şartlarımızı if ile belirtik metodu p nesnesiyl döndürüyoruz.
            if(p.Ad!=""&&p.Soyad!=""&&p.Maas>=4000&& p.Gorev.Length >= 3)
            {
               return DALPersonel.Personelekle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelsil(int per)
        {
            if (per > 0)
            {
               return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelguncelle(EntityClass per)
        {
            if (per.Ad != "")
            {
                return DALPersonel.PersonelGuncelle(per);
            }
            else
            {
                return false;
            }
        }
    }
}
