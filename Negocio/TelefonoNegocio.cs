using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TelefonoNegocio
    {
        public List<Telefono> Listar(int IdRelacion)
        {
            Telefono aux;
            List<Telefono> lstTelefonos = new List<Telefono>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDTELEFONO, DESCRIPCION, NUMERO FROM TELEFONOS WHERE IDRELACION = @idrelacion AND ACTIVO = 1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idrelacion", IdRelacion);
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Telefono
                    {
                        IdTelefono = (int)conexion.Lector["IDTELEFONO"],
                        IdRelacion = IdRelacion,
                        Descripcion = (string)conexion.Lector["DESCRIPCION"],
                        Numero = (int)conexion.Lector["NUMERO"]
                    };

                    lstTelefonos.Add(aux);
                }
                return lstTelefonos;
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

        public void Agregar(Telefono nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO TELEFONOS([IDRELACION],[DESCRIPCION],[NUMERO],[ACTIVO]) VALUES (@idrelacion,@descripcion,@numero,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idrelacion", nuevo.IdRelacion);
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@numero", nuevo.Numero);

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

        public void Modificar(Telefono t)
        {
            AccesoDB conexion = null;
            try
            {
                conexion.SetearConsulta("UPDATE TELEFONOS SET DESCRIPCION = @descripcion, NUMERO = @numero WHERE IDTELEFONO = @idtelefono");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", t.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@numero", t.Numero);
                conexion.Comando.Parameters.AddWithValue("@idtelefono", t.IdTelefono);

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
                conexion.SetearConsulta("DELETE FROM TELEFONOS WHERE IDTELEFONO = @id");
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
                conexion.SetearConsulta("UPDATE TELEFONOS SET ACTIVO = 0 WHERE IDTELEFONO = @id");
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
CREATE TABLE TELEFONOS
(
    IDTELEFONO INT NOT NULL IDENTITY(100000000,1) PRIMARY KEY,
    IDCONTACTO INT NOT NULL,
	NUMERO INT NOT NULL,
    DESCRIPCION VARCHAR(60) NOT NULL
)
*/