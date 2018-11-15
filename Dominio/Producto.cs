using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public float Ganancia { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
