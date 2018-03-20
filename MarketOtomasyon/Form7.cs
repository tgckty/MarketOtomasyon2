using MarketOtomasyon.DAL;
using MarketOtomasyon.Entities;
using MarketOtomasyon.ViewModels;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "Sipariş Detayları";
        }
        List<ListViewItem> viewItemList = new List<ListViewItem>();
        private void veriGetir()
        {
            MyContext db = new MyContext();
       
            try
            {
                var sonuc = db.SiparisDetaylar.OrderBy(x => x.UrunId).ToList();

                sonuc.ForEach(x =>
                {

                    ListViewItem viewItem = new ListViewItem(x.SiparisId.ToString());
                    viewItem.SubItems.Add($"{x.UrunId}");
                    viewItem.SubItems.Add($"{x.Urun.UrunAdi}");
                    viewItem.SubItems.Add($"{x.Fiyat}");
                    viewItem.SubItems.Add($"{x.Adet}");
                    viewItem.SubItems.Add($"{x.Adet * x.Fiyat * x.Urun.KDV}");
                    viewItem.SubItems.Add($"{x.OdemeSekli}");

                    lstDetay.Items.Add(viewItem);
                }
                     );



                lstDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
