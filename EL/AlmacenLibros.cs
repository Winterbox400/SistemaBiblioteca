using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class AlmacenLibros
    {
        public int IdAlmacenLibro { get; set; }
        public int IdLibro { get; set; }
        public int IdSucursal { get; set; }
        public int StockTotal { get; set; }
        public int StockDisponible { get; set; }
        public bool Activo { get; set;}
        public int IdUsuarioRegistra { get; set; }
        
        public DateTime FechaRegistro { get; set; }
        
        public int IdUsuarioActualiza { get; set; }
 
        public DateTime FechaActualizacion { get; set; }
    }
}
