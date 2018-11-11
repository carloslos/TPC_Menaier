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
                conexion.SetearConsulta("SELECT L.IDLOTE, L.IDCOMPRA, L.IDPRODUCTO, P.DESCRIPCION, L.UNIDADESP, L.UNIDADESE, L.COSTOPU FROM LOTES AS L " +
                    "INNER JOIN PRODUCTOS AS P ON P.IDPRODUCTO = L.IDPRODUCTO " +
                    "WHERE L.IDCOMPRA = @idcompra " +
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
                        IdCompra = (int)conexion.Lector["IDCOMPRA"],
                        Producto = new Producto(),
                        UnidadesP = (int)conexion.Lector["UNIDADESP"],
                        UnidadesE = (int)conexion.Lector["UNIDADESE"],
                        CostoPU = (float)Convert.ToDouble(conexion.Lector["COSTOPU"]),
                    };
                    aux.CostoT = aux.CostoPU * aux.UnidadesP;
                    aux.Producto.IdProducto = (int)conexion.Lector["IDPRODUCTO"];
                    aux.Producto.Descripcion = (string)conexion.Lector[3];

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
                conexion.SetearConsulta("INSERT INTO LOTES(IDCOMPRA,IDPRODUCTO,UNIDADESP,UNIDADESE,COSTOPU,ACTIVO) VALUES (@idcompra,@idproducto,@unidadesp,@unidadesp,@costopu,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcompra", nuevo.IdCompra);
                conexion.Comando.Parameters.AddWithValue("@idproducto", nuevo.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@unidadesp", nuevo.UnidadesP);
                conexion.Comando.Parameters.AddWithValue("@costopu", nuevo.CostoPU);

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

        public void Modificar(Lote l)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE LOTES SET IDPRODUCTO = @idproducto, UNIDADESP = @unidadesp, UNIDADESE = @unidadese, COSTOPU = @costopu WHERE IDLOTE = @idlote");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idproducto", l.Producto.IdProducto);
                conexion.Comando.Parameters.AddWithValue("@unidadesp", l.UnidadesP);
                conexion.Comando.Parameters.AddWithValue("@unidadese", l.UnidadesE);
                conexion.Comando.Parameters.AddWithValue("@costopu", l.CostoPU);
                conexion.Comando.Parameters.AddWithValue("@idlote", l.IdLote);

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


        public void EliminarLotesDeCompra(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM LOTES WHERE IDCOMPRA = @id");
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

        public void EliminarFisico(long id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM LOTES WHERE IDLOTE = @id");
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

        public void EliminarLogico(long id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE LOTES SET ACTIVO = 0 WHERE IDLOTE = @id");
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
