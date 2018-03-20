using MarketOtomasyon.DAL;
using MarketOtomasyon.Entities;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "Ürün Yönetimi";
        }

        private byte[] resimDosyasi;
        private void veriGetir()
        {
            MyContext db = new MyContext();
            lstUrun.DataSource = db.Urunler.OrderBy(x => x.UrunAdi).ToList();
            lstUrun.DisplayMember = "UrunAdi";
            lstUrun.ValueMember = "UrunId";

            cmbKategori.DataSource = db.Kategoriler.OrderBy(x => x.KategoriAdi).ToList();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "Id";
        }
        private void txtSeriNo_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
           
            var seciliKategori = cmbKategori.SelectedItem as Kategoriler;
            try
            {
                if (pbFoto.Image == null) return;
                if (txtSeriNo.Text == null) return;             
                    foreach (var item in db.Urunler)
                    {
                        if (item.KDV == decimal.Parse(txtSeriNo.Text)) return;

                    }

                Urunler urun = new Urunler();
                urun.UrunAdi = txtUrunAdi.Text;
                urun.KDV = seciliKategori.KDV;
                urun.Fiyat = nFiyat.Value;
                urun.Stok = (short)nStok.Value;
                urun.KategoriId = (int)cmbKategori.SelectedValue;
                urun.SeriNo = txtSeriNo.Text;            
                urun.Foto = resimDosyasi;
                db.Urunler.Add(urun);
                db.SaveChanges();
                resimDosyasi = null;
                pbFoto.Image = null;
                veriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string SeriNoYap()
        {
            var seciliKategori = cmbKategori.SelectedIndex;
            Random rnd = new Random();
            return ("869" + seciliKategori + rnd.Next(100000000, 1000000000));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = SeriNoYap();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçiniz.",
                Multiselect = false,
                Filter = "JPG Formatı (*.jpg)|*.jpg;*.jpeg; |PNG Formatı|*.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyasi = memoryStream.ToArray();
                pbFoto.Image = new Bitmap(memoryStream);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Urunler;
            try
            {
                MyContext db = new MyContext();
                var seciliUrunID = db.Urunler.Find(seciliUrun.UrunId);
                if (seciliUrun == null)
                {
                    MessageBox.Show("Urun Bulunamadı");
                    veriGetir();
                    return;
                }
                seciliUrunID.UrunAdi = txtUrunAdi.Text;
                seciliUrunID.Fiyat = nFiyat.Value;
                seciliUrunID.Stok = (short)nStok.Value;
                seciliUrunID.KategoriId = (int)cmbKategori.SelectedValue;
                seciliUrunID.Foto = resimDosyasi;

                db.SaveChanges();
                veriGetir();
                lstUrun.SelectedValue = seciliUrun.UrunId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstUrun.SelectedItem == null) return;
                var seciliUrun = lstUrun.SelectedItem as Urunler;
                txtUrunAdi.Text = seciliUrun.UrunAdi;
                nFiyat.Value = seciliUrun.Fiyat ?? 0;
                nStok.Value = seciliUrun.Stok;
                txtSeriNo.Text = seciliUrun.SeriNo;
                cmbKategori.SelectedValue = seciliUrun.KategoriId;
                if (seciliUrun.Foto != null)
                {
                    try
                    {
                        pbFoto.Image = new Bitmap(new MemoryStream(seciliUrun.Foto));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    pbFoto.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Urunler;
            MyContext db = new MyContext();
            var seciliUrunID = db.Urunler.Find(seciliUrun.UrunId);
            if (seciliUrunID == null) return;
            db.Urunler.Remove(seciliUrunID);
            db.SaveChanges();
            veriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
