namespace ClothBazarOnline.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        OCategories_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OCategories", t => t.OCategories_ID)
                .Index(t => t.OCategories_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OProducts", "OCategories_ID", "dbo.OCategories");
            DropIndex("dbo.OProducts", new[] { "OCategories_ID" });
            DropTable("dbo.OProducts");
            DropTable("dbo.OCategories");
        }
    }
}
