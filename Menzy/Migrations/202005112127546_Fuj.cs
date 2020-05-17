namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fuj : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "TipHrane_Id", "dbo.TipHranes");
            DropIndex("dbo.Foods", new[] { "TipHrane_Id" });
            AddColumn("dbo.Foods", "TipHrane", c => c.String());
            DropColumn("dbo.Foods", "TipHrane_Id");
            DropTable("dbo.TipHranes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TipHranes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Foods", "TipHrane_Id", c => c.Byte());
            DropColumn("dbo.Foods", "TipHrane");
            CreateIndex("dbo.Foods", "TipHrane_Id");
            AddForeignKey("dbo.Foods", "TipHrane_Id", "dbo.TipHranes", "Id");
        }
    }
}
