using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string empresa { get; set; }
        public int cuit { get; set; }
        public char tipoCliente { get; set; } // E - Empresa // P - Particular
        public List<Contacto> contactos { get; set; }
    }
}
