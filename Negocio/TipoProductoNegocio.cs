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
        public List<TipoProducto> Listar()
        {
            TipoProducto aux;
            List<TipoProducto> lstTiposProducto = new List<TipoProducto>();
            AccesoDB conexion = null;

            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDTIPOPRODUCTO, DESCRIPCION FROM TIPOSPRODUCTO WHERE ACTIVO = 1 ORDER BY DESCRIPCION ASC");
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new TipoProducto
                    {
                        IdTipoProducto = (int)conexion.Lector["IDTIPOPRODUCTO"],
                        Descripcion = (string)conexion.Lector["DESCRIPCION"]
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
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Agregar(TipoProducto nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO TIPOSPRODUCTO(DESCRIPCION, ACTIVO) VALUES (@descripcion, 1)");
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
                if (conexion.CheckearConexion() == true)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        public void Modificar(TipoProducto tp)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE TIPOSPRODUCTO SET DESCRIPCION = @descripcion WHERE IDTIPOPRODUCTO = @idtipoproducto");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", tp.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", tp.IdTipoProducto);

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
CREATE TABLE TIPOSPRODUCTO
(
    IDTIPOPRODUCTO INT NOT NULL PRIMARY KEY,
    DESCRIPCION VARCHAR(60) NOT NULL
)
*/