using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductosNegocio
    {
        public List<Producto> listar()
        {
            Producto aux;
            List<Producto> lstProductos = new List<Producto>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT P.IDPRODUCTO, M.DESCRIPCION, TP.DESCRIPCION, P.DESCRIPCION, P.PRECIO, P.STOCKMIN, P.PORCENTAJEGANANCIA FROM PRODUCTOS AS P " +
                                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPO = TP.IDTIPO");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Producto();
                    aux.idProducto = (int)accesoDB.Lector["P.IDPRODUCTO"];
                    aux.marca.descripcion = (string)accesoDB.Lector["M.DESCRIPCION"];
                    aux.tipoProducto.descripcion = (string)accesoDB.Lector["TP.DESCRIPCION"];
                    aux.descripcion = (string)accesoDB.Lector["P.DESCRIPCION"];
                    aux.precio = (float)accesoDB.Lector["P.PRECIO"];
                    aux.stockMin = (int)accesoDB.Lector["P.STOCKMIN"];
                    aux.porcentajeGanancia = (float)accesoDB.Lector["P.PORCENTAJEGANANCIA"];

                    lstProductos.Add(aux);
                }

                return lstProductos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (accesoDB.checkearConexion() == true)
                {
                    accesoDB.cerrarConexion();
                }
            }
        }

        public void agregar(Producto nuevo)
        {
            AccesoDB conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDB();
                consulta = "INSERT INTO PRODUCTOS (DESCRIPCION) VALUES (" + nuevo.descripcion + ")";
                conexion.setearConsulta(consulta);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }
    }
}

/*
CREATE TABLE PRODUCTOS
(
	IDPRODUCTO INT NOT NULL PRIMARY KEY,
	IDMARCA INT NOT NULL FOREIGN KEY REFERENCES MARCAS(IDMARCA),
	IDTIPO INT NOT NULL FOREIGN KEY REFERENCES TIPOSPRODUCTO(IDTIPO),
	DESCRIPCION VARCHAR(60) NOT NULL,
	PRECIO MONEY NOT NULL,
	STOCKMIN INT NOT NULL,
	PORCENTAJEGANANCIA FLOAT NOT NULL
)
 */
