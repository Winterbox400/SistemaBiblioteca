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
        public int IdPrestamo { get; set; }
        public int IdEncabezado { get; set; }
        public int IdCliente { get; set; }
        public int IdMovimiento { get; set; }
        public DateTime FechaPretamo { get; set; }
        public DateTime FechaDevolucionEsperada { get; set; }
        public DateTime FechaDevolucionReal { get; set; }
        public int IdEstadoPrestamo { get; set; }
        public string Observacion {  get; set; }
        public bool Activo { get; set; } = true;
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
