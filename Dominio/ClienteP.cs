using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteP : Cliente
    {
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public List<Telefono> LstTelefonos { get; set; }
        public List<Domicilio> LstDomicilios { get; set; }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
