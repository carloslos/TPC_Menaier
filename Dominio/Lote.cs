using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lote
    {
        public long IdLote { get; set; }
        public int IdCompra { get; set; }
        public Producto Producto { get; set; }
        public int UnidadesP { get; set; }
        public int UnidadesE { get; set; }
        public float CostoPU { get; set; }
        public float CostoT { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return IdLote.ToString() + " (" + Producto.Descripcion + ")";
        }
    }
}        

/*
CREATE TABLE LOTES
(
	IDLOTE BIGINT IDENTITY(140000000,1) NOT NULL PRIMARY KEY,
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	UNIDADES INT NOT NULL,
	COSTOPU FLOAT NOT NULL,
	VENCIMIENTO DATE,
	ACTIVO BIT NOT NULL
)
*/
