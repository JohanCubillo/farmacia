using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Sistema_de_Farmacia.Modelo
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            //Cadena
            //CArlos
            string strConn = @"Data Source=LAPTOP-16D0D786\SQLEXPRESS;Initial Catalog=System_Farmacia;Integrated Security=True";


            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }

            return conn;

        }
    }
}
