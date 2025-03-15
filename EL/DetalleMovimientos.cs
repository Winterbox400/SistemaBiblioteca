using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class DetalleMovimientos
    {
        [Key]
        public int IdDetalleMovimiento { get; set; }
        [Required]
        public int IdLibro { get; set; }
        [Required]
        public int IdMovimiento { get; set; }
        [Required]
        public int Cantidad { get; set; } 
    }
}
