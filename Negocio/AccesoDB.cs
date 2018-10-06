using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class AccesoDB
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDB ()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi";
        }

        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = consulta
            };
        }

        //esto para luego...
        public void setearSP(string sp)
        {
            comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = sp
            };
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkearConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Open) { return false; }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
