using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> Listar(int Id)
        {
            Producto aux;
            LoteNegocio negL = new LoteNegocio();
            List<Producto> lstProductos = new List<Producto>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                if(Id == 0)
                {
                    conexion.SetearConsulta("SELECT P.IDPRODUCTO, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.STOCKMIN, P.GANANCIA, P.IDMARCA, P.IDTIPOPRODUCTO, P.STOCK FROM PRODUCTOS AS P " +
                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                        "WHERE P.ACTIVO = 1 " +
                        "ORDER BY P.DESCRIPCION ASC");
                }
                else
                {   
                    conexion.SetearConsulta("SELECT P.IDPRODUCTO, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.STOCKMIN, P.GANANCIA, P.IDMARCA, P.IDTIPOPRODUCTO, P.STOCK FROM PRODUCTOS AS P " +
                        "INNER JOIN PRODUCTOS_X_PROVEEDOR AS PXP ON PXP.IDPRODUCTO = P.IDPRODUCTO " +
                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                        "WHERE P.ACTIVO = 1 AND PXP.IDPROVEEDOR = @id " +
                        "ORDER BY P.DESCRIPCION ASC");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@id", Id);
                }

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
                        Ganancia = (float)Convert.ToDouble(conexion.Lector["GANANCIA"]),
                        Stock = (int)conexion.Lector["STOCK"]
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
                conexion.SetearConsulta("INSERT INTO PRODUCTOS(IDMARCA,IDTIPOPRODUCTO,DESCRIPCION,STOCKMIN,STOCK,GANANCIA,ACTIVO) VALUES (@idmarca,@idtipoproducto,@descripcion,@stockmin,0,@ganancia,1)");
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
                conexion.SetearConsulta("UPDATE PRODUCTOS SET IDMARCA = @idmarca, IDTIPOPRODUCTO = @idtipoproducto, DESCRIPCION = @descripcion, STOCKMIN = @stockmin, GANANCIA = @ganancia WHERE IDPRODUCTO = @idproducto");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idmarca", p.Marca.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", p.TipoProducto.IdTipoProducto);
                conexion.Comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@stockmin", p.StockMin);
                conexion.Comando.Parameters.AddWithValue("@ganancia", p.Ganancia);
                conexion.Comando.Parameters.AddWithValue("@idproducto", p.IdProducto);

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

        public void AgregarProductoDeProveedor(int IdProducto, int IdProveedor)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PRODUCTOS_X_PROVEEDOR(IDPRODUCTO, IDPROVEEDOR) VALUES (@idproducto, @idproveedor)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", IdProducto);
                conexion.Comando.Parameters.AddWithValue("@idproveedor", IdProveedor);

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

        public void EliminarProductoDeProveedor(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM PRODUCTOS_X_PROVEEDOR WHERE IDPROVEEDOR = @id");
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
