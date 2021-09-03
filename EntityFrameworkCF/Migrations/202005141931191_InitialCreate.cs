namespace EntityFrameworkCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        musteriid = c.Int(nullable: false, identity: true),
                        adisoyadi = c.String(),
                        telefon = c.String(),
                        sehir = c.String(),
                        email = c.String(),
                        tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.musteriid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}
