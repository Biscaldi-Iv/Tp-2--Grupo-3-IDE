using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace Data.Database
{
    public class TipoPersonaAdapter : Adapter
    {
        public TipoPersonaAdapter():base(){}

        public TipoPersonas GetOne(int id)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_tipo_persona], [descripcion_t_p] " +
                "FROM [Academia].[dbo].[tipo_persona]" +
                $" WHERE [id_tiop_persona]={id}");
            reader.Read();
            TipoPersonas tp = new TipoPersonas(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            this.CloseConnection();

            return tp;
        }

        public TipoPersonas GetByDesc(string desc)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_tipo_persona], [descripcion_t_p] " +
                "FROM [Academia].[dbo].[tipo_persona]" +
                " WHERE [descripcion_t_p]=\'" + desc+"\'");
            reader.Read();
            TipoPersonas tp = new TipoPersonas(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            this.CloseConnection();

            return tp;
        }

        public List<TipoPersonas> GetAll()
        {
            List<TipoPersonas> tps = new List<TipoPersonas>();

            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_tipo_persona], [descripcion_t_p] " +
                "FROM [Academia].[dbo].[tipo_persona]");
            while (reader.Read()) 
            {
                TipoPersonas tp = new TipoPersonas(reader.GetInt32(0), reader.GetString(1));
                tps.Add(tp);
            }
            reader.Close();
            this.CloseConnection();

            return tps;
        }

    }
}
