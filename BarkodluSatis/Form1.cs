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

namespace BarkodluSatis
{
    public partial class frmbarkdolusatisana : Form
    {
        public frmbarkdolusatisana()
        {
            InitializeComponent();
        }

        private void frmbarkdolusatisana_Load(object sender, EventArgs e)
        {
            
        }
        Barkodentities db=new Barkodentities();
        private void txtbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Enter)
            {
                string barkod = txtbarkod.Text.Trim();
                if (barkod.Length<=2)
                {
                    txtmiktar.Text = barkod;
                    txtbarkod.Clear();
                    txtmiktar.Focus();

                }
                else
                {
                    
                    if(db.Table.Any(a=> a.Barkod == barkod))
                    {
                        var urun=db.Table.Where(a=> a.Barkod==barkod).FirstOrDefault();
                        int satirsayisi=gridsatislistesi.Rows.Count;
                        decimal miktar=decimal.Parse(txtmiktar.Text);
                        Boolean urunvarmi = false;

                        if (urunvarmi == false)
                        {
                            for (int i = 0; i < satirsayisi; i++)
                            {
                                if (gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                                {
                                    gridsatislistesi.Rows[i].Cells["Miktar"].Value = miktar + decimal.Parse(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                                    gridsatislistesi.Rows[i].Cells["Toplam"].Value = Math.Round(decimal.Parse(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString()) * decimal.Parse(urun.SatisFiyat.ToString()),2);
                                    urunvarmi = true;
                                }

                                else
                                {
                                    
                                }
                            }
                        }
                        else if (!urunvarmi)
                        {
                            gridsatislistesi.Rows.Add();
                            gridsatislistesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                        }
                    }
                }
            }
            
        }
    }
}
