using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Business.Entities;
using Microsoft.Data.SqlClient;


namespace Data.Database
{
    public class Adapter
    {
        protected SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Academia;Integrated Security=True");
        
        protected void OpenConnection() //abre conexion
        {
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        protected void CloseConnection() //cierra conexion
        {
            try
            {
                sqlConnection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        protected SqlDataReader ExecuteReader(String commandText) //Ejecuta sentencias SQL
        {
            SqlCommand comando = new SqlCommand(commandText, sqlConnection);
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }

    }
}
