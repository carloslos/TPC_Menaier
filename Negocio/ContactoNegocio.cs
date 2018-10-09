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
                accesoDB.SetearConsulta("SELECT E.IDEMPLEADO, E.NOMBRE, E.APELLIDO, E.DNI, E.EMAIL, TE.IDTELEFONO, TE.NUMERO, TE.DESCRIPCION, DE.IDDOMICILIO, DE.CALLE, DE.ALTURA, DE.PISO, DE.BARRIO, DE.CIUDAD, DE.PAIS FROM EMPLEADOS AS E " +
                                        "INNER JOIN TELEFONOS_X_EMPLEADO AS TE ON E.IDEMPLEADO = TE.IDEMPLEADO " +
                                        "INNER JOIN DOMICILIOS_X_EMPLEADO AS DE ON E.IDEMPLEADO = DE.IDEMPLEADO " +
                                        "WHERE ACTIVO IS 1");
                accesoDB.AbrirConexion();
                accesoDB.EjecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Contacto
                    {
                        IdContacto = (int)accesoDB.Lector["IDCONTACTO"],
                        Nombre = (string)accesoDB.Lector["NOMBRE"],
                        Apellido = (string)accesoDB.Lector["APELLIDO"],
                        Dni = (int)accesoDB.Lector["DNI"],
                        Email = (string)accesoDB.Lector["EMAIL"],
                        LstTelefonos = new List<Telefono>(), // COMO LLENO ESTAS LISTAS???!!!
                        LstDomicilios = new List<Domicilio>()
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
                if (accesoDB.CheckearConexion() == true)
                {
                    accesoDB.CerrarConexion();
                }
            }
        }

        public void Agregar(Contacto nuevo)
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