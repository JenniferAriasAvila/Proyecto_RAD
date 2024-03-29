using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [ForeignKey("Categorias")]
        public int CategoriaID { get; set; }
        [ForeignKey("UnidadDeMedida")]
        public int UnidadMedida { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
       
        public decimal PrecioCompra { get; set; }
        public virtual Categorias Categorias { get; set; }
        public virtual UnidadDeMedida UnidadDeMedida { get; set; }
    }
}
