using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        
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

        public int GetIDByMail(string mail)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_persona] FROM [Academia].[dbo].[personas] " +
                "WHERE [email]=\'"+mail+"\'");
            reader.Read();
            int i = reader.GetInt32(0);
            reader.Close();
            this.CloseConnection();

            return i;
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

        public void AddNew(Persona pers)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_add_persona", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", pers.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pers.Apellido);
                cmd.Parameters.AddWithValue("@direccion", pers.Direccion);
                cmd.Parameters.AddWithValue("@email", pers.Email);
                cmd.Parameters.AddWithValue("@telefono", pers.Telefono);
                cmd.Parameters.AddWithValue("@f_nac", pers.FechaNacimiento);
                cmd.Parameters.AddWithValue("@legajo", pers.Legajo);
                cmd.Parameters.AddWithValue("@tipo_persona", pers.TipoPersona);
                cmd.Parameters.AddWithValue("@id_plan", pers.IDPlan);
                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionNOManejada = new Exception("Error al crear el curso", Ex);
                throw ExcepcionNOManejada;
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

