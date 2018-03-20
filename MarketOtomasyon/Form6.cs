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
using Microsoft.Office.Interop.Excel;

namespace MarketOtomasyon
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void lstDetay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            veriGetir();
            this.Text = "SİPARİŞLER";
        }
        private void veriGetir()
        {
            MyContext db = new MyContext();
            try
            {
                var sonuc = db.Siparisler.OrderBy(x => x.SiparisTarihi)
                    .Select(x => new SiparisViewModel()
                    {
                        SiparisNo = x.SiparisId,
                        SiparisTarihi = x.SiparisTarihi,
                        OdemeSekli = x.OdemeSekli,
                        ToplamSiparisTutari = 0
                    })
                    .ToList();
                sonuc.ForEach(x =>
                {
                    x.ToplamSiparisTutari = db.SiparisDetaylar
                    .Where(y => y.SiparisId == x.SiparisNo)
                    .Sum(y => y.Fiyat * y.Adet * y.Urun.KDV);
                    ListViewItem viewItem = new ListViewItem(x.SiparisNo.ToString());
                    viewItem.SubItems.Add($"{x.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add($"{x.OdemeSekli}");
                    viewItem.SubItems.Add($"{x.ToplamSiparisTutari:c2}");
                    lstSatis.Items.Add(viewItem);
                }
                );
                lstSatis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<ListViewItem> ViewItems { get; set; }
        private void detaylarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lstSatis.SelectedItems == null || lstSatis.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bir şey seçmediniz");
                return;
            }
            MyContext db = new MyContext();
            try
            {
                var siparisId = int.Parse(lstSatis.SelectedItems[0].Text);

                var sonuc = db.SiparisDetaylar.Where(x => x.SiparisId == siparisId).ToList();
                List<ListViewItem> viewItemList = new List<ListViewItem>();
                sonuc.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.SiparisId.ToString());
                    viewItem.SubItems.Add($"{x.UrunId}");
                    viewItem.SubItems.Add($"{x.Urun.UrunAdi}");
                    viewItem.SubItems.Add($"{x.Fiyat:c2}");
                    viewItem.SubItems.Add($"{x.Adet}");
                    viewItem.SubItems.Add($"{x.Adet * x.Fiyat * x.Urun.KDV}");
                    viewItem.SubItems.Add($"{x.OdemeSekli}");

                    viewItemList.Add(viewItem);
                });

                SatisDetay frm = new SatisDetay(viewItemList);
                frm.Text = $"{siparisId} nolu siparişin detayı";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ürünAdınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünlereGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void satışDetaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satışDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lstSatis.Items.Clear();
            MyContext db = new MyContext();
            try
            {              
                var siparis = db.Siparisler.Where(x => x.SiparisTarihi > dtpTarih2.Value && x.SiparisTarihi < dtpTarih1.Value).OrderBy(x => x.SiparisTarihi).Select(x => new SiparisViewModel
                {
                    SiparisTarihi = x.SiparisTarihi,
                    OdemeSekli = x.OdemeSekli,
                    ToplamSiparisTutari = 0,
                    SiparisNo = x.SiparisId
                }).ToList();

                siparis.ForEach(x =>
                {
                    x.ToplamSiparisTutari = db.SiparisDetaylar
                   .Where(y => y.SiparisId == x.SiparisNo)
                   .Sum(y => y.Fiyat * y.Adet * y.Urun.KDV);
                    ListViewItem viewItem = new ListViewItem(x.SiparisNo.ToString());
                    viewItem.SubItems.Add($"{x.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add($"{x.ToplamSiparisTutari:c2}");
                    viewItem.SubItems.Add($"{x.OdemeSekli}");
                    lstSatis.Items.Add(viewItem);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ürüneGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunDetay frm = new UrunDetay();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            //xla.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            //Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            //int i = 1;
            //int j = 1;
            //foreach (ListViewItem item in lstSatis.Items)
            //{
            //    ws.Cells[i, j] = item.Text;
            //    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
            //    {
            //        ws.Cells[i, j] = subitem.Text.ToString();
            //        j++;
            //    }
            //    j = 1;
            //    i++;
            //}


        }
    }
}
