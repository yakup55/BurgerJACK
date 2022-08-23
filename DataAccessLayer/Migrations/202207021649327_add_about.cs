namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_about : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "AboutDetails", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Abouts", "Aboutİmage", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Aboutİmage", c => c.String(maxLength: 400));
            AlterColumn("dbo.Abouts", "AboutDetails", c => c.String(maxLength: 400));
        }
    }
}
