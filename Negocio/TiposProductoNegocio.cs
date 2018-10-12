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
                accesoDB.SetearConsulta("SELECT IDTIPOPRODUCTO, DESCRIPCION FROM TIPOSPRODUCTO WHERE ACTIVO = 1");
                accesoDB.AbrirConexion();
                accesoDB.EjecutarConsulta();

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
                if (accesoDB.CheckearConexion() == true)
                {
                    accesoDB.CerrarConexion();
                }
            }
        }

        public void Agregar(TipoProducto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO TIPOSPRODUCTO(DESCRIPCION) VALUES (@descripcion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);

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

        public void Modificar(TipoProducto tp)
        {
            AccesoDB conexion;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE TIPOSPRODUCTOS SET DESCRIPCION = @descripcion WHERE IDTIPOPRODUCTO = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", tp.Descripcion);

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
                conexion.SetearConsulta("DELETE FROM TIPOSPRODUCTO WHERE IDTIPOPRODUCTO = @id");
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
                conexion.SetearConsulta("UPDATE TIPOSPRODUCTO SET ACTIVO = 0 WHERE IDTIPOPRODUCTO = @id");
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
CREATE TABLE TIPOSPRODUCTO
(
    IDTIPOPRODUCTO INT NOT NULL PRIMARY KEY,
    DESCRIPCION VARCHAR(60) NOT NULL
)
*/