using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityClass> Personellistesi()
        {
            List<EntityClass> degerler = new List<EntityClass>();
            SqlCommand komut1 = new SqlCommand("select * from TBLBILGI", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityClass ent = new EntityClass();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }

        public static int Personelekle(EntityClass p)//farklı olarak bu sefer int değişkeninden  metot türettik ve Parametre olarak EntityClass sınıfından p adında bir nesne türettik
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD, SOYAD, SEHIR, GOREV, MAAS) VALUES (@P1, @P2,@P2,@P4, @P5 )", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@P1", p.Ad);//p ile EntityClass taki değişkenlere ulaştık
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Sehir);
            komut2.Parameters.AddWithValue("@P4", p.Gorev);
            komut2.Parameters.AddWithValue("@P5", short.Parse(p.Maas.ToString()));

            return komut2.ExecuteNonQuery();

        }

        public static bool PersonelSil(int p)//bool türünde metot tanımla ve parametresini int türünde ver
        {
            SqlCommand komut4 = new SqlCommand("delete from TBLBILGI where ID=@P1", Baglanti.bgl);//sqlkomutunu yaz
            komut4.Parameters.AddWithValue("@P1", p);
            return komut4.ExecuteNonQuery() > 0;//sonucu döndürürken bool olduğu için şart 0 dan büyük olduğunda yani 1 olduğunda yani true olduğunda döndür diyoruz.
        }
            
        public static bool PersonelGuncelle(EntityClass p)//bool türünde metot oluştur parametresini EntityClass sınıfından p nesnesine ata
        {
            SqlCommand komut5 = new SqlCommand("update TBLBILGI set AD=@P1, SOYAD=@P2, SEHIR=@P3, GOREV=@P4, MAAS=@P5 where ID=@P0", Baglanti.bgl);
            
            komut5.Parameters.AddWithValue("@P1", p.Ad);
            komut5.Parameters.AddWithValue("@P2", p.Soyad);
            komut5.Parameters.AddWithValue("@P3", p.Sehir);
            komut5.Parameters.AddWithValue("@P4", p.Gorev);
            komut5.Parameters.AddWithValue("@P5", p.Maas);
            komut5.Parameters.AddWithValue("@P0", p.Id);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
               
            }
            return komut5.ExecuteNonQuery() > 0;
            
        }

    }
}
