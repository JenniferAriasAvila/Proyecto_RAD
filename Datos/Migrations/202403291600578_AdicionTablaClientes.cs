namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Nombres = c.String(nullable: false, maxLength: 60),
                        Apellidos = c.String(nullable: false, maxLength: 60),
                        GrupoDescuentoId = c.Int(nullable: false),
                        CondicionPagoId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.CondicionPagoes", t => t.CondicionPagoId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoDescuentoes", t => t.GrupoDescuentoId, cascadeDelete: true)
                .Index(t => t.GrupoDescuentoId)
                .Index(t => t.CondicionPagoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "GrupoDescuentoId", "dbo.GrupoDescuentoes");
            DropForeignKey("dbo.Clientes", "CondicionPagoId", "dbo.CondicionPagoes");
            DropIndex("dbo.Clientes", new[] { "CondicionPagoId" });
            DropIndex("dbo.Clientes", new[] { "GrupoDescuentoId" });
            DropTable("dbo.Clientes");
        }
    }
}
