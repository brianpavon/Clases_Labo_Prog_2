using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHilos
{
    static class ManejadorSql
    {
        //no se crean un objeto, se inicializa una sola vez
        static SqlConnection miConexion;
        static SqlDataReader reader;

        static ManejadorSql()
        {
            miConexion = new SqlConnection();
        }

        public static DataTable EjecutarConsulta(string consulta, List<SqlParameter> parametros)
        {
            DataTable miTablita = new DataTable();
            try
            {
                SqlDataReader leer;
                SqlCommand miComando = new SqlCommand();
               
                miComando.Connection = miConexion;
                miComando.CommandText = consulta;

                if(parametros != null)
                {
                    foreach (SqlParameter item in parametros)
                    {
                        miComando.Parameters.Add(item);
                    }

                }                

                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }
                leer = miComando.ExecuteReader();
                miTablita.Load(leer);
            }
            catch(Exception ex)
            {
                //ex.Message;
            }
            finally
            {
                if(miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }
            return miTablita;

        }


    }
}
