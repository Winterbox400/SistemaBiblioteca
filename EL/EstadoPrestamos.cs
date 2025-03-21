using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class EstadoPrestamos
    {
        [Key]
        public int IdEstadoPrestamo { get; set; }
        [Required]
        [MaxLength(10)]
        public string Estado { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
