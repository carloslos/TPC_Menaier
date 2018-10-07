using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Departamento { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Cp { get; set; }
        public bool Activo { get; set; }
    }
}
