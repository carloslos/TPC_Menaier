using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> Listar()
        {
            Venta aux;
            List<Venta> lstVentas = new List<Venta>();
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("SELECT V.IDVENTA, E.NOMBRE, E.APELLIDO, V.IDEMPLEADO, C.NOMBRE, C.APELLIDO, V.IDCLIENTE, V.FECHAVENTA, V.FECHAREGISTRO FROM VENTAS AS V " +
                    "INNER JOIN EMPLEADOS AS E ON V.IDEMPLEADO = E.IDEMPLEADO " +
                    "INNER JOIN CLIENTES AS C ON C.IDCLIENTE = V.IDCLIENTE " +
                    "WHERE V.ACTIVO = 1");

                conexion.AbrirConexion();
                conexion.EjecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Venta()
                    {
                        IdVenta = (int)conexion.Lector[0],
                        Empleado = new Empleado(),
                        FechaRegistro = (DateTime)conexion.Lector[8],
                        FechaVenta = (DateTime)conexion.Lector[7]
                    };
                    aux.Empleado.Nombre = (string)conexion.Lector[1];
                    aux.Empleado.Apellido = (string)conexion.Lector[2];
                    aux.Empleado.IdEmpleado = (int)conexion.Lector[3];
                    aux.Empleado.IdContacto = aux.Empleado.IdEmpleado;
                    if (conexion.Lector.IsDBNull(5))
                    {
                        ClienteE auxC = new ClienteE
                        {
                            Nombre = (string)conexion.Lector[4]
                        };
                        aux.Cliente = auxC;
                    }
                    else
                    {
                        ClienteP auxC = new ClienteP
                        {
                            Nombre = (string)conexion.Lector[4],
                            Apellido = (string)conexion.Lector[5]
                        };
                        aux.Cliente = auxC;
                    }
                    aux.Cliente.IdCliente = (int)conexion.Lector[6];
                    //aux.Monto = (float)Math.Round(CalcularMonto(aux.IdVenta), 3);
                    aux.Monto = (float)CalcularMonto(aux.IdVenta);

                    lstVentas.Add(aux);
                }
                return lstVentas;
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

        public string Agregar(Venta nuevo)
        {
            try
            {
                //DateTime d = new DateTime();
                //CultureInfo ci = CultureInfo.InvariantCulture;
                //d = DateTime.ParseExact((nuevo.FechaVenta.Day.ToString() + "/" + nuevo.FechaVenta.Month.ToString() + "/" + nuevo.FechaVenta.Year.ToString()), "/MM/yyyy", ci);
                nuevo.FechaRegistro = DateTime.Today;
                string insertedID = "";

                string query = "INSERT INTO VENTAS(IDCLIENTE,IDEMPLEADO,FECHAVENTA,FECHAREGISTRO,ACTIVO) VALUES (@idcliente,@idempleado,@fechaventa,@fecharegistro,1); SELECT SCOPE_IDENTITY();";

                using (var dbconn = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi"))
                using (var dbcm = new SqlCommand(query, dbconn))
                {
                    dbcm.Parameters.AddWithValue("@idcliente", nuevo.Cliente.IdCliente);
                    dbcm.Parameters.AddWithValue("@idempleado", nuevo.Empleado.IdEmpleado);
                    dbcm.Parameters.AddWithValue("@fechaventa", nuevo.FechaVenta);
                    dbcm.Parameters.AddWithValue("@fecharegistro", nuevo.FechaRegistro);

                    dbconn.Open();
                    insertedID = dbcm.ExecuteScalar().ToString();
                }
                return insertedID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Venta v)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("UPDATE VENTAS SET IDCLIENTE = @idcliente, IDEMPLEADO = @idempleado, FECHAVENTA  = @fechaventa WHERE IDVENTA = @idventa");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idventa", v.IdVenta);
                conexion.Comando.Parameters.AddWithValue("@idempleado", v.Empleado.IdEmpleado);
                conexion.Comando.Parameters.AddWithValue("@idcliente", v.Cliente.IdCliente);
                conexion.Comando.Parameters.AddWithValue("@fechaventa", v.FechaVenta);

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


        public float CalcularMonto(int IdVenta)
        {
            float monto = 0;
            List<Lote> lstLotes = new List<Lote>();
            LoteNegocio negL = new LoteNegocio();
            try
            {
                lstLotes = negL.Listar(IdVenta);
                foreach(Lote l in lstLotes)
                {
                    //monto += (float)Math.Round((l.CostoPU * l.UnidadesP), 3);
                    monto += (float)(l.CostoPU * l.UnidadesP);
                }
                return monto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarFisico(int id)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("DELETE FROM VENTAS WHERE IDVENTA = @id");
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
                conexion.SetearConsulta("UPDATE VENTAS SET ACTIVO = 0 WHERE IDVENTA = @id");
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
CREATE TABLE VENTAS
(
	IDVENTA INT NOT NULL IDENTITY(80000000,1) PRIMARY KEY,
	FECHAVENTA DATE NOT NULL,
	IDEMPLEADO INT NOT NULL FOREIGN KEY REFERENCES EMPLEADOS(IDEMPLEADO),
	IDCLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(IDCLIENTE),
	FECHAREGISTRO DATETIME NOT NULL DEFAULT GETDATE()
    ACTIVO BIT NOT NULL,
)
*/
