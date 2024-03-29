using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
   public  class CondicionPago
    {
        [Key]
        public int CondicionPagoId { get; set; }
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Dias { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
