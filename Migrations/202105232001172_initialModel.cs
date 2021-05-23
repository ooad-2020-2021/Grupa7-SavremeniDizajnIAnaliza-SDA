namespace Solidarity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistrovaniKorisnik",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Administrator",
                c => new
                    {
                        id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RegistrovaniKorisnik", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Gradjanin",
                c => new
                    {
                        id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RegistrovaniKorisnik", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Volonter",
                c => new
                    {
                        id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RegistrovaniKorisnik", t => t.id)
                .Index(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Volonter", "id", "dbo.RegistrovaniKorisnik");
            DropForeignKey("dbo.Gradjanin", "id", "dbo.RegistrovaniKorisnik");
            DropForeignKey("dbo.Administrator", "id", "dbo.RegistrovaniKorisnik");
            DropIndex("dbo.Volonter", new[] { "id" });
            DropIndex("dbo.Gradjanin", new[] { "id" });
            DropIndex("dbo.Administrator", new[] { "id" });
            DropTable("dbo.Volonter");
            DropTable("dbo.Gradjanin");
            DropTable("dbo.Administrator");
            DropTable("dbo.RegistrovaniKorisnik");
        }
    }
}
