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
                conexion.SetearConsulta("SELECT PXV.IDPXV, PXV.IDPRODUCTO, PXV.CANTIDAD, P.DESCRIPCION, M.DESCRIPCION, TP.DESCRIPCION, P.STOCKMIN, P.IDMARCA, P.IDTIPOPRODUCTO, PXV.PRECIOPU FROM PRODUCTOS_X_VENTA AS PXV " +
                                        "INNER JOIN PRODUCTOS AS P ON PXV.IDPRODUCTO = P.IDPRODUCTO " +
                                        "INNER JOIN MARCAS AS M ON P.IDMARCA = M.IDMARCA " +
                                        "INNER JOIN TIPOSPRODUCTO AS TP ON P.IDTIPOPRODUCTO = TP.IDTIPOPRODUCTO " +
                                        "WHERE PXV.IDVENTA = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ProductoVendido
                    {
                        IdPxv = (long)conexion.Lector[0],
                        Producto = new Producto(),
                        Cantidad = (int)conexion.Lector[2]
                    };
                    aux.Producto.Marca = new Marca();
                    aux.Producto.TipoProducto = new TipoProducto();
                    aux.Producto.IdProducto = (int)conexion.Lector[1];
                    aux.Producto.Descripcion = (string)conexion.Lector[3];
                    aux.Producto.Marca.Descripcion = (string)conexion.Lector[4];
                    aux.Producto.Marca.IdMarca = (int)conexion.Lector[7];
                    aux.Producto.StockMin = (int)conexion.Lector[6];
                    aux.Producto.TipoProducto.Descripcion = (string)conexion.Lector[5];
                    aux.Producto.TipoProducto.IdTipoProducto = (int)conexion.Lector[8];
                    aux.PrecioU = (float)Convert.ToDouble(conexion.Lector[9]);
                    aux.PrecioT = (aux.PrecioU * aux.Cantidad);

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

        public float CalcularPrecio(int IdProducto)
        {
            float precio = 0;
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT TOP 1 L.COSTOPU, P.GANANCIA FROM LOTES AS L " +
                    "INNER JOIN COMPRAS AS C ON C.IDCOMPRA = L.IDCOMPRA " +
                    "INNER JOIN PRODUCTOS AS P ON P.IDPRODUCTO = L.IDPRODUCTO " +
                    "WHERE L.IDPRODUCTO = @idproducto " +
                    "ORDER BY C.FECHACOMPRA ASC");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", IdProducto);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                if (conexion.Lector.Read())
                {
                    precio = (float)Math.Round(Convert.ToDouble(conexion.Lector[0])*((Convert.ToDouble(conexion.Lector[1])/100)+1), 3);
                }

                return precio;
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

        public void EliminarPxV(int id)
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

        public bool ControlarStock(ProductoVendido pv)
        {
            bool stocked = false;
            int stockTotal = 0;
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT L.IDLOTE, L.UNIDADESE FROM LOTES AS L " +
                    "INNER JOIN COMPRAS AS C ON C.IDCOMPRA = L.IDCOMPRA " +
                    "WHERE L.IDPRODUCTO = @idproducto " +
                    "ORDER BY C.FECHACOMPRA DESC");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", pv.Producto.IdProducto);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    stockTotal += (int)conexion.Lector[1];
                }
                if (stockTotal >= pv.Cantidad)
                {
                    stocked = true;
                }
                return stocked;
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

        public void DescontarStock(ProductoVendido pv)
        {
            Lote lote;
            int stockTotal = 0;
            List<Lote> lstLotes = new List<Lote>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT L.IDLOTE, L.UNIDADESE FROM LOTES AS L " +
                    "INNER JOIN COMPRAS AS C ON C.IDCOMPRA = L.IDCOMPRA " +
                    "WHERE L.IDPRODUCTO = @idproducto " +
                    "ORDER BY C.FECHACOMPRA DESC");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", pv.Producto.IdProducto);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    lote = new Lote
                    {
                        IdLote = (long)conexion.Lector[0],
                        UnidadesE = (int)conexion.Lector[1]
                    };
                    stockTotal += lote.UnidadesE;
                    lstLotes.Add(lote);
                }
                if( stockTotal >= pv.Cantidad )
                {
                    int cantV = pv.Cantidad, i = 0;
                    while (cantV > 0)
                    {
                        if (cantV <= lstLotes[i].UnidadesE)
                        {
                            lstLotes[i].UnidadesE -= cantV;
                            cantV = 0;
                        }
                        else
                        {
                            cantV -= lstLotes[i].UnidadesE;
                            lstLotes[i].UnidadesE = 0;
                        }
                        ActualizarStock(lstLotes[i]);
                        i++;
                    }
                }
                return;
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

        private void ActualizarStock(Lote l)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE LOTES SET UNIDADESE = @unidadese WHERE IDLOTE = @idlote");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@unidadese", l.UnidadesE);
                conexion.Comando.Parameters.AddWithValue("@idlote", l.IdLote);

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

        public void Agregar(ProductoVendido nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PRODUCTOS_X_VENTA(IDVENTA,IDPRODUCTO,PRECIOPU,CANTIDAD) VALUES (@idventa,@idproducto,@preciopu,@cantidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idventa", nuevo.IdVenta);
                conexion.Comando.Parameters.AddWithValue("@idproducto", nuevo.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@cantidad", nuevo.Cantidad);
                conexion.Comando.Parameters.AddWithValue("@preciopu", nuevo.PrecioU);

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
                conexion.SetearConsulta("UPDATE PRODUCTOS_X_VENTA SET IDPRODUCTO = @idproducto, PRECIOPU = @preciopu, CANTIDAD = @cantidad WHERE IDPXV = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", pv.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@cantidad", pv.Cantidad);
                conexion.Comando.Parameters.AddWithValue("@id", pv.IdPxv);
                conexion.Comando.Parameters.AddWithValue("@preciopu", pv.PrecioU);

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


        public void EliminarProductosDeVenta(int id)
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
