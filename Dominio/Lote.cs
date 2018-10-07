using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lote
    {
        public long IdLote { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float CostoUnitario { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Activo { get; set; }
    }
}
