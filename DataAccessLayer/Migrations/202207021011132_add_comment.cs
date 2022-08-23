namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_comment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentİD = c.Int(nullable: false, identity: true),
                        CommentName = c.String(maxLength: 50),
                        CommentMail = c.String(maxLength: 100),
                        CommentSubject = c.String(maxLength: 50),
                        CommentMessage = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.CommentİD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
