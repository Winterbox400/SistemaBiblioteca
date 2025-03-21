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
        [Key]
        public int IdRoles { get; set; }
        [Required]
        [MaxLength(30)]
        public string Rol { get; set; } = string.Empty;
        [Required]
        public bool Activo { get; set; } = true;
    }
}
