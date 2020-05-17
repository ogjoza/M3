namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class racun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Racuns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Food_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.Food_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Food_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Racuns", "Food_Id", "dbo.Foods");
            DropForeignKey("dbo.Racuns", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Racuns", new[] { "Food_Id" });
            DropIndex("dbo.Racuns", new[] { "Customer_Id" });
            DropTable("dbo.Racuns");
        }
    }
}
