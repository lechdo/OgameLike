namespace Jeu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        CaseNb = c.Int(),
                        SolarSystem_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id)
                .Index(t => t.SolarSystem_Id);
            
            CreateTable(
                "dbo.SolarSystems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resources", "Planet_Id", c => c.Long());
            CreateIndex("dbo.Resources", "Planet_Id");
            AddForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planets", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets");
            DropIndex("dbo.Resources", new[] { "Planet_Id" });
            DropIndex("dbo.Planets", new[] { "SolarSystem_Id" });
            DropColumn("dbo.Resources", "Planet_Id");
            DropTable("dbo.SolarSystems");
            DropTable("dbo.Planets");
        }
    }
}
