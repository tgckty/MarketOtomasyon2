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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<UrunViewModel> urunList = new List<UrunViewModel>();
        List<SepetViewModel> sepetList = new List<SepetViewModel>();

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MyContext db = new MyContext();
                var urun = db.Urunler.Where(x => x.SeriNo == textBox1.Text).Select(x => new UrunViewModel
                {
                    Fiyat = x.Fiyat,
                    KDV = x.KDV,
                    Foto = x.Foto,
                    UrunAdi = x.UrunAdi,
                    Stok = x.Stok,
                    UrunID = x.UrunId,
                    KategoriAdi = x.Kategoriler.KategoriAdi
                }).FirstOrDefault();

                bool kontrol = StokKontrol(urun);
                if (!kontrol)
                {
                    MessageBox.Show("Stokta yeterli ürün yok!");
                    return;
                }
                bool varmi = false;
                sepetList.ForEach(x =>
                {
                    if (x.UrunID == urun.UrunID)
                    {
                        varmi = true;
                        x.Adet++;
                    }
                });

                if (!varmi)
                {
                    var model = db.Kategoriler.Select(x => new SepetViewModel()
                    {
                        UrunID = urun.UrunID,
                        UrunAdi = urun.UrunAdi,
                        KDV = urun.KDV,
                        Fiyat = urun.Fiyat ?? 0,                     
                        Foto = urun.Foto,
                        Adet = 1

                    }).FirstOrDefault();

                    sepetList.Add(model);
                }
                SepetGuncelle();
                nParaUstu.Value = nNakit.Value - nToplam.Value;
                textBox1.Clear();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "Satış İşlemleri";
            nNakit.Visible = false;
            lblNakit.Visible = false;
            nParaUstu.Visible = false;
            lblParaUstu.Visible = false;

        }
        private void veriGetir(string arama = "")
        {
            try
            {
                var ara = arama.ToLower();
                MyContext db = new MyContext();
                var sonuc = from prod in db.Urunler
                            where (prod.UrunAdi.ToLower().Contains(ara) || prod.Kategoriler.KategoriAdi.Contains(ara))
                            orderby prod.UrunAdi ascending
                            select new UrunViewModel
                            {
                                UrunID = prod.UrunId,
                                UrunAdi = prod.UrunAdi,
                                Fiyat = prod.Fiyat,
                                Stok = prod.Stok,
                                KategoriAdi = prod.Kategoriler.KategoriAdi,
                                Foto = prod.Foto,
                                KDV = prod.KDV
                            };
                lstUrun.DataSource = sonuc.ToList();
                urunList = sonuc.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            nToplam.Value = toplam;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null) return;
                var seciliUrun = lstUrun.SelectedItem as UrunViewModel;

                bool kontrol = StokKontrol(seciliUrun);
                if (!kontrol)
                {
                    MessageBox.Show("Stokta yeterli ürün yok!");
                    return;
                }

                bool varmi = false;
                sepetList.ForEach(x =>
                {
                    if (x.UrunID == seciliUrun.UrunID)
                    {
                        varmi = true;
                        x.Adet++;
                    }
                });
                if (!varmi)
                {
                    var model = new SepetViewModel()
                    {
                        UrunID = seciliUrun.UrunID,
                        UrunAdi = seciliUrun.UrunAdi,
                        Fiyat = seciliUrun.Fiyat ?? 0 ,
                        Adet = 1,
                        Foto = seciliUrun.Foto,
                        KDV = seciliUrun.KDV

                    };
                    sepetList.Add(model);
                }
                SepetGuncelle();
                nParaUstu.Value = nNakit.Value - nToplam.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null) return;
                var seciliUrun = lstSepet.SelectedItem as SepetViewModel;
                sepetList.Remove(seciliUrun);

                SepetGuncelle();
                nParaUstu.Value = nNakit.Value - nToplam.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Temizle()
        {
            sepetList = new List<SepetViewModel>();
            lstSepet.Items.Clear();
            veriGetir();
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            veriGetir(txtAra.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün Eklemelisiniz");
                return;
            }
            if (rbNakit.Checked == false && rbKart.Checked == false)
            {
                MessageBox.Show("Ödeme türü seçiniz!");
                return;
            }
            if (rbNakit.Checked == true && nNakit.Value < nToplam.Value)
            {
                MessageBox.Show("Eksik para verdiniz!");
                return;
            }
            string mesaj = $"{ nToplam.Value } tutarındaki satış işlemini onaylıyor musunuz?";
            var cevap = MessageBox.Show(mesaj, "Satış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;
            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                string odemesekli = "";
                if (rbKart.Checked == true)
                    odemesekli = rbKart.Text;
                else
                    odemesekli = rbNakit.Text;

                try
                {
                    var yeniSiparis = new Siparis
                    {
                        OdemeSekli = odemesekli
                    };

                    db.Siparisler.Add(yeniSiparis);
                    db.SaveChanges();
                    foreach (var item in sepetList)
                    {
                        var siparisDetay = new SiparisDetay()
                        {
                            SiparisId = yeniSiparis.SiparisId,
                            UrunId = item.UrunID,
                            Adet = item.Adet,
                            Fiyat = item.Fiyat,
                            OdemeSekli = odemesekli


                        };
                        db.SiparisDetaylar.Add(siparisDetay);
                        var urun = db.Urunler.Find(item.UrunID);
                        urun.Stok -= (short)item.Adet;
                    }
                    db.SaveChanges();
                    tran.Commit();
                    MessageBox.Show("Satış oluşturuldu!");
                    Temizle();
                    nNakit.Value = 0;
                    nToplam.Value = 0;
                    nParaUstu.Value = nNakit.Value - nToplam.Value;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("HATA! " + ex.Message);
                }
            }
        }
        private bool StokKontrol(UrunViewModel seciliUrun, int adet = 1)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunID == seciliUrun.UrunID)
                {
                    varmi = true;
                    if (adet == 1)
                    {
                        if (seciliUrun.Stok > x.Adet)
                            cevap = true;
                        else
                            cevap = false;
                    }
                    else if (adet > 1)
                    {
                        if (seciliUrun.Stok > adet)
                            cevap = true;
                        else
                            cevap = false;
                    }
                }
            });

            if (!varmi)
            {
                if (seciliUrun.Stok > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    var seciliUrun = lstUrun.SelectedItem as UrunViewModel;
                    pictureBox1.Image = new Bitmap(new MemoryStream(seciliUrun.Foto));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    var seciliUrun = lstSepet.SelectedItem as SepetViewModel;
                    pictureBox1.Image = new Bitmap(new MemoryStream(seciliUrun.Foto));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true)
            {
                rbKart.Checked = false;
                nNakit.Visible = true;
                lblNakit.Visible = true;
                nParaUstu.Visible = true;
                lblParaUstu.Visible = true;

            }
            else
            {
                rbKart.Checked = true;
                nNakit.Visible = false;
                lblNakit.Visible = false;
                nParaUstu.Visible = false;
                lblParaUstu.Visible = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void rbKart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKart.Checked == true)
            {
                rbNakit.Checked = false;
                nNakit.Visible = false;
                lblNakit.Visible = false;
                nParaUstu.Visible = false;
                lblParaUstu.Visible = false;

            }
            else
            {
                rbNakit.Checked = true;
                nNakit.Visible = true;
                lblNakit.Visible = true;
                nParaUstu.Visible = true;
                lblParaUstu.Visible = true;

            }
        }
        private void nNakit_ValueChanged(object sender, EventArgs e)
        {
            nParaUstu.Value = nNakit.Value - nToplam.Value;
        }
        private void nParaUstu_ValueChanged(object sender, EventArgs e)
        {
            nParaUstu.Value = nNakit.Value - nToplam.Value;
        }
    }
}
