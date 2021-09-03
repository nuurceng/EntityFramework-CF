namespace EntityFrameworkCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class siladres : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Musteris", "adres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "adres", c => c.String());
        }
    }
}
