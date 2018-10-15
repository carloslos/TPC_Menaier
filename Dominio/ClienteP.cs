using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteP : Contacto
    {
        public int IdCliente { get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
