using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Base_de_datos
{
    public class Conexion: DbContext
    {
        public Conexion() : base("name=Proyecto_Rad")
        {

        }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<GrupoDescuento> GrupoDescuento { get; set; }
        public DbSet<UnidadDeMedida> UnidadDeMedida { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<CondicionPago> CondicionPago { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}
