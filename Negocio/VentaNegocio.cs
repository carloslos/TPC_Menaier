using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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
                conexion.SetearConsulta("SELECT V.IDVENTA, E.NOMBRE, E.APELLIDO, V.IDEMPLEADO, C.NOMBRE, C.APELLIDO, C.EMPRESA, V.IDCLIENTE, V.FECHAVENTA, V.FECHAREGISTRO FROM VENTAS AS V " +
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
                        FechaRegistro = (DateTime)conexion.Lector[9],
                        FechaVenta = (DateTime)conexion.Lector[8]
                    };
                    aux.Empleado.Nombre = (string)conexion.Lector[1];
                    aux.Empleado.Apellido = (string)conexion.Lector[2];
                    aux.Empleado.IdEmpleado = (int)conexion.Lector[3];
                    aux.Empleado.IdContacto = aux.Empleado.IdEmpleado;
                    if (conexion.Lector.IsDBNull(4))
                    {
                        ClienteE auxC = new ClienteE
                        {
                            Empresa = (string)conexion.Lector[6]
                        };
                        aux.Cliente = auxC;
                    }
                    else
                    {
                        ClienteP auxC = new ClienteP();
                        auxC.Datos.Nombre = (string)conexion.Lector[4];
                        auxC.Datos.Apellido = (string)conexion.Lector[5];
                        aux.Cliente = auxC;
                    }
                    aux.Cliente.IdCliente = (int)conexion.Lector[7];

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

        public void Agregar(Venta nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.SetearConsulta("INSERT INTO VENTAS(IDCLIENTE,IDEMPLEADO,FECHAVENTA,FECHAREGISTRO,ACTIVO) VALUES (@idcliente,@dempleado,@fechaventa,@fecharegistro,1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idcliente", nuevo.Cliente.IdCliente);
                conexion.Comando.Parameters.AddWithValue("@idempleado", nuevo.Empleado.IdEmpleado);
                conexion.Comando.Parameters.AddWithValue("@fechaventa", nuevo.FechaVenta);
                conexion.Comando.Parameters.AddWithValue("@fecharegistro", nuevo.FechaRegistro);

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
