using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int idProducto { get; set; }
        public Marca marca { get; set; }
        public TipoProducto tipoProducto { get; set; }
        public string descripcion { get; set; }
        public int stockMin { get; set; }
        public float precio { get; set; }
        public float porcentajeGanancia { get; set; }
        public int cantidad { get; set; } // Para registrar ventas
    }
}
