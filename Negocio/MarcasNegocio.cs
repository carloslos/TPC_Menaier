using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {

        public List<Marca> Listar()
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
                    aux = new Marca
                    {
                        IdMarca = (int)accesoDB.Lector["IDMARCA"],
                        Descripcion = (string)accesoDB.Lector["DESCRIPCION"]
                    };

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

        public void Agregar(Marca nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO MARCAS(DESCRIPCION) VALUES (@DESCRIPCION)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESCRIPCION", nuevo.Descripcion);

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