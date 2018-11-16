using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteE : Cliente
    {
        public long Cuit { get; set; }
        public List<Contacto> LstContactos { get; set; }

        public override string ToString()
        {
            return NombreCompleto;
        }

        public int GetId()
        {
            return IdCliente;
        }
    }
}
