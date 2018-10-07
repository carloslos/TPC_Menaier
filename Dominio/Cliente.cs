using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Empresa { get; set; }
        public long DniCuit { get; set; }
        public char TipoCliente { get; set; } // E - Empresa // P - Particular
        public List<Contacto> Contactos { get; set; }
        public bool Activo { get; set; }
    }
}
