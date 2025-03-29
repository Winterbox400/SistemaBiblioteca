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
        public int IdEncabezado { get; set; }
        public string Titulo { get; set; }
        public string Direccion { get; set; }
        public int IdSucursal { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }
}
