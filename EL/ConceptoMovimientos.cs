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
        public int IdConceptoMovimiento { get; set; }
        public string Concepto { get; set; }
        public bool Activo { get; set; }
    }
}
