using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Encabezados
    {
        [Key]
        public int IdEncabezado { get; set; }
        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public string Direccion { get; set; } = string.Empty;
        [Required]
        public int IdSucursal { get; set; }
        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
