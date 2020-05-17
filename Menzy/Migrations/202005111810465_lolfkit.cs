namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lolfkit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "TipStudentaId", "dbo.TipStudentas");
            DropIndex("dbo.Customers", new[] { "TipStudentaId" });
            AddColumn("dbo.Customers", "Redovni", c => c.Boolean(nullable: false));
            DropTable("dbo.TipStudentas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TipStudentas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Redovni = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Customers", "Redovni");
            CreateIndex("dbo.Customers", "TipStudentaId");
            AddForeignKey("dbo.Customers", "TipStudentaId", "dbo.TipStudentas", "Id", cascadeDelete: true);
        }
    }
}
