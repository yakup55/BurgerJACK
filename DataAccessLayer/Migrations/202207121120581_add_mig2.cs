namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "BurgerİD", "dbo.Burgers");
            DropIndex("dbo.Comments", new[] { "BurgerİD" });
            RenameColumn(table: "dbo.Comments", name: "BurgerİD", newName: "Burgers_BurgerİD");
            DropPrimaryKey("dbo.Burgers");
            AddColumn("dbo.Burgers", "BurgerİD", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Comments", "Burgerid", c => c.Int(nullable: false));
            AlterColumn("dbo.Burgers", "BurgerImage", c => c.String(maxLength: 500));
            AlterColumn("dbo.Burgers", "BurgerSpecification", c => c.String(maxLength: 500));
            AlterColumn("dbo.Comments", "Burgers_BurgerİD", c => c.Int());
            AddPrimaryKey("dbo.Burgers", "BurgerİD");
            CreateIndex("dbo.Comments", "Burgers_BurgerİD");
            AddForeignKey("dbo.Comments", "Burgers_BurgerİD", "dbo.Burgers", "BurgerİD");
            DropColumn("dbo.Burgers", "İD");
            DropTable("dbo.Eats");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Eats",
                c => new
                    {
                        İD = c.Int(nullable: false, identity: true),
                        EatName = c.String(maxLength: 50),
                        EatImage = c.String(),
                        EatPrice = c.Int(nullable: false),
                        EatSpecification = c.String(),
                    })
                .PrimaryKey(t => t.İD);
            
            AddColumn("dbo.Burgers", "İD", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Comments", "Burgers_BurgerİD", "dbo.Burgers");
            DropIndex("dbo.Comments", new[] { "Burgers_BurgerİD" });
            DropPrimaryKey("dbo.Burgers");
            AlterColumn("dbo.Comments", "Burgers_BurgerİD", c => c.Int(nullable: false));
            AlterColumn("dbo.Burgers", "BurgerSpecification", c => c.String());
            AlterColumn("dbo.Burgers", "BurgerImage", c => c.String());
            DropColumn("dbo.Comments", "Burgerid");
            DropColumn("dbo.Burgers", "BurgerİD");
            AddPrimaryKey("dbo.Burgers", "İD");
            RenameColumn(table: "dbo.Comments", name: "Burgers_BurgerİD", newName: "BurgerİD");
            CreateIndex("dbo.Comments", "BurgerİD");
            AddForeignKey("dbo.Comments", "BurgerİD", "dbo.Burgers", "İD", cascadeDelete: true);
        }
    }
}
