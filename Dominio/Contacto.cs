using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public List<Telefono> LstTelefonos { get; set; }
        public List<Domicilio> LstDomicilios  { get; set; }
        public bool Activo { get; set; }
    }
}