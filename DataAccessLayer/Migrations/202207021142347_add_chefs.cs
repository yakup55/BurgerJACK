namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_chefs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OurChefs", "ChefsNameSurName", c => c.String(maxLength: 50));
            DropColumn("dbo.OurChefs", "ChefsName");
            DropColumn("dbo.OurChefs", "ChefsSurName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OurChefs", "ChefsSurName", c => c.String(maxLength: 50));
            AddColumn("dbo.OurChefs", "ChefsName", c => c.String(maxLength: 50));
            DropColumn("dbo.OurChefs", "ChefsNameSurName");
        }
    }
}
