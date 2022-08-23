namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_commentburger : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "BurgerİD", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "BurgerİD");
            AddForeignKey("dbo.Comments", "BurgerİD", "dbo.Burgers", "İD", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "BurgerİD", "dbo.Burgers");
            DropIndex("dbo.Comments", new[] { "BurgerİD" });
            DropColumn("dbo.Comments", "BurgerİD");
        }
    }
}
