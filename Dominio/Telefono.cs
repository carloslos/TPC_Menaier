using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefono
    {
        public int IdTelefono { get; set; }
        public int IdRelacion { get; set; }
        public string Descripcion { get; set; }
        public int Numero { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Numero.ToString() + " (" + Descripcion + ")";
        }
    }
}
