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
        public char TipoPerfil { get; set; } // A - Administrador // S - Supervisor // V - Vendedor
        public string TipoPerfilS { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}