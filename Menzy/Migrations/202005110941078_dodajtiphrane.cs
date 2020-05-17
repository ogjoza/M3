namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodajtiphrane : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipHranes (Id, Name) VALUES (1, 'Predjelo')");
            Sql("INSERT INTO TipHranes (Id, Name) VALUES (2, 'Glavno jelo')");
            Sql("INSERT INTO TipHranes (Id, Name) VALUES (3, 'Desert')");
            Sql("INSERT INTO TipHranes (Id, Name) VALUES (4, 'Piće')");
        }
        
        public override void Down()
        {
        }
    }
}
