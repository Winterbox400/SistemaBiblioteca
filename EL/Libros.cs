using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Libros
    {
        [Key]
        public int IdLibro { get; set; }
        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; } = string.Empty;
        [Required]
        public int IdAutor { get; set; }
        [Required]
        public int IdEditorial { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        [Required]
        public int IdClasificacion { get; set; }
        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; } = string.Empty; // El Valor único lo administra la BD
        [Required]
        [MaxLength(20)]
        public string Ubicacion { get; set; } = string.Empty;
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
