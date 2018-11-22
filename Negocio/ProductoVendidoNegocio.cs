using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoVendidoNegocio
    {
        public List<ProductoVendido> Listar(int IdVenta, int activo)
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
                                        "WHERE PXV.IDVENTA = @idventa AND PXV.ACTIVO = @activo");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idventa", IdVenta);
                conexion.Comando.Parameters.AddWithValue("@activo", activo);
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
                    "WHERE L.IDPRODUCTO = @idproducto AND L.ACTIVO = 1 " +
                    "ORDER BY C.FECHACOMPRA ASC");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", IdProducto);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                if (conexion.Lector.Read())
                {
                    precio = (float)Math.Round(Convert.ToDouble(conexion.Lector[0]) * ((Convert.ToDouble(conexion.Lector[1]) / 100) + 1), 3);
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
                    "WHERE L.IDPRODUCTO = @idproducto AND L.ACTIVO = 1 " +
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
            int stockTotal = 0, cantidad;
            LoteNegocio negL = new LoteNegocio();
            List<Lote> lstLotes = new List<Lote>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT L.IDLOTE, L.UNIDADESE FROM LOTES AS L " +
                    "INNER JOIN COMPRAS AS C ON C.IDCOMPRA = L.IDCOMPRA " +
                    "WHERE L.IDPRODUCTO = @idproducto AND L.ACTIVO = 1 " +
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

                if (stockTotal >= pv.Cantidad)
                {
                    int cantV = pv.Cantidad, i = 0;
                    while (cantV > 0)
                    {
                        if (cantV <= lstLotes[i].UnidadesE)
                        {
                            cantidad = cantV;
                            lstLotes[i].UnidadesE -= cantV;
                            cantV = 0;
                        }
                        else
                        {
                            cantidad = lstLotes[i].UnidadesE;
                            cantV -= lstLotes[i].UnidadesE;
                            lstLotes[i].UnidadesE = 0;
                        }
                        ActualizarStock(lstLotes[i]);
                        negL.ActualizarStock(pv.Producto.IdProducto);
                        RegistrarMovimiento(pv.IdPxv, lstLotes[i].IdLote, cantidad);
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

        private void RegistrarMovimiento(long IdPxv, long IdLote, int cantidad)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO LOTES_X_VENTA(IDPXV,IDLOTE,CANTIDAD) VALUES (@idpxv,@idlote,@cantidad)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idpxv", IdPxv);
                conexion.Comando.Parameters.AddWithValue("@idlote", IdLote);
                conexion.Comando.Parameters.AddWithValue("@cantidad", cantidad);

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

        public void RestaurarStock (long IdPxv)
        {
            List<LoteVendido> lotesv = new List<LoteVendido>();
            LoteVendido lotev;
            LoteNegocio negL = new LoteNegocio();
            Lote lote;
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDLOTE, CANTIDAD FROM LOTES_X_VENTA WHERE IDPXV = @idpxv");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idpxv", IdPxv);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    lotev = new LoteVendido
                    {
                        IdPxv = IdPxv,
                        IdLote = (long)conexion.Lector[0],
                        Cantidad = (int)conexion.Lector[1]
                    };
                    lotesv.Add(lotev);
                }

                foreach(LoteVendido lv in lotesv)
                {
                    lote = negL.ObtenerLote(lv.IdLote);
                    lote.UnidadesE += lv.Cantidad;
                    negL.ModificarStock(lote.IdLote, lote.UnidadesE);
                }
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

        public long Agregar(ProductoVendido nuevo)
        {
            try
            {
                long insertedID;

                string query = "INSERT INTO PRODUCTOS_X_VENTA(IDVENTA,IDPRODUCTO,PRECIOPU,CANTIDAD,ACTIVO) VALUES (@idventa,@idproducto,@preciopu,@cantidad,1); SELECT SCOPE_IDENTITY();";

                using (var dbconn = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi"))
                using (var dbcm = new SqlCommand(query, dbconn))
                {
                    dbcm.Parameters.Clear();
                    dbcm.Parameters.AddWithValue("@idventa", nuevo.IdVenta);
                    dbcm.Parameters.AddWithValue("@idproducto", nuevo.Producto.IdProducto);
                    dbcm.Parameters.AddWithValue("@cantidad", nuevo.Cantidad);
                    dbcm.Parameters.AddWithValue("@preciopu", nuevo.PrecioU);

                    dbconn.Open();
                    insertedID = Convert.ToInt64(dbcm.ExecuteScalar().ToString());
                }
                return insertedID;
            }
            catch (Exception ex)
            {
                throw ex;
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

        public void EliminarLogico(long id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PRODUCTOS_X_VENTA SET ACTIVO = 0 WHERE IDPXV = @id");
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
