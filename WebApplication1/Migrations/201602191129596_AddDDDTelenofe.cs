namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDDDTelenofe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Telefones", "DDD", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Telefones", "DDD");
        }
    }
}
