namespace MarketOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdı = c.String(name: "Kategori Adı", nullable: false, maxLength: 25, unicode: false),
                        Aciklama = c.String(),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 40),
                        SeriNo = c.String(nullable: false, maxLength: 13),
                        Stok = c.Short(nullable: false),
                        Fiyat = c.Decimal(precision: 18, scale: 2),
                        EklenmeZamani = c.DateTime(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        Foto = c.Binary(),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAdi, unique: true)
                .Index(t => t.SeriNo, unique: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adet = c.Int(nullable: false),
                        OdemeSekli = c.String(),
                    })
                .PrimaryKey(t => new { t.SiparisId, t.UrunId })
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(nullable: false),
                        OdemeSekli = c.String(),
                    })
                .PrimaryKey(t => t.SiparisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunId" });
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "SeriNo" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
