using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    class UrunViewModel
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }
        public string KategoriAdi { get; set; }
        public byte[] Foto { get; set; }
        public decimal KDV { get; set; }
        public override string ToString() => $"{UrunAdi}: {Fiyat:c2} - Kalan:{Stok ?? 0}";
    }
}
