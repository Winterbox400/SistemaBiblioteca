using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class UsuariosSucursales
    {
        public int IdUsuarioSucursal { get; set; }
        public int IdUsuario { get; set; }
        public int IdSucursal { get; set; }
    }
}
