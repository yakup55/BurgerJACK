namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_contacr : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "ContactAdress");
            DropColumn("dbo.Contacts", "ContactDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contacts", "ContactAdress", c => c.String(maxLength: 300));
        }
    }
}
