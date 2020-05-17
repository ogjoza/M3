namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Subvencija", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "KojiFaks", c => c.String());
            AddColumn("dbo.Customers", "JMBAG", c => c.String());
            DropColumn("dbo.TipStudentas", "Subvencija");
            DropColumn("dbo.TipStudentas", "KojiFaks");
            DropColumn("dbo.TipStudentas", "JMBAG");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipStudentas", "JMBAG", c => c.String());
            AddColumn("dbo.TipStudentas", "KojiFaks", c => c.String());
            AddColumn("dbo.TipStudentas", "Subvencija", c => c.Double(nullable: false));
            DropColumn("dbo.Customers", "JMBAG");
            DropColumn("dbo.Customers", "KojiFaks");
            DropColumn("dbo.Customers", "Subvencija");
        }
    }
}
