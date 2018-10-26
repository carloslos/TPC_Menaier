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
                    string s = (string)conexion.Lector["TIPOPERFIL"];
                    aux = new Empleado
                    {
                        Nombre = (string)conexion.Lector["NOMBRE"],
                        Apellido = (string)conexion.Lector["APELLIDO"],
                        IdEmpleado = (int)conexion.Lector["IDEMPLEADO"],
                        Dni = (int)conexion.Lector["DNI"],
                        FechaNac = (DateTime)conexion.Lector["FECHANAC"],
                        TipoPerfil = s[0],
                        Email = (string)conexion.Lector["EMAIL"]
                    };

                    switch (aux.TipoPerfil)
                    {
                        case 'A':
                            aux.TipoPerfilS = "Administrador";
                            break;
                        case 'S':
                            aux.TipoPerfilS = "Supervisor";
                            break;
                        case 'V':
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
                conexion.SetearConsulta("SET DATEFORMAT dmy; INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,TIPOPERFIL,EMAIL,ACTIVO) VALUES (@nombre, @apellido, @dni, @fechanac, @tipoperfil, @email,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@fechanac", nuevo.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@tipoperfil", nuevo.TipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@email", nuevo.Email);

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
                conexion.SetearConsulta("SET DATEFORMAT dmy; UPDATE EMPLEADOS SET NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni, FECHANAC = @fechanac, TIPOPERFIL = @tipoperfil, EMAIL = @email WHERE IDEMPLEADO = @idempleado");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", e.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", e.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", e.Dni);
                conexion.Comando.Parameters.AddWithValue("@fechanac", e.FechaNac.ToShortDateString());
                conexion.Comando.Parameters.AddWithValue("@tipoperfil", e.TipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@email", e.Email);
                conexion.Comando.Parameters.AddWithValue("@idempleado", e.IdEmpleado);

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