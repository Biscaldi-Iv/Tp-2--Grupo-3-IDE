using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    class PersonaAdapter : Adapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Persona> _Personas;

        private static List<Persona> Personas
        {
            get
            {
                if (_Personas == null)
                {
                    _Personas = new List<Business.Entities.Persona>();
                    Business.Entities.Persona per;
                    per = new Business.Entities.Persona();
                    per.ID = 1;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Casimiro";
                    per.Apellido = "Cegado";
                    per.Email = "casimirocegado@gmail.com";
                    per.Direccion = "av.Pellegrini 1000";
                    per.IDPlan = 1;
                    per.FechaNacimiento = new DateTime(1990 / 06 / 20);
                    per.Telefono ="10000";
                    per.Legajo = 10;

                    _Personas.Add(per);

                    per = new Business.Entities.Persona();
                    per.ID = 2;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Armando Esteban";
                    per.Apellido = "Quito";
                    per.FechaNacimiento = new DateTime(2000, 03, 15);
                    per.Telefono = "20000";
                    per.Email = "armandoquito@gmail.com";
                    per.Legajo = 20;
                    per.IDPlan = 1;
                    _Personas.Add(per);

                    per = new Business.Entities.Persona();
                    per.ID = 3;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Alan";
                    per.Apellido = "Brado";
                    per.Telefono = "30000";
                    per.IDPlan = 2;
                    per.Email = "alanbrado@gmail.com";
                    per.Legajo = 30;
                    _Personas.Add(per);

                }
                return _Personas;
            }
        }
        #endregion

        public PersonaAdapter() : base() { }

        public List<Persona> GetAll()
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT TOP (1000) [id_persona],[nombre],[apellido],[direccion]," +
                "[email],[telefono],[fecha_nac],[legajo],[tipo_persona],[id_plan] " +
                "FROM[Academia].[dbo].[personas]");
            List<Persona> pers = new List<Persona>();
            while (reader.Read())
            {
                Persona per = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6), reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetInt32(9));
                pers.Add(per);
            }
            reader.Close();
            this.CloseConnection();
            return pers;
        }

        public Business.Entities.Persona GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT TOP (1000) [id_persona],[nombre],[apellido],[direccion]," +
                "[email],[telefono],[fecha_nac],[legajo],[tipo_persona],[id_plan] " +
                "FROM[Academia].[dbo].[personas]" +
                $"WHERE [id_persona]={ID}");
            reader.Read();
            Persona p = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6), reader.GetInt32(7), reader.GetInt32(8),
                    reader.GetInt32(9));
            reader.Close();
            this.CloseConnection();

            return p;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE personas FROM " +
                    "personas" +
                    "WHERE id_persona=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;

                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e.InnerException;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void SaveChanges(Persona person)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE personas SET " +
                    "nombre=@nom," +
                    "apellido=@ape," +
                    "direccion=@direc," +
                    "email=@email," +
                    "telefono=@tel," +
                    "fecha_nac=@fec, " +
                    "legajo=@leg," +
                    "tipo_persona=@tper, " +
                    "id_plan=@idplan" +
                    "WHERE id_persona=@id", sqlConnection);
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = person.ID;
                cmdSave.Parameters.Add("@nom", System.Data.SqlDbType.VarChar, 50).Value = person.Nombre;
                cmdSave.Parameters.Add("@ape", System.Data.SqlDbType.VarChar, 50).Value = person.Apellido;
                cmdSave.Parameters.Add("@dir", System.Data.SqlDbType.VarChar, 50).Value = person.Direccion;
                cmdSave.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50).Value = person.Email;
                cmdSave.Parameters.Add("@ape", System.Data.SqlDbType.VarChar, 50).Value = person.Apellido;
                cmdSave.Parameters.Add("@tel", System.Data.SqlDbType.VarChar, 50).Value = person.Telefono;
                cmdSave.Parameters.Add("@fec", System.Data.SqlDbType.DateTime).Value = person.FechaNacimiento;
                cmdSave.Parameters.Add("@leg", System.Data.SqlDbType.Int).Value = person.Legajo;
                cmdSave.Parameters.Add("@tper", System.Data.SqlDbType.Int).Value = person.TipoPersona;
                cmdSave.Parameters.Add("@idplan", System.Data.SqlDbType.Int).Value = person.IDPlan;
                this.OpenConnection();
                cmdSave.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e.InnerException;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }

       /* public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Persona per in _Personas)
                {
                    if (per.ID > NextID)
                    {
                        NextID = per.ID;
                    }
                }
                persona.ID = NextID + 1;
                Persona.Add(persona);
            }
            else if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Persona[persona.FindIndex(delegate (Persona p) { return p.ID == ; })] = persona;
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
    }*/
}

