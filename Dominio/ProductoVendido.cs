using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProductoVendido
    {
        public long IdPxv { get; set; }
        public int IdVenta { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioT { get; set; }
        public float PrecioU { get; set; }

        public override string ToString()
        {
            return IdPxv.ToString(); ;
        }
    }
}
