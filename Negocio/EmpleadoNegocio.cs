using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        public List<Empleado> Listar()
        {
            Empleado aux;
            List<Empleado> lstEmpleados = new List<Empleado>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();

                conexion.SetearConsulta("SELECT NOMBRE, APELLIDO, IDEMPLEADO, DNI, FECHANAC, TIPOPERFIL, EMAIL FROM EMPLEADOS WHERE ACTIVO = 1");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Empleado
                    {
                        Nombre = (string)conexion.Lector["NOMBRE"],
                        Apellido = (string)conexion.Lector["APELLIDO"],
                        IdEmpleado = (int)conexion.Lector["IDEMPLEADO"],
                        Dni = (int)conexion.Lector["DNI"],
                        FechaNac = (DateTime)conexion.Lector["FECHANAC"],
                        TipoPerfil = new TipoPerfil(),
                        Email = (string)conexion.Lector["EMAIL"]
                    };
                    aux.TipoPerfil.IdTipoPerfil = (int)conexion.Lector[5];
                    aux.NombreCompleto = aux.Nombre + " " + aux.Apellido;
                    switch (aux.TipoPerfil.IdTipoPerfil)
                    {
                        case 1:
                            aux.TipoPerfilS = "Administrador";
                            break;
                        case 2:
                            aux.TipoPerfilS = "Supervisor";
                            break;
                        case 3:
                        default:
                            aux.TipoPerfilS = "Vendedor";
                            break;
                    }

                    lstEmpleados.Add(aux);
                }
                return lstEmpleados;
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

        public void Agregar(Empleado nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();

                conexion.SetearConsulta("INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,TIPOPERFIL,EMAIL,USUARIO,PASS,ACTIVO) VALUES (@nombre, @apellido, @dni, @fechanac, @tipoperfil,@email,@usuario,@pass,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@fechanac", nuevo.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@tipoperfil", nuevo.TipoPerfil.IdTipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@email", nuevo.Email);
                conexion.Comando.Parameters.AddWithValue("@usuario", nuevo.Usuario);
                conexion.Comando.Parameters.AddWithValue("@pass", GenerarMD5(nuevo.Pass));

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

        public void Modificar(Empleado e)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();

                conexion.SetearConsulta("UPDATE EMPLEADOS SET NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni, FECHANAC = @fechanac, TIPOPERFIL = @tipoperfil, EMAIL = @email, USUARIO = @usuario, PASS = @pass WHERE IDEMPLEADO = @idempleado");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", e.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", e.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", e.Dni);
                conexion.Comando.Parameters.AddWithValue("@fechanac", e.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@tipoperfil", e.TipoPerfil.IdTipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@email", e.Email);
                conexion.Comando.Parameters.AddWithValue("@idempleado", e.IdEmpleado);
                conexion.Comando.Parameters.AddWithValue("@usuario", e.Usuario);
                conexion.Comando.Parameters.AddWithValue("@pass", GenerarMD5(e.Pass));

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
     
        public bool ValidarUsuario (Empleado e)
        {
            AccesoDB conexion;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDEMPLEADO, TIPOPERFIL FROM EMPLEADOS WHERE USUARIO = @usuario AND PASS = @pass AND ACTIVO = 1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", e.Usuario);
                conexion.Comando.Parameters.AddWithValue("@pass", GenerarMD5(e.Pass));
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();
                if (conexion.Lector.Read())
                {
                    e.TipoPerfil = new TipoPerfil();
                    e.IdEmpleado = (int)conexion.Lector[0];
                    e.TipoPerfil.IdTipoPerfil = (int)conexion.Lector[1];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarMD5 (string pass)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM EMPLEADOS WHERE IDEMPLEADO = @id");
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
                conexion.SetearConsulta("UPDATE EMPLEADOS SET ACTIVO = 0 WHERE IDEMPLEADO = @id");
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
CREATE TABLE EMPLEADOS
(
    NOMBRE VARCHAR(60) NOT NULL,
    APELLIDO VARCHAR(60) NOT NULL,
    DNI INT NOT NULL,
	IDEMPLEADO INT NOT NULL PRIMARY KEY,
    FECHANAC DATE,
	USUARIO VARCHAR(60) NOT NULL,
    CONTRASENIA VARCHAR(60) NOT NULL,
    TIPOPERFIL CHAR NOT NULL,
	EMAIL VARCHAR(60) NOT NULL
)
*/