using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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
    }
}
