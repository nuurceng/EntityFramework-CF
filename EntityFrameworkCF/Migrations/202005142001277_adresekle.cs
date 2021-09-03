namespace EntityFrameworkCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adresekle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "adres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "adres");
        }
    }
}
