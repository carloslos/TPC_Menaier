using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public List<ProductoVendido> LstProductosVendidos { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

