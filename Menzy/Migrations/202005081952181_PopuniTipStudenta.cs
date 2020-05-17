namespace Menzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopuniTipStudenta : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipStudentas(Id,Redovni,Subvencija,KojiFaks,JMBAG) VALUES(1,0,0,0,0)");
            Sql("INSERT INTO TipStudentas(Id,Redovni,Subvencija,KojiFaks,JMBAG) VALUES(2,1,1000,1,15315125)");
        }
        
        public override void Down()
        {
        }
    }
}
