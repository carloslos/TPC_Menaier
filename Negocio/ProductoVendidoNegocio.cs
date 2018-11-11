using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
/// <summary>
/// TODO: PRODUCTO VENDIDO NEGOCIO
/// </summary>
namespace Negocio
{
    public class ProductoVendidoNegocio
    {
        public List<ProductoVendido> Listar(int id)
        {
            ProductoVendido aux;
            List<ProductoVendido> lstProductosVendidos = new List<ProductoVendido>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT PXV.IDPRODUCTO, PXV.CANTIDAD, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.STOCKMIN, P.IDMARCA, P.IDTIPOPRODUCTO FROM PRODUCTOS_X_VENTA AS PXV " +
                                        "INNER JOIN PRODUCTOS AS P ON PXV.IDPRODUCTO = P.IDPRODUCTO " +
                                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                                        "WHERE PXV.ACTIVO = 1 AND IDVENTA = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ProductoVendido
                    {
                        Producto = new Producto(),
                        Cantidad = (int)conexion.Lector[1]
                    };
                    aux.Producto.Marca = new Marca();
                    aux.Producto.TipoProducto = new TipoProducto();
                    aux.Producto.IdProducto = (int)conexion.Lector[1];
                    aux.Producto.Descripcion = (string)conexion.Lector[2];
                    aux.Producto.Marca.Descripcion = (string)conexion.Lector[3];
                    aux.Producto.Marca.IdMarca = (int)conexion.Lector[6];
                    aux.Producto.TipoProducto.Descripcion = (string)conexion.Lector[4];
                    aux.Producto.TipoProducto.IdTipoProducto = (int)conexion.Lector[7];

                    lstProductosVendidos.Add(aux);
                }

                return lstProductosVendidos;

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

        public void Agregar(ProductoVendido nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PRODUCTOS_X_VENTA(IDVENTA,IDPRODUCTO,CANTIDAD) VALUES (@idventa,@idproducto,@cantidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcompra", nuevo.Venta.IdVenta);
                conexion.Comando.Parameters.AddWithValue("@idproducto", nuevo.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@cantidad", nuevo.Cantidad);

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

        public void Modificar(ProductoVendido pv)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PRODUCTOS_X_VENTA SET IDPRODUCTO = @idproducto, CANTIDAD = @cantidad WHERE IDPXV = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", pv.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@cantidad", pv.Cantidad);
                //conexion.Comando.Parameters.AddWithValue("@id", pv.IdPxv);

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


        public void EliminarLotesDeCompra(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM PRODUCTOS_X_VENTA WHERE IDVENTA = @id");
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

        public void EliminarFisico(long id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM PRODUCTOS_X_VENTA WHERE IDPXV = @id");
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
