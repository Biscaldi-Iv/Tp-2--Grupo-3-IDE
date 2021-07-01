using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace Data.Database
{
    public class EspecialidadAdapter: Adapter
    {
        #region bd
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Especialidad> _Especialidad;

        private List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidad == null)
                {
                    _Especialidad = this.GetAll();
                }
                return _Especialidad;
            }
        }
        #endregion

        public List<Especialidad> GetAll()
        {
            List<Especialidad> esp = new List<Especialidad>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_especialidad], [desc_especialidad] FROM [Academia].[dbo].[especialidades]");
            while(reader.Read())
            {
                Especialidad es = new Especialidad(reader.GetInt32(0), reader.GetString(1));
                esp.Add(es);
            }
            reader.Close();
            this.CloseConnection();

            return esp;
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_especialidad], [desc_especialidad] " +
                "FROM [Academia].[dbo].[especialidades]" +
                $" WHERE [id_especialidad]={ID}");
            reader.Read();
            Especialidad es = new(reader.GetInt32(0), reader.GetString(1));
            
            return es;
        }

        public void Delete(int ID)
        {
            Especialidades.Remove(this.GetOne(ID));
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Especialidad esp in Especialidades)
                {
                    if (esp.ID > NextID)
                    {
                        NextID = esp.ID;
                    }
                }
                especialidad.ID = NextID + 1;
                Especialidades.Add(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Especialidades[Especialidades.FindIndex(delegate (Especialidad e) { return e.ID == especialidad.ID; })] = especialidad;
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

        public void AddNew(Especialidad esp) 
        {
            #region pasar_a_logica
            foreach (Especialidad e in Especialidades)
            {
                if (e.Descripcion== esp.Descripcion)
                {
                    throw new Exception("Especialidad ya existente!"); // devuelve excepcion porque ya existe una especialidad con ese nombre
                }
            }
            #endregion
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into especialidades(desc_especialidad) " +
                "Values(@d_espcialidad) " +
                "selected @@identity", sqlConnection);
                cmdSave.Parameters.Add("@d_especialidad", System.Data.SqlDbType.VarChar, 50).Value = esp.Descripcion;
            }
            catch (SqlException Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
    }
}

