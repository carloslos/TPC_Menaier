using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ClienteENegocio
    {
        public List<ClienteE> Listar()
        {
            ClienteE aux;
            List<ClienteE> lstClientesE = new List<ClienteE>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT EMPRESA, IDCLIENTE, DNICUIT FROM CLIENTES" +
                    "WHERE ACTIVO = 1 AND TIPOCLIENTE = 'E'");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new ClienteE
                    {
                        Empresa = (string)conexion.Lector["EMPRESA"],
                        IdCliente = (int)conexion.Lector["IDCLIENTE"],
                        Cuit = (int)conexion.Lector["DNICUIT"],
                    };

                    lstClientesE.Add(aux);
                }
                return lstClientesE;
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

        public void Agregar(ClienteE nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO CLIENTES(EMPRESA,DNICUIT,TIPOCLIENTE,ACTIVO) VALUES (@empresa, @cuit, 'E', 1)");
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

        public void Modificar(ClienteE c)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE CLIENTES SET EMPRESA = @empresa, DNICUIT = @cuit WHERE IDCLIENTE = @idcliente");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@empresa", c.Empresa);
                conexion.Comando.Parameters.AddWithValue("@cuit", c.Cuit);
                conexion.Comando.Parameters.AddWithValue("@idcliente", c.IdCliente);

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
                conexion.SetearConsulta("DELETE FROM CLIENTES WHERE IDCLIENTE = @id");
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
                conexion.SetearConsulta("UPDATE CLIENTES SET ACTIVO = 0 WHERE IDCLIENTE = @id");
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
CREATE TABLE CLIENTES
(
	IDCLIENTE INT NOT NULL IDENTITY(30000000,1) PRIMARY KEY,
	DNICUIT BIGINT NOT NULL,
	EMPRESA VARCHAR(60),
	NOMBRE VARCHAR(60),
	APELLIDO VARCHAR(60),
	TIPOCLIENTE VARCHAR(2) NOT NULL,
	EMAIL VARCHAR(60),
	ACTIVO BIT NOT NULL
)
*/
