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
        public List<Producto> Listar()
        {
            Producto aux;
            List<Producto> lstProductos = new List<Producto>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.SetearConsulta("SELECT P.IDPRODUCTO, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.PRECIO, P.STOCKMIN, P.GANANCIA, P.IDMARCA, P.IDTIPOPRODUCTO FROM PRODUCTOS AS P " +
                                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                                        "WHERE P.ACTIVO = 1");
                accesoDB.AbrirConexion();
                accesoDB.EjecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Producto
                    {
                        IdProducto = (int)accesoDB.Lector["P.IDPRODUCTO"],
                        Marca = new Marca(),
                        TipoProducto = new TipoProducto(),
                        Descripcion = (string)accesoDB.Lector["P.DESCRIPCION"],
                        Precio = (double)accesoDB.Lector["P.PRECIO"],
                        StockMin = (int)accesoDB.Lector["P.STOCKMIN"],
                        Ganancia = (double)accesoDB.Lector["P.GANANCIA"]
                    };
                    aux.Marca.IdMarca = (int)accesoDB.Lector["P.IDMARCA"];
                    aux.Marca.Descripcion = (string)accesoDB.Lector["M.DESCRIPCION"];
                    aux.TipoProducto.IdTipoProducto = (int)accesoDB.Lector["P.IDTIPOPRODUCTO"];
                    aux.TipoProducto.Descripcion = (string)accesoDB.Lector["TP.DESCRIPCION"];

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
                if (accesoDB.CheckearConexion() == true)
                {
                    accesoDB.CerrarConexion();
                }
            }
        }

        public void Agregar(Producto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PRODUCTOS(IDMARCA, IDTIPOPRODUCTO, DESCRIPCION, PRECIO, STOCKMIN, GANANCIA) VALUES (@idmarca, @idtipoproducto, @descripcion, @precio, @stockmin, @ganancia)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idmarca", nuevo.Marca.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", nuevo.TipoProducto.IdTipoProducto);
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@precio", nuevo.Precio);
                conexion.Comando.Parameters.AddWithValue("@stockmin", nuevo.StockMin);
                conexion.Comando.Parameters.AddWithValue("@ganancia", nuevo.Ganancia);

                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.CerrarConexion();
            }
        }
    }
}

/*
CREATE TABLE PRODUCTOS
(
	IDPRODUCTO INT NOT NULL PRIMARY KEY,
	IDMARCA INT NOT NULL FOREIGN KEY REFERENCES MARCAS(IDMARCA),
	IDTIPOPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES TIPOSPRODUCTO(IDTIPOPRODUCTO),
	DESCRIPCION VARCHAR(60) NOT NULL,
	PRECIO MONEY NOT NULL,
	STOCKMIN INT NOT NULL,
	PORCENTAJEGANANCIA FLOAT NOT NULL
)
 */
