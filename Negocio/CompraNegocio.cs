using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class CompraNegocio
    {
        public List<Compra> Listar(int activo)
        {
            Compra aux;
            List<Compra> lstCompras = new List<Compra>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT C.IDCOMPRA, C.FECHACOMPRA, C.IDPROVEEDOR, C.FECHAREGISTRO, P.EMPRESA, P.CUIT FROM COMPRAS AS C " +
                    "INNER JOIN PROVEEDORES AS P ON C.IDPROVEEDOR = P.IDPROVEEDOR " +
                    "WHERE C.ACTIVO = @activo");

                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@activo", activo);

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

        public string Agregar(Compra nuevo)
        {
            try
            {
                string insertedID = "";

                string query = "INSERT INTO COMPRAS(IDPROVEEDOR,FECHACOMPRA,ACTIVO) VALUES (@idproveedor,@fechacompra,1); SELECT SCOPE_IDENTITY();";

                using (var dbconn = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi"))
                using (var dbcm = new SqlCommand(query, dbconn))
                {
                    dbcm.Parameters.Clear();
                    dbcm.Parameters.AddWithValue("@idproveedor", nuevo.Proveedor.IdProveedor);
                    dbcm.Parameters.AddWithValue("@fechacompra", nuevo.FechaCompra);
                    dbcm.Parameters.AddWithValue("@fecharegistro", DateTime.Now);

                    dbconn.Open();
                    insertedID = dbcm.ExecuteScalar().ToString();
                }
                return insertedID;
            }
            catch (Exception ex)
            {
                throw ex;
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

        public bool AnularCompra(Compra c)
        {
            LoteNegocio negL = new LoteNegocio();
            List<Lote> lotes = negL.Listar(c.IdCompra, 1);

            foreach(Lote l in lotes)
            {
                if(l.UnidadesE != l.UnidadesP)
                {
                    return false;
                }
            }

            EliminarLogico(c.IdCompra);

            foreach(Lote l in lotes)
            {
                negL.EliminarLogico(l.IdLote);
                negL.ActualizarStock(l.Producto.IdProducto);
            }

            return true;
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM COMPRAS WHERE IDCOMPRA = @id");
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
                conexion.SetearConsulta("UPDATE COMPRAS SET ACTIVO = 0 WHERE IDCOMPRA = @id");
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
