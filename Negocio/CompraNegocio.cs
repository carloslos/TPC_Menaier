using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CompraNegocio
    {
        public List<Compra> Listar()
        {
            Compra aux;
            List<Compra> lstCompras = new List<Compra>();
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
                    aux = new Compra
                    {
                        IdCompra = (int)conexion.Lector["IDCOMPRA"],
                        Proveedor = new Proveedor(),
                        FechaCompra = (DateTime)conexion.Lector["FECHACOMPRA"],
                        FechaRegistro = (DateTime)conexion.Lector["FECHAREGISTRO"],
                    };
                    aux.Proveedor.IdProveedor = (int)conexion.Lector["IDPROVEEDOR"];
                    aux.Proveedor.Empresa = (string)conexion.Lector["EMPRESA"];
                    aux.Proveedor.Cuit = Convert.ToInt64(conexion.Lector["CUIT"]);

                    lstCompras.Add(aux);
                }

                return lstCompras;

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

/*
CREATE TABLE COMPRAS
(
	IDCOMPRA INT NOT NULL IDENTITY(90000000,1) PRIMARY KEY,
	FECHA DATE NOT NULL,
	IDPROVEEDOR INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(IDPROVEEDOR),
	ACTIVO BIT NOT NULL,
	FECHACREACION DATETIME NOT NULL DEFAULT GETDATE()
)
*/
