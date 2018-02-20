namespace MySommelier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(maxLength: 50),
                        ISO2 = c.String(maxLength: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10),
                        RegionName = c.String(maxLength: 50),
                        Description = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegionId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Wineries",
                c => new
                    {
                        WineryId = c.Int(nullable: false, identity: true),
                        WineryName = c.String(),
                        RegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WineryId)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Wines",
                c => new
                    {
                        WineId = c.Int(nullable: false, identity: true),
                        WineName = c.String(maxLength: 50),
                        Year = c.Int(nullable: false),
                        SealType = c.Int(nullable: false),
                        RateTaste = c.Int(nullable: false),
                        RateSmoothness = c.Int(nullable: false),
                        RatePrice = c.Int(nullable: false),
                        RateNose = c.Int(nullable: false),
                        RateDryness = c.Int(nullable: false),
                        RateFruitynes = c.Int(nullable: false),
                        RateWoodyness = c.Int(nullable: false),
                        RateSweetnes = c.Int(nullable: false),
                        WineryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WineId)
                .ForeignKey("dbo.Wineries", t => t.WineryId, cascadeDelete: true)
                .Index(t => t.WineryId);
            
            CreateTable(
                "dbo.Grapes",
                c => new
                    {
                        GrapeId = c.Int(nullable: false, identity: true),
                        GrapeName = c.String(maxLength: 50),
                        Description = c.String(),
                        Rate = c.Int(nullable: false),
                        WineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrapeId)
                .ForeignKey("dbo.Wines", t => t.WineId, cascadeDelete: true)
                .Index(t => t.WineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wines", "WineryId", "dbo.Wineries");
            DropForeignKey("dbo.Grapes", "WineId", "dbo.Wines");
            DropForeignKey("dbo.Wineries", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Regions", "CountryId", "dbo.Countries");
            DropIndex("dbo.Grapes", new[] { "WineId" });
            DropIndex("dbo.Wines", new[] { "WineryId" });
            DropIndex("dbo.Wineries", new[] { "RegionId" });
            DropIndex("dbo.Regions", new[] { "CountryId" });
            DropTable("dbo.Grapes");
            DropTable("dbo.Wines");
            DropTable("dbo.Wineries");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
        }
    }
}
