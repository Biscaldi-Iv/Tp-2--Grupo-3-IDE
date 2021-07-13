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
        public Adapter()
        {
            sqlConnection=new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Academia;Integrated Security=True");
        }
        protected SqlConnection sqlConnection;
        protected SqlDataAdapter _data_Adapter;

        protected SqlDataAdapter SqlDataAdapter
        {
            get => this._data_Adapter;
            set
            {
                this._data_Adapter = value;
            }
        }
        
        protected void OpenConnection() //abre conexion
        {
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
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
                throw new Exception(e.Message);
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
