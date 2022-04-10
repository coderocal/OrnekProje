namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        Adi = c.String(unicode: false),
                        Soyadi = c.String(unicode: false),
                        DTarih = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.PersonelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personel");
        }
    }
}
