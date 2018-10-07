using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public List<Contacto> LstContactos { get; set; }
        public List<Producto> LstProductos { get; set; }
        public long Cuit { get; set; }
        public string Empresa { get; set; }
        public bool Activo { get; set; }
    }
}
