using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoPerfil
    {
        public int IdTipoPerfil { get; set; }
        public string Descripcion { get; set; }

        public const int Administrador = 1;
        public const int Supervisor = 2;
        public const int Vendedor = 3;
    }
}
