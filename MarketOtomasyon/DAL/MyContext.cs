using MarketOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
          : base("name=MyCon")
        { }

        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
