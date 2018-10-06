using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            Marca aux;
            List<Marca> lstMarcas = new List<Marca>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT IDMARCA, DESCRIPCION FROM MARCAS");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new Marca();
                    aux.idMarca = (int)accesoDB.Lector["IDMARCA"];
                    aux.descripcion = (string)accesoDB.Lector["DESCRIPCION"];

                    lstMarcas.Add(aux);
                }

                return lstMarcas;

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

        public void agregar(Marca nuevo)
        {
            AccesoDB conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDB();
                consulta = "INSERT INTO MARCAS (DESCRIPCION) VALUES (" + nuevo.descripcion + ")";
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
CREATE TABLE MARCAS
(
	IDMARCA INT NOT NULL PRIMARY KEY,
	DESCRIPCION VARCHAR(60) NOT NULL
)
*/