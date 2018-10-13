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
        //public double Precio { get; set; }
        public double Ganancia { get; set; }
        public int StockMin { get; set; }
        public bool Activo { get; set; }
    }
}
