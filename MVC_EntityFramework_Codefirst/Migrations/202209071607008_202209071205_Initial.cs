namespace MVC_EntityFramework_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202209071205_Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        DateBirth = c.DateTime(nullable: false),
                        Phone = c.String(),
                        ProfessionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professions", t => t.ProfessionId, cascadeDelete: true)
                .Index(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Profession_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professions", t => t.Profession_Id)
                .Index(t => t.Profession_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personas", "ProfessionId", "dbo.Professions");
            DropForeignKey("dbo.Professions", "Profession_Id", "dbo.Professions");
            DropIndex("dbo.Professions", new[] { "Profession_Id" });
            DropIndex("dbo.Personas", new[] { "ProfessionId" });
            DropTable("dbo.Professions");
            DropTable("dbo.Personas");
        }
    }
}
