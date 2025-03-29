using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Autores
    {
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
