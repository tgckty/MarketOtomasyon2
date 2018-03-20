using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Entities
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public string OdemeSekli { get; set; }


        [ForeignKey("UrunId")]
        public virtual Urunler Urun { get; set; }
        [ForeignKey("SiparisId")]
        public virtual Siparis Siparis { get; set; }
    }
}
