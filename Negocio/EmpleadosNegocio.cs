﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EmpleadosNegocio
    {

        public List<Empleado> Listar()
        {
            Empleado aux;
            List<Empleado> lstEmpleados = new List<Empleado>();
            AccesoDB accesoDB = new AccesoDB();

            try
            {
                accesoDB.setearConsulta("SELECT NOMBRE, APELLIDO, IDEMPLEADO, DNI, FECHANAC, TIPOPERFIL, EMAIL FROM EMPLEADOS");
                accesoDB.abrirConexion();
                accesoDB.ejecutarConsulta();

                while (accesoDB.Lector.Read())
                {
                    string str = (string)accesoDB.Lector["TIPOPERFIL"];
                    aux = new Empleado
                    {
                        Nombre = (string)accesoDB.Lector["NOMBRE"],
                        Apellido = (string)accesoDB.Lector["APELLIDO"],
                        IdEmpleado = (int)accesoDB.Lector["IDEMPLEADO"],
                        Dni = (int)accesoDB.Lector["DNI"],
                        FechaNac = (DateTime)accesoDB.Lector["FECHANAC"],
                        TipoPerfil = str[0],
                        Email = (string)accesoDB.Lector["EMAIL"]
                    };

                    lstEmpleados.Add(aux);
                }

                return lstEmpleados;

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

        public void Agregar(Empleado nuevo)
        {
            AccesoDB conexion = null;
            try
            {
                conexion = new AccesoDB();
                conexion.setearConsulta("INSERT INTO EMPLEADOS(NOMBRE, APELLIDO, DNI, FECHANAC, USUARIO, CONTRASENIA, TIPOPERFIL, EMAIL) VALUES (@NOMBRE, @APELLIDO, @DNI, @FECHANAC, @USUARIO, @CONTRASENIA, @TIPOPERFIL, @EMAIL)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@APELLIDO", nuevo.Apellido);
                conexion.Comando.Parameters.AddWithValue("@DNI", nuevo.Dni);
                conexion.Comando.Parameters.AddWithValue("@FECHANAC", nuevo.FechaNac);
                conexion.Comando.Parameters.AddWithValue("@USUARIO", nuevo.Usuario);
                conexion.Comando.Parameters.AddWithValue("@CONTRASENIA", nuevo.Contrasenia);
                conexion.Comando.Parameters.AddWithValue("@TIPOPERFIL", nuevo.TipoPerfil);
                conexion.Comando.Parameters.AddWithValue("@EMAIL", nuevo.Email);

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
CREATE TABLE EMPLEADOS
(
    NOMBRE VARCHAR(60) NOT NULL,
    APELLIDO VARCHAR(60) NOT NULL,
    DNI INT NOT NULL,
	IDEMPLEADO INT NOT NULL PRIMARY KEY,
    FECHANAC DATE,
	USUARIO VARCHAR(60) NOT NULL,
    CONTRASENIA VARCHAR(60) NOT NULL,
    TIPOPERFIL CHAR NOT NULL,
	EMAIL VARCHAR(60) NOT NULL
)
*/