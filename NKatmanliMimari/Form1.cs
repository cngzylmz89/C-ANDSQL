using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityClass> Personellist=LogicPersonel.LLPersonellistesi();
            dataGridView1.DataSource = Personellist;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            EntityClass ent = new EntityClass();//EntityClass tan ent adında bir nesne türetiyoruz. ent ile değişkenlere ulaşıp propertylere atıyoruz.
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Maas =short.Parse(txtmaas.Text) ;
            ent.Gorev = txtgorev.Text;
            ent.Sehir = txtsehir.Text;

            LogicPersonel.LLPersonelEkle(ent);//LogicPersonel sınıfındaki LLPersonelEkle metodunu ent ile çalıştırıyoruz
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityClass ent = new EntityClass();
            ent.Id = int.Parse(mskperid.Text);
            LogicPersonel.LLPersonelsil(ent.Id);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityClass ent = new EntityClass();
            ent.Id = int.Parse(mskperid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;

            LogicPersonel.LLPersonelguncelle(ent);

        }
    }
}
