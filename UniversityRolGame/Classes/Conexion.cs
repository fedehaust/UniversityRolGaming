using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace UniversityRolGame.Classes
{
    public class Conexion
    {
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader dataReader;
            string cadenaConexion = "cadena";
            DataTable dataTable;

            public SqlDataReader pDataReader
            {
                set { dataReader = value; }
                get { return dataReader; }
            }
            public string pCadenaConexion
            {
                set { cadenaConexion = value; }
                get { return cadenaConexion; }
            }
            public Conexion(string strConexion)
            {

                conexion = new SqlConnection(strConexion);
                comando = new SqlCommand();
                dataReader = null;
                cadenaConexion = strConexion;
            }
            public Conexion()
            {
                conexion = new SqlConnection();
                comando = new SqlCommand();
                dataReader = null;
                cadenaConexion = "";
            }
            public void conectar()
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
            }
            public void desconectar()
            {
                conexion.Close();
                conexion.Dispose();
            }
            public DataTable consultarTabla(string tabla)
            {
                conectar();
                comando.CommandText = "SELECT * FROM " + tabla;
                dataTable.Load(comando.ExecuteReader());
                desconectar();
                return dataTable;
            }
            public DataTable consultar(string sql)
            {
                conectar();
                comando.CommandText = sql;
                dataTable.Load(comando.ExecuteReader());
                desconectar();
                return dataTable;
            }
            public void leerTabla(string tabla)
            {
                conectar();
                comando.CommandText = "SELECT * FROM " + tabla;
                dataReader = comando.ExecuteReader();
            }
            public void actualizar(string sql)
            {
                conectar();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                desconectar();
            }
        }
    }
