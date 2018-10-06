using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int idCompra { get; set; }
        public DateTime fecha { get; set; }
        public Proveedor proveedor { get; set; }
        public List<Lote> lotes { get; set; }
    }
}
