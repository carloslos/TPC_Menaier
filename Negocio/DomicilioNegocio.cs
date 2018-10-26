using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DomicilioNegocio
    {
        public List<Domicilio> Listar(int IdRelacion)
        {
            Domicilio aux;
            List<Domicilio> lstDomicilios = new List<Domicilio>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT IDDOMICILIO, CALLE, ALTURA, DEPARTAMENTO, BARRIO, CIUDAD, PAIS, CP FROM DOMICILIOS WHERE IDRELACION = @idrelacion AND ACTIVO = 1");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idrelacion", IdRelacion);
                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Domicilio
                    {
                        IdDomicilio = (int)conexion.Lector["IDDOMICILIO"],
                        IdRelacion = IdRelacion,
                        Calle = (string)conexion.Lector["Calle"],
                        Altura = (int)conexion.Lector["Altura"],
                        Departamento = (string)conexion.Lector["DEPARTAMENTO"],
                        Barrio = (string)conexion.Lector["BARRIO"],
                        Ciudad = (string)conexion.Lector["CIUDAD"],
                        Pais = (string)conexion.Lector["PAIS"],
                        Cp = (int)conexion.Lector["CP"]
                    };

                    lstDomicilios.Add(aux);
                }
                return lstDomicilios;
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

        public void Agregar(Domicilio nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO DOMICILIOS([IDRELACION],[CALLE],[ALTURA],[DEPARTAMENTO],[BARRIO],[CIUDAD],[PAIS],[CP],[ACTIVO]) VALUES (@idrelacion,@calle,@altura,@departamento,@barrio,@ciudad,@pais,@cp,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idrelacion", nuevo.IdRelacion);
                conexion.Comando.Parameters.AddWithValue("@calle", nuevo.Calle);
                conexion.Comando.Parameters.AddWithValue("@altura", nuevo.Altura);
                conexion.Comando.Parameters.AddWithValue("@departamento", nuevo.Departamento);
                conexion.Comando.Parameters.AddWithValue("@barrio", nuevo.Barrio);
                conexion.Comando.Parameters.AddWithValue("@ciudad", nuevo.Ciudad);
                conexion.Comando.Parameters.AddWithValue("@pais", nuevo.Pais);
                conexion.Comando.Parameters.AddWithValue("@cp", nuevo.Cp);

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

        public void Modificar(Domicilio d)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE DOMICILIOS SET CALLE = @calle, ALTURA = @altura, DEPARTAMENTO = @departamento, BARRIO = @barrio, CIUDAD = @ciudad, PAIS = @pais, CP = @cp WHERE IDPRODUCTO = @iddomicilio");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@iddomicilio", d.IdDomicilio);
                conexion.Comando.Parameters.AddWithValue("@calle", d.Calle);
                conexion.Comando.Parameters.AddWithValue("@altura", d.Altura);
                conexion.Comando.Parameters.AddWithValue("@departamento", d.Departamento);
                conexion.Comando.Parameters.AddWithValue("@barrio", d.Barrio);
                conexion.Comando.Parameters.AddWithValue("@ciudad", d.Ciudad);
                conexion.Comando.Parameters.AddWithValue("@pais", d.Pais);
                conexion.Comando.Parameters.AddWithValue("@cp", d.Cp);

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
                conexion.SetearConsulta("DELETE FROM DOMICILIOS WHERE IDDOMICILIO = @id");
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
                conexion.SetearConsulta("UPDATE DOMICILIOS SET ACTIVO = 0 WHERE IDDOMICILIO = @id");
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
CREATE TABLE DOMICILIOS
(
	IDDOMICILIO INT NOT NULL IDENTITY(110000000,1) PRIMARY KEY,
	IDRELACION INT NOT NULL,
	CALLE VARCHAR(60) NOT NULL,
	ALTURA INT NOT NULL,
	DEPARTAMENTO VARCHAR(10),
	BARRIO VARCHAR(60) NOT NULL,
	CIUDAD VARCHAR(60) NOT NULL,
	PAIS VARCHAR(60)
)
*/