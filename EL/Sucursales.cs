using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Sucursales
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
