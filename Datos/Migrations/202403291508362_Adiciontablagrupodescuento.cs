namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adiciontablagrupodescuento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoDescuentoes",
                c => new
                    {
                        GrupoDescuentoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        Porcentaje = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GrupoDescuentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoDescuentoes");
        }
    }
}
