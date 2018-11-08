using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class VentaNegocio /// TODO: VENTAS NEGOCIO
    {
        public List<Venta> Listar()
        {
            Venta aux;
            List<Venta> lstVentas = new List<Venta>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT C.IDCOMPRA, C.FECHACOMPRA, C.IDPROVEEDOR, C.FECHAREGISTRO, P.EMPRESA, P.CUIT FROM COMPRAS AS C " +
                    "INNER JOIN PROVEEDORES AS P ON C.IDPROVEEDOR = P.IDPROVEEDOR " +
                    "WHERE C.ACTIVO = 1");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Venta();

                    lstVentas.Add(aux);
                }

                return lstVentas;

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

        public void Agregar(Compra nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO COMPRAS(IDPROVEEDOR,FECHACOMPRA,ACTIVO) VALUES (@idproveedor,@fechacompra,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproveedor", nuevo.Proveedor.IdProveedor);
                conexion.Comando.Parameters.AddWithValue("@fechacompra", nuevo.FechaCompra);
                conexion.Comando.Parameters.AddWithValue("@fecharegistro", DateTime.Now);

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

        public void Modificar(Compra c)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE COMPRAS SET IDPROVEEDOR = @idproveedor, FECHACOMPRA = @fechacompra WHERE IDCOMPRA = @idcompra");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcompra", c.IdCompra);
                conexion.Comando.Parameters.AddWithValue("@idproveedor", c.Proveedor.IdProveedor);
                conexion.Comando.Parameters.AddWithValue("@fechacompra", c.FechaCompra);

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
                conexion.SetearConsulta("DELETE FROM COMPRAS WHERE IDPRODUCTO = @id");
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
                conexion.SetearConsulta("UPDATE COMPRAS SET ACTIVO = 0 WHERE IDPRODUCTO = @id");
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
