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
        public int IdEstadoPrestamo { get; set; }
        public string Estado { get; set; }
        public bool Activo { get; set; }
    }
}
