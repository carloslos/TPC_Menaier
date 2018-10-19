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

        public SqlCommand Comando
        {
            get { return comando; }
        }

        public AccesoDB()
        { 
            conexion = new SqlConnection (@"data source=.\SQLEXPRESS; initial catalog= MENAIER_DB;  integrated security=sspi");
        }

        public void SetearConsulta(string consulta)
        {
            comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = consulta
            };
        }

        public void SetearSP(string sp)
        {
            comando = new SqlCommand
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = sp
            };
        }

        public void AbrirConexion()
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

        public bool CheckearConexion()
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

        public void CerrarConexion()
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

        public void EjecutarAccion()
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

        public void EjecutarConsulta()
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

        public void SetearFecha()
        {

        }

    }
}
