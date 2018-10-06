using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class TipoProductoNegocio
    {
        public List<TipoProducto> listar()
        {
            TipoProducto aux;
            List<TipoProducto> lstTiposProducto = new List<TipoProducto>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT IDTIPO, DESCRIPCION FROM TIPOSPRODUCTO");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    aux = new TipoProducto();
                    aux.idTipo = (int)accesoDB.Lector["IDTIPO"];
                    aux.descripcion = (string)accesoDB.Lector["DESCRIPCION"];

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

        public void agregar(TipoProducto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO TIPOSPRODUCTO(DESCRIPCION) VALUES (@DESCRIPCION)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@DESCRIPCION", nuevo.descripcion);

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
    IDTIPO INT NOT NULL PRIMARY KEY,
    DESCRIPCION VARCHAR(60) NOT NULL
)
*/