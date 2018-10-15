using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<Lote> LstLotes { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return IdCompra.ToString() + " (" + Proveedor.Empresa + ")";
        }
    }
}
