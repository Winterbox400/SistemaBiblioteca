using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class Prestamos
    {
        [Key]
        public int IdPrestamo { get; set; }
        [Required]
        public int IdEncabezado { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdMovimiento { get; set; }
        [Required]
        public DateTime FechaPretamo { get; set; }
        [Required]
        public DateTime FechaDevolucionEsperada { get; set; } //Revisa los parametros de la BD
        [Required]
        public DateTime FechaDevolucionReal { get; set; }
        [Required]
        public int IdEstadoPrestamo { get; set; }
        [Required]
        [MaxLength(200)]
        public string Observacion {  get; set; } = string.Empty;
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
