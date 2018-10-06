using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public List<Contacto> contactos { get; set; }
        public List<Producto> productos { get; set; }
        public string empresa { get; set; }
    }
}
