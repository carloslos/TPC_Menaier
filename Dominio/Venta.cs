using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public Venta idVenta { get; set; }
        public DateTime fecha { get; set; }
        public Empleado empleado { get; set; }
        public Cliente cliente { get; set; }
        public List<Producto> productos { get; set; }
    }
}
