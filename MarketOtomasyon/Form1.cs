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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "Kategori Yönetimi";
        }

        private void veriGetir()
        {
            try
            {
            
                MyContext db = new MyContext();
                lstKategori.DataSource = db.Kategoriler.OrderBy(x => x.Id).ToList();
                lstKategori.DisplayMember = "KategoriAdi";
                lstKategori.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                Kategoriler yeniKategori = new Kategoriler();
                yeniKategori.KategoriAdi = txtKategoriAdi.Text;
                yeniKategori.Aciklama = txtAciklama.Text;
                yeniKategori.KDV = nKDV.Value;
                db.Kategoriler.Add(yeniKategori);
                db.SaveChanges();
                veriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            var seciliKategori = lstKategori.SelectedItem as Kategoriler;
            txtAciklama.Text = seciliKategori.Aciklama;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            nKDV.Value = seciliKategori.KDV;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            MyContext db = new MyContext();
            var seciliKategori = lstKategori.SelectedItem as Kategoriler;
            var seciliKategoriID = db.Kategoriler.Find(seciliKategori.Id);
            if (seciliKategoriID == null) return;

            if (seciliKategori.Urunler.Any())
            {
                MessageBox.Show($"{seciliKategori} ürün içerdiğinden silinemez!");
                return;
            }
            db.Kategoriler.Remove(seciliKategoriID);
            db.SaveChanges();
            veriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstKategori.SelectedItem == null) return;
                MyContext db = new MyContext();
                var seciliKategori = lstKategori.SelectedItem as Kategoriler;
                var seciliKategoriID = db.Kategoriler.Find(seciliKategori.Id);
                if (seciliKategoriID == null) return;
                seciliKategoriID.KategoriAdi = txtKategoriAdi.Text;
                seciliKategoriID.Aciklama = txtAciklama.Text;
                seciliKategori.KDV = nKDV.Value;
                
                db.SaveChanges();
                veriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKategoriAdi_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
