using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class LoteNegocio
    {
        public List<Lote> Listar(int Id)
        {
            Lote aux;
            List<Lote> lstLotes = new List<Lote>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT L.IDLOTE, L.IDPRODUCTO, P.DESCRIPCION, L.UNIDADES, L.COSTOPU, L.VENCIMIENTO FROM LOTES AS L " +
                    "INNER JOIN LOTES_X_COMPRA AS LXC ON LXC.IDLOTE = L.IDLOTE " +
                    "INNER JOIN PRODUCTOS AS P ON P.IDPRODUCTO = L.IDPRODUCTO " +
                    "WHERE LXC.IDCOMPRA = @idcompra " +
                    "ORDER BY P.DESCRIPCION ASC");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcompra", Id);

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Lote
                    {
                        IdLote = (long)conexion.Lector["IDLOTE"],
                        Producto = new Producto(),
                        Unidades = (int)conexion.Lector["UNIDADES"],
                        CostoPU = (float)Convert.ToDouble(conexion.Lector["COSTOPU"]),
                        Vencimiento = (DateTime)conexion.Lector["VENCIMIENTO"]
                    };
                    aux.CostoT = aux.CostoPU * aux.Unidades;
                    aux.Producto.IdProducto = (int)conexion.Lector["IDPRODUCTO"];
                    aux.Producto.Descripcion = (string)conexion.Lector[2];

                    lstLotes.Add(aux);
                }
                return lstLotes;
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

        public void Agregar(Lote nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO LOTES(IDLOTE, IDPRODUCTO,UNIDADES,COSTOPU,VENCIMIENTO) VALUES (@idlote,@idproducto,@unidades,@costopu,@vencimiento,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idlote", nuevo.IdLote);
                conexion.Comando.Parameters.AddWithValue("@idproducto", nuevo.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@unidades", nuevo.Unidades);
                conexion.Comando.Parameters.AddWithValue("@costopu", nuevo.CostoPU);
                conexion.Comando.Parameters.AddWithValue("@vencimiento", nuevo.Vencimiento);

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

        public void Modificar(Producto p)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE PRODUCTOS SET IDMARCA = @idmarca, IDTIPOPRODUCTO = @idtipoproducto, DESCRIPCION = @descripcion, STOCKMIN = @stockmin, GANANCIA = @ganancia WHERE IDPRODUCTO = @idproducto");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idmarca", p.Marca.IdMarca);
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto", p.TipoProducto.IdTipoProducto);
                conexion.Comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@stockmin", p.StockMin);
                conexion.Comando.Parameters.AddWithValue("@ganancia", p.Ganancia);
                conexion.Comando.Parameters.AddWithValue("@idproducto", p.IdProducto);

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
                conexion.SetearConsulta("DELETE FROM PRODUCTOS WHERE IDPRODUCTO = @id");
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
                conexion.SetearConsulta("UPDATE PRODUCTOS SET ACTIVO = 0 WHERE IDPRODUCTO = @id");
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
CREATE TABLE LOTES
(
	IDLOTE BIGINT IDENTITY(140000000,1) NOT NULL PRIMARY KEY,
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	UNIDADES INT NOT NULL,
	COSTOPU FLOAT NOT NULL,
	VENCIMIENTO DATE,
	ACTIVO BIT NOT NULL
)
*/
