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
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT IDPROVEEDOR, EMPRESA, CUIT FROM PROVEEDORES WHERE ACTIVO = 1");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Proveedor
                    {
                        IdProveedor = (int)accesoDB.Lector["IDPROVEEDOR"],
                        Empresa = (string)accesoDB.Lector["EMPRESA"],
                        Cuit = (long)accesoDB.Lector["CUIT"]
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
                if (accesoDB.checkearConexion() == true)
                {
                    accesoDB.cerrarConexion();
                }
            }
        }

        public void Agregar(Proveedor nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO PROVEEDORES(EMPRESA,CUIT,ACTIVO) VALUES (@EMPRESA,@CUIT,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@EMPRESA", nuevo.Empresa);
                conexion.Comando.Parameters.AddWithValue("@CUIT", nuevo.Cuit);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
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