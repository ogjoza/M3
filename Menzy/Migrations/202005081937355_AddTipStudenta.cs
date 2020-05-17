namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTipStudenta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipStudentas",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Redovni = c.Boolean(nullable: false),
                        Subvencija = c.Double(nullable: false),
                        KojiFaks = c.String(),
                        JMBAG = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "EmailStud", c => c.String());
            AddColumn("dbo.Customers", "TipStudentaId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "TipStudentaId");
            AddForeignKey("dbo.Customers", "TipStudentaId", "dbo.TipStudentas", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "RedovniStudent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "RedovniStudent", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customers", "TipStudentaId", "dbo.TipStudentas");
            DropIndex("dbo.Customers", new[] { "TipStudentaId" });
            DropColumn("dbo.Customers", "TipStudentaId");
            DropColumn("dbo.Customers", "EmailStud");
            DropTable("dbo.TipStudentas");
        }
    }
}
