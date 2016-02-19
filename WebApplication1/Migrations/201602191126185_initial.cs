namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        TelefoneId = c.Guid(nullable: false),
                        Numero = c.String(),
                        PessoaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.TelefoneId)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "PessoaId", "dbo.Pessoas");
            DropIndex("dbo.Telefones", new[] { "PessoaId" });
            DropTable("dbo.Telefones");
            DropTable("dbo.Pessoas");
        }
    }
}
