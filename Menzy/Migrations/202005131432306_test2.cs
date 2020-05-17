namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "TipHrane", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "TipHrane", c => c.String());
        }
    }
}
