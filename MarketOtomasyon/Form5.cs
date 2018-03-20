using MarketOtomasyon.DAL;
using MarketOtomasyon.Entities;
using MarketOtomasyon.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "Ürün Alım";


        }
        List<UrunViewModel> urunList = new List<UrunViewModel>();
        List<SepetViewModel> sepetList = new List<SepetViewModel>();
        private void veriGetir()
        {

            MyContext db = new MyContext();

            lstUrun.DataSource = db.Urunler.OrderBy(x => x.UrunAdi).Select(x => new UrunViewModel
            {
                UrunAdi = x.UrunAdi,
                Fiyat = x.Fiyat,
                UrunID = x.UrunId,
                Stok = x.Stok,
                KategoriAdi = x.Kategoriler.KategoriAdi,
                Foto = x.Foto,               
                KDV = 1


            }).ToList();
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstUrun.SelectedItem == null)
            //{
            //    pbFoto.Image = null;
            //}
            //else
            //{
            //    var seciliUrun = lstUrun.SelectedItem as UrunViewModel;
            //    pbFoto.Image = new Bitmap(new MemoryStream(seciliUrun.Foto));
            //}
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            foreach (var item in sepetList)
            {
                var urun = db.Urunler.Find(item.UrunID);
                urun.Stok += (short)item.Adet;
            }
            db.SaveChanges();
            sepetList = new List<SepetViewModel>();
            lstSepet.Items.Clear();
            nAdet.Value = 1;
            SepetGuncelle();
            veriGetir();


        }
        private void SepetGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }
        private void SepetHesapla()
        {
            decimal toplam = 0;
            toplam = sepetList.Sum(x => x.Toplam);
            lblToplam.Text = toplam.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null) return;
                var seciliUrun = lstUrun.SelectedItem as UrunViewModel;

                bool varmi = false;
                sepetList.ForEach(x =>
                {
                    if (x.UrunID == seciliUrun.UrunID)
                    {
                        varmi = true;
                        x.Adet += (short)nAdet.Value;
                        nAdet.Value = 1;
                    }
                });
                if (!varmi)
                {
                    var model = new SepetViewModel()
                    {
                        UrunID = seciliUrun.UrunID,
                        UrunAdi = seciliUrun.UrunAdi,
                        Fiyat = seciliUrun.Fiyat ?? 0,
                        Adet = (short)nAdet.Value,
                        Foto = seciliUrun.Foto,                       
                        KDV = 1

                    };
                    sepetList.Add(model);
                }
                SepetGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null) return;
                var seciliUrun = lstSepet.SelectedItem as SepetViewModel;
                sepetList.Remove(seciliUrun);

                SepetGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
