using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Telefono> telefonos { get; set; }
        public List<Domicilio> domicilios  { get; set; }
        public int dni { get; set; }
        public string email { get; set; }
    }
}
