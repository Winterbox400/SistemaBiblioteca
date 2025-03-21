using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class TipoMovimientos
    {
        [Key]
        public int IdTipoMovimiento { get; set; }
        [Required]
        [MaxLength(10)]
        public string Tipo { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
