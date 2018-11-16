using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Contacto
    {
        public int IdEmpleado { get; set; }
        public DateTime FechaNac { get; set; }
        public string NombreCompleto { get; set; }
        public TipoPerfil TipoPerfil { get; set; } // 1 - Administrador // 2 - Supervisor // 3 - Vendedor
        public string TipoPerfilS { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}