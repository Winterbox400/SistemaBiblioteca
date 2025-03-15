using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Correo { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]
        public string Cedula { get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public string Direccion { get; set; } = string.Empty;
        [Required]
        public bool DisponibilidadPrestamo { get; set; } = true; //Si es 1 puede prestar Libros
        [Required]
        public bool Activo { get; set; } = true;
        [Required]
        public int IdUsuarioRegistra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        [Required]
        public int IdUsuarioActualiza { get; set; }
        [Required]
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
    }
}
