using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Movimientos
    {
        [Key]
        public int IdMovimiento { get; set; }
        [Required]
        public int IdTipoMovimiento { get; set; }
        [Required]
        public int IdConceptoMovimiento { get; set; }
        [Required]
        public int IdSucursal { get; set; }
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
