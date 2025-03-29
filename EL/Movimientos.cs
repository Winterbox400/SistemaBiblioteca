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
        public int IdMovimiento { get; set; }
        public int IdTipoMovimiento { get; set; }
        public int IdConceptoMovimiento { get; set; }
        public int IdSucursal { get; set; }
        public bool Activo { get; set; } = true;
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
