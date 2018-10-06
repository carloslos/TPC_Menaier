using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lote
    {
        public Lote lote { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public float costoUnitario { get; set; }
        public DateTime fechaCompra { get; set; }
        public DateTime fechaVencimiento { get; set; }
    }
}
