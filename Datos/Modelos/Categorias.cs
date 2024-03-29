using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(10)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
