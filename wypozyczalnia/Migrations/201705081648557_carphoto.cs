namespace wypozyczalnia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carphoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Image");
        }
    }
}
