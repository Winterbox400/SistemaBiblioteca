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
        [Key]
        public int IdUsuarioSucursal { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public int IdSucursal { get; set; }
    }
}
