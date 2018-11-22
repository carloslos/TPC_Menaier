using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LoteVendido
    {
        public long IdPxv { get; set; }
        public long IdLote { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return IdLote.ToString() + " -> " + IdPxv.ToString();
        }
    }
}
