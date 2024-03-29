namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaProductos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        CategoriaID = c.Int(nullable: false),
                        UnidadMedida = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .ForeignKey("dbo.UnidadDeMedidas", t => t.UnidadMedida, cascadeDelete: true)
                .Index(t => t.CategoriaID)
                .Index(t => t.UnidadMedida);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "UnidadMedida", "dbo.UnidadDeMedidas");
            DropForeignKey("dbo.Productos", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "UnidadMedida" });
            DropIndex("dbo.Productos", new[] { "CategoriaID" });
            DropTable("dbo.Productos");
        }
    }
}
