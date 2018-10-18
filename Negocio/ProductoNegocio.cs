using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            Producto aux;
            List<Producto> lstProductos = new List<Producto>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT P.IDPRODUCTO, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.STOCKMIN, P.GANANCIA, P.IDMARCA, P.IDTIPOPRODUCTO FROM PRODUCTOS AS P " +
                                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                                        "WHERE P.ACTIVO = 1");
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Producto
                    {
                        IdProducto = (int)conexion.Lector["IDPRODUCTO"],
                        Marca = new Marca(),
                        TipoProducto = new TipoProducto(),
                        Descripcion = (string)conexion.Lector["DESCRIPCION"],
                        StockMin = (int)conexion.Lector["STOCKMIN"],
                        Ganancia = (float)Convert.ToDouble(conexion.Lector["GANANCIA"])
                    };
                    aux.Marca.IdMarca = (int)conexion.Lector["IDMARCA"];
                    aux.Marca.Descripcion = (string)conexion.Lector[2];
                    aux.TipoProducto.IdTipoProducto = (int)conexion.Lector["IDTIPOPRODUCTO"];
                    aux.TipoProducto.Descripcion = (string)conexion.Lector[3];

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
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Agregar(Producto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PRODUCTOS([IDMARCA],[IDTIPOPRODUCTO],[DESCRIPCION],[STOCKMIN],[GANANCIA],[ACTIVO]) VALUES (@idmarca,@idtipoproducto,@descripcion,@stockmin,@ganancia,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idmarca", nuevo.Marca.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", nuevo.TipoProducto.IdTipoProducto);
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
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
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Modificar(Producto p)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PRODUCTOS SET IDMARCA = @idmarca, IDTIPOPRODUCTO = @idtipoproducto, DESCRIPCION = @descripcion, STOCKMIN = @stockmin, GANANCIA = @ganancia WHERE IDPRODUCTO = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idmarca", p.Marca.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", p.TipoProducto.IdTipoProducto);
                conexion.Comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@stockmin", p.StockMin);
                conexion.Comando.Parameters.AddWithValue("@ganancia", p.Ganancia);
                conexion.Comando.Parameters.AddWithValue("@id", p.IdProducto);

                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM PRODUCTOS WHERE IDPRODUCTO = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void EliminarLogico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PRODUCTOS SET ACTIVO = 0 WHERE IDPRODUCTO = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
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
