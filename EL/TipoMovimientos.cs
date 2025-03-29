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
        public int IdTipoMovimiento { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
    }
}
