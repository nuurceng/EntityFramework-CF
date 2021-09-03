namespace EntityFrameworkCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uruntablosuekle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        urunid = c.Int(nullable: false, identity: true),
                        kategoriid = c.Int(nullable: false),
                        markaid = c.Int(nullable: false),
                        barkodno = c.String(maxLength: 30),
                        urunadi = c.String(maxLength: 20, unicode: false),
                        miktari = c.Int(nullable: false),
                        alisfiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        satisfiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.urunid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
