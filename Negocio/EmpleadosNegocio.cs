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

        public List<Empleado> listar()
        {
            Empleado aux;
            List<Empleado> lstEmpleados = new List<Empleado>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT NOMBRE,APELLIDO,IDEMPLEADO,DNI,FECHANAC,TIPOPERFIL,EMAIL FROM EMPLEADOS");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Empleado();
                    aux.nombre = (string)accesoDB.Lector["NOMBRE"];
                    aux.apellido = (string)accesoDB.Lector["APELLIDO"];
                    aux.idEmpleado = (int)accesoDB.Lector["IDEMPLEADO"];
                    aux.dni = (int)accesoDB.Lector["DNI"];
                    aux.fechaNac = (DateTime)accesoDB.Lector["FECHANAC"];
                    string str = (string)accesoDB.Lector["TIPOPERFIL"];
                    aux.tipoPerfil = str[0];
                    aux.email = (string)accesoDB.Lector["EMAIL"];

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
                if (accesoDB.checkearConexion() == true)
                {
                    accesoDB.cerrarConexion();
                }
            }
        }

        public void agregar(Empleado nuevo)
        {
            AccesoDB conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDB();
                consulta = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, DNI, FECHANAC, USUARIO, CONTRASENIA, TIPOPERFIL, EMAIL) " +
                           "VALUES (" + nuevo.nombre + "," + nuevo.apellido + "," + nuevo.dni + "," + nuevo.fechaNac + "," + nuevo.usuario + "," + nuevo.contrasenia + "," + nuevo.tipoPerfil + "," + nuevo.email + ")";
                conexion.setearConsulta(consulta);

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