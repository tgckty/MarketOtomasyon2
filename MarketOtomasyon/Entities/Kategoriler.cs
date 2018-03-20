using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Entities
{
    [Table("Kategoriler")]
    public class Kategoriler
    {

        [Key] //primarykey olarak belirlemek için yazdık.
        public int Id { get; set; }
        [Required] //kategori adının nullable olmasını istemediğimizden bunu yazdık.
        [StringLength(25)]
        [Column("Kategori Adı", TypeName = "varchar")]  //sqlde kolonun adının nasıl gözükmesini istediğimizi yazdık ve türünü belirledik.     
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal KDV { get; set; }

        public virtual List<Urunler> Urunler { get; set; } = new List<Urunler>();
    }
}
