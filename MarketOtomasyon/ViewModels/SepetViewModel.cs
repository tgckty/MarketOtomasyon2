using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    public class SepetViewModel
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; } = 0;
        public byte[] Foto { get; set; }
        public string KategoriId { get; set; }
        public decimal KDV { get; set; }
        //public decimal KDV { get; set; }
        public decimal Toplam
        {
            get => Adet * Fiyat*KDV  ;
        }
    
        public override string ToString() => $"{UrunAdi} : {Adet}x{Fiyat:c2} = {Toplam:c2}";
    }
}
