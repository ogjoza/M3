namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JeliRedovniStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RedovniStudent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RedovniStudent");
        }
    }
}
