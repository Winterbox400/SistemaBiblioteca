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
        public int IdDetalleMovimiento { get; set; }
        public int IdLibro { get; set; }
        public int IdMovimiento { get; set; }
        public int Cantidad { get; set; } 
    }
}
