namespace ClothBazarOnline.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondtime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OProducts", "OCategories_ID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OProducts", "OCategories_ID", c => c.Int());
        }
    }
}
