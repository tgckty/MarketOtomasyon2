using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Entities
{

    [Table("Urunler")]
    public class Urunler
    {
        [Key]
        public int UrunId { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Ürün adı 2-40 karakter aralığında olmalıdır.")]
        [Index(IsUnique = true)]
        public string UrunAdi { get; set; }
        [Required]
        [StringLength(13)]
        [Index(IsUnique = true)]
        public string SeriNo { get; set; }
        public short Stok { get; set; } = 0;
        public decimal? Fiyat { get; set; } = 0;
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
        public int KategoriId { get; set; }
        public byte[] Foto { get; set; }
        public decimal KDV { get; set; }


        [ForeignKey("KategoriId")]
        public virtual Kategoriler Kategoriler { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();


    }
}
