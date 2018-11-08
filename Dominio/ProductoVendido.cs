using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProductoVendido
    {
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
