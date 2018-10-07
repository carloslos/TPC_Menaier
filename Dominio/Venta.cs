using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public Venta IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> LstProductos { get; set; }
        public bool Activo { get; set; }
    }
}
