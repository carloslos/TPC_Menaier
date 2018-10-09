using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EmpleadosNegocio
    {

        public List<Empleado> Listar()
        {
            Empleado aux;
            List<Empleado> lstEmpleados = new List<Empleado>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.SetearConsulta("SELECT NOMBRE, APELLIDO, IDEMPLEADO, DNI, FECHANAC, TIPOPERFIL, EMAIL FROM EMPLEADOS WHERE ACTIVO = 1");
                accesoDB.AbrirConexion();
                accesoDB.EjecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    string str = (string)accesoDB.Lector["TIPOPERFIL"];
                    aux = new Empleado
                    {
                        Nombre = (string)accesoDB.Lector["NOMBRE"],
                        Apellido = (string)accesoDB.Lector["APELLIDO"],
                        IdEmpleado = (int)accesoDB.Lector["IDEMPLEADO"],
                        Dni = (int)accesoDB.Lector["DNI"],
                        FechaNac = (DateTime)accesoDB.Lector["FECHANAC"],
                        TipoPerfil = str[0],
                        Email = (string)accesoDB.Lector["EMAIL"]
                    };

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
                if (accesoDB.CheckearConexion() == true)
                {
                    accesoDB.CerrarConexion();
                }
            }
        }

        public void Agregar(Empleado nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO EMPLEADOS(NOMBRE, APELLIDO, DNI, FECHANAC, USUARIO, CONTRASENIA, TIPOPERFIL, EMAIL) VALUES (@nombre, @apellido, @dni, @fechanac, @usuario, @contrasenia, @tipoperfil, @email)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@fechanac", nuevo.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@usuario", nuevo.Usuario);
                conexion.Comando.Parameters.AddWithValue("@contrasenia", nuevo.Contrasenia);
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
                if (conexion != null)
                    conexion.CerrarConexion();
            }
        }

        public void Modificar(Empleado e)
        {
            AccesoDB conexion;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE EMPLEADOS SET NOMBRE = @nombre, APELLIDO = @apellido WHERE IDEMPLEADO = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", e.IdEmpleado);
                conexion.Comando.Parameters.AddWithValue("@nombre", e.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", e.Apellido);
                conexion.Comando.Parameters.AddWithValue("@DNI", e.Dni);
                conexion.Comando.Parameters.AddWithValue("@FECHANAC", e.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@USUARIO", e.Usuario);
                conexion.Comando.Parameters.AddWithValue("@CONTRASENIA", e.Contrasenia);
                conexion.Comando.Parameters.AddWithValue("@TIPOPERFIL", e.TipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@EMAIL", e.Email);
                conexion.AbrirConexion();
                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion;
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
        }

        public void EliminarLogico(int id)
        {
            AccesoDB conexion;
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