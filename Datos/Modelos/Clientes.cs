using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Modelos;

namespace Datos.Modelos
{
   public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(60)]
        public string Apellidos { get; set; }
        [ForeignKey("GrupoDescuento")]
        public int GrupoDescuentoId { get; set;  } 
        [ForeignKey("CondicionPago")]
        public int CondicionPagoId { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual GrupoDescuento GrupoDescuento { get; set; }
        public virtual CondicionPago CondicionPago { get; set; }
    }
}
