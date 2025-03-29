using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Roles
    {
        public int IdRoles { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
    }
}
