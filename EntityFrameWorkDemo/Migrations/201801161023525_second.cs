namespace EntityFrameWorkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "State", c => c.String());
        }
    }
}
