namespace wypozyczalnia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Producer = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        EngineType = c.String(),
                        EngineCapacity = c.Double(nullable: false),
                        EnginePower = c.Int(nullable: false),
                        Occupied = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
