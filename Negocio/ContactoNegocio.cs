using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ContactoNegocio
    {

        public List<Contacto> Listar(int id)
        {
            Contacto aux;
            List<Contacto> lstContactos = new List<Contacto>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT E.IDEMPLEADO, E.NOMBRE, E.APELLIDO, E.DNI, E.EMAIL, TE.IDTELEFONO, TE.NUMERO, TE.DESCRIPCION, DE.IDDOMICILIO, DE.CALLE, DE.ALTURA, DE.PISO, DE.BARRIO, DE.CIUDAD, DE.PAIS FROM EMPLEADOS AS E " +
                                        "INNER JOIN TELEFONOS_X_EMPLEADO AS TE ON E.IDEMPLEADO = TE.IDEMPLEADO " +
                                        "INNER JOIN DOMICILIOS_X_EMPLEADO AS DE ON E.IDEMPLEADO = DE.IDEMPLEADO " +
                                        "WHERE ACTIVO IS 1");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Contacto
                    {
                        IdContacto = (int)accesoDB.Lector["IDCONTACTO"],
                        Nombre = (string)accesoDB.Lector["NOMBRE"],
                        Apellido = (string)accesoDB.Lector["APELLIDO"],
                        Dni = (int)accesoDB.Lector["DNI"],
                        Email = (string)accesoDB.Lector["EMAIL"],
                        Telefonos = new List<Telefono>(), // COMO LLENO ESTAS LISTAS???!!!
                        Domicilios = new List<Domicilio>()
                    };

                    //TE.IDTELEFONO, TE.NUMERO, TE.DESCRIPCION, DE.IDDOMICILIO, DE.CALLE, DE.ALTURA, DE.PISO, DE.BARRIO, DE.CIUDAD, DE.PAIS

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
                if (accesoDB.checkearConexion() == true)
                {
                    accesoDB.cerrarConexion();
                }
            }
        }

        public void Agregar(Contacto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO EMPLEADOS(NOMBRE, APELLIDO, DNI, FECHANAC, USUARIO, CONTRASENIA, TIPOPERFIL, EMAIL) VALUES (@NOMBRE, @APELLIDO, @DNI, @FECHANAC, @USUARIO, @CONTRASENIA, @TIPOPERFIL, @EMAIL)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@APELLIDO", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@DNI", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@EMAIL", nuevo.Email);

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
CREATE TABLE CONTACTOS
(
	IDCONTACTO INT NOT NULL PRIMARY KEY,
	NOMBRE VARCHAR(60) NOT NULL,
	APELLIDO VARCHAR(60) NOT NULL,
	DNI INT,
	EMAIL VARCHAR(60) NOT NULL
)
*/