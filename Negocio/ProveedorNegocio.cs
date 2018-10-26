using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> Listar()
        {
            Proveedor aux;
            List<Proveedor> lstProveedores = new List<Proveedor>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDPROVEEDOR, EMPRESA, CUIT FROM PROVEEDORES WHERE ACTIVO = 1");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Proveedor
                    {
                        IdProveedor = (int)conexion.Lector["IDPROVEEDOR"],
                        Empresa = (string)conexion.Lector["EMPRESA"],
                        Cuit = (long)conexion.Lector["CUIT"],
                        LstContactos = new List<Contacto>(), 
                        LstProductos = new List<Producto>()
                    };

                    lstProveedores.Add(aux);
                }

                return lstProveedores;

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

        public void Agregar(Proveedor nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO PROVEEDORES(EMPRESA,CUIT,ACTIVO) VALUES (@empresa,@cuit,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@empresa", nuevo.Empresa);
                conexion.Comando.Parameters.AddWithValue("@cuit", nuevo.Cuit);

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

        public void Modificar(Proveedor p)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PROVEEDORES SET EMPRESA = @empresa, CUIT = @cuit WHERE IDPROVEEDOR = @idproveedor");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@empresa", p.Empresa);
                conexion.Comando.Parameters.AddWithValue("@cuit", p.Cuit);
                conexion.Comando.Parameters.AddWithValue("@idproveedor", p.IdProveedor);

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
                conexion.SetearConsulta("DELETE FROM PROVEEDORES WHERE IDPROVEEDOR = @id");
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
                conexion.SetearConsulta("UPDATE PROVEEDORES SET ACTIVO = 0 WHERE IDPROVEEDOR = @id");
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
CREATE TABLE PROVEEDORES
(
	IDPROVEEDOR INT NOT NULL PRIMARY KEY,
	EMPRESA VARCHAR(60) NOT NULL,
	CUIT BIGINT NOT NULL,
	ACTIVO BIT NOT NULL
)
*/