namespace EntityFrameWorkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forth : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Standards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        stdName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
