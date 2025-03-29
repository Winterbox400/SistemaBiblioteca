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
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int IdClasificacion { get; set; }
        public string ISBN { get; set; }
        public string Ubicacion { get; set; }
        public bool Activo { get; set; } = true;
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
