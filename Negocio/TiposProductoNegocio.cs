using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TiposProductoNegocio
    {
        public List<TipoProducto> Listar()
        {
            TipoProducto aux;
            List<TipoProducto> lstTiposProducto = new List<TipoProducto>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT IDTIPOPRODUCTO, DESCRIPCION FROM TIPOSPRODUCTO");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new TipoProducto
                    {
                        IdTipoProducto = (int)accesoDB.Lector["IDTIPOPRODUCTO"],
                        Descripcion = (string)accesoDB.Lector["DESCRIPCION"]
                    };

                    lstTiposProducto.Add(aux);
                }

                return lstTiposProducto;

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

        public void Agregar(TipoProducto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO TIPOSPRODUCTO(DESCRIPCION) VALUES (@DESCRIPCION)");
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
CREATE TABLE TIPOSPRODUCTO
(
    IDTIPOPRODUCTO INT NOT NULL PRIMARY KEY,
    DESCRIPCION VARCHAR(60) NOT NULL
)
*/