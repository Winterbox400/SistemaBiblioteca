using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Clasificaciones
    {
        [Key]
        public int IdClasificacion { get; set; }
        [Required]
        [MaxLength(100)]
        public string Clasificacion { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
