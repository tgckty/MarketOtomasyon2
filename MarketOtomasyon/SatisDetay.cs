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
    public partial class SatisDetay : Form
    {
        public SatisDetay(List<ListViewItem> viewItems)
        {
            InitializeComponent();
            this.ViewItems = viewItems;
            foreach (var item in viewItems)
            {
                lstDetay.Items.Add(item);
            }
            lstDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public List<ListViewItem> ViewItems { get; set; }
    
       
        private void SatisDetay_Load(object sender, EventArgs e)
        {
                    
        }
    }
}
