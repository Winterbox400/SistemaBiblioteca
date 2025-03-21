using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class ConceptoMovimientos
    {
        [Key]
        public int IdConceptoMovimiento { get; set; }
        [Required]
        [MaxLength(50)]
        public string Concepto { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
