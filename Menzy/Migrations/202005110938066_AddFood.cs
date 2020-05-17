namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFood : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Price = c.Double(nullable: false),
                        Kalorije = c.Int(nullable: false),
                        Masti = c.Int(nullable: false),
                        UHidrati = c.Int(nullable: false),
                        Sol = c.Int(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        TipHrane_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipHranes", t => t.TipHrane_Id)
                .Index(t => t.TipHrane_Id);
            
            CreateTable(
                "dbo.TipHranes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "TipHrane_Id", "dbo.TipHranes");
            DropIndex("dbo.Foods", new[] { "TipHrane_Id" });
           
            DropTable("dbo.TipHranes");
            DropTable("dbo.Foods");
        }
    }
}
