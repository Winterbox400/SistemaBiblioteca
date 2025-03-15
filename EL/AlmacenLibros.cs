using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class AlmacenLibros
    {
        [Key]
        public int IdAlmacenLibro { get; set; }
        [Required]
        public int IdLibro { get; set; }
        [Required]
        public int IdSucursal { get; set; }
        [Required]
        public int StockTotal { get; set; } = 0;
        [Required]
        public int StockDisponible { get; set; } = 0;
        [Required]
        public bool Activo { get; set; } = true;
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        [Required]
        public int IdUsuarioActualiza { get; set; }
        [Required]
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
    }
}
