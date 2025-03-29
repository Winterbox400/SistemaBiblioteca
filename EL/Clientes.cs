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
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public bool DisponibilidadPrestamo { get; set; }//Si es 1 puede prestar Libros
        public bool Activo { get; set; } = true;
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
