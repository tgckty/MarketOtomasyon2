using MarketOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class UrunDetay : Form
    {
        public UrunDetay()
        {
            InitializeComponent();
        }

        private void UrunDetay_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            var sonuc = from s in db.SiparisDetaylar
                        group s by new
                        {
                            s.UrunId,
                            s.Urun.UrunAdi,
                            s.Fiyat
                        };
            var sonucc = sonuc.ToList();
            foreach (var item in sonucc)
            {
                ListViewItem viewItem = new ListViewItem(item.Key.ToString());
                lstDetay.Items.Add(viewItem);
            }


            //var sonuc1 = db.SiparisDetaylar.OrderBy(q => q.UrunId).GroupBy(x => new { x.UrunId, x.Urun.UrunAdi, x.Fiyat }).Select(y => y.Sum(z => z.Adet)).ToList();
            var sonuc2 = db.SiparisDetaylar.OrderBy(q => q.UrunId).GroupBy(x => new { x.UrunId, x.Urun.UrunAdi, x.Fiyat }).Select(y => y.Sum(z => z.Adet * z.Fiyat * z.Urun.KDV)).ToList(); 


            ////sonuc1.ForEach(x =>
            ////{

            ////    ListViewItem viewItem = new ListViewItem(x.ToString());
            ////    lstDetay1.Items.Add(viewItem);
            ////});
            sonuc2.ForEach(x =>
            {

                ListViewItem viewItem = new ListViewItem(x.ToString());
                lstDetay2.Items.Add(viewItem);
            });


            lstDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstDetay2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
