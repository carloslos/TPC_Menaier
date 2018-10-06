using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Contacto
    {
        public int idEmpleado { get; set; }
        public char tipoPerfil { get; set; } // A - Administrador // S - Supervisor // V - Vendedor
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public DateTime fechaNac { get; set; }
    }
}
