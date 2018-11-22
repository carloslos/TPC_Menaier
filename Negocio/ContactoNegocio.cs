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
    public class ContactoNegocio
    {
        public List<Contacto> Listar(int id)
        {
            Contacto aux;
            List<Contacto> lstContactos = new List<Contacto>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT C.IDCONTACTO, C.NOMBRE, C.APELLIDO, C.DNI, C.EMAIL FROM CONTACTOS AS C " +
                        "INNER JOIN CONTACTOS_X_RELACION AS CXR ON CXR.IDCONTACTO = C.IDCONTACTO " +
                        "WHERE C.ACTIVO = 1 AND CXR.IDRELACION = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Contacto
                    {
                        IdContacto = (int)conexion.Lector["IDCONTACTO"],
                        Nombre = (string)conexion.Lector["NOMBRE"],
                        Apellido = (string)conexion.Lector["APELLIDO"],
                        Dni = (int)conexion.Lector["DNI"],
                        Email = (string)conexion.Lector["EMAIL"],
                    };
                    lstContactos.Add(aux);
                }
                return lstContactos;
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

        public string Agregar(Contacto nuevo)
        {
            try
            {
                string insertedID = "";

                string query = "INSERT INTO CONTACTOS(NOMBRE, APELLIDO, DNI, EMAIL, ACTIVO) VALUES (@nombre, @apellido, @dni, @email, 1); SELECT SCOPE_IDENTITY();";

                using (var dbconn = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi"))
                using (var dbcm = new SqlCommand(query, dbconn))
                {
                    dbcm.Parameters.Clear();
                    dbcm.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                    dbcm.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                    dbcm.Parameters.AddWithValue("@dni", nuevo.Dni);
                    dbcm.Parameters.AddWithValue("@email", nuevo.Email); ;

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

        public void Registrar(int IdContacto, int IdRelacion)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO CONTACTOS_X_RELACION(IDCONTACTO,IDRELACION) VALUES (@idcontacto,@idrelacion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcontacto", IdContacto);
                conexion.Comando.Parameters.AddWithValue("@idrelacion", IdRelacion);

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

        public void Modificar(Contacto c)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE CONTACTOS SET NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni, EMAIL = @email WHERE IDCONTACTO = @idcontacto");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcontacto", c.IdContacto);
                conexion.Comando.Parameters.AddWithValue("@nombre", c.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", c.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", c.Dni);
                conexion.Comando.Parameters.AddWithValue("@email", c.Email);

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
                conexion.SetearConsulta("DELETE FROM CONTACTOS WHERE IDCONTACTO = @id");
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
                conexion.SetearConsulta("UPDATE CONTACTOS SET ACTIVO = 0 WHERE IDCONTACTO = @id");
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
CREATE TABLE CONTACTOS
(
	IDCONTACTO INT NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR(60) NOT NULL,
	APELLIDO VARCHAR(60) NOT NULL,
	DNI INT,
	EMAIL VARCHAR(60) NOT NULL
)
*/