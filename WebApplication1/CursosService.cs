using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace UI.Web
{
    public class CursosService : ICursosService
    {
        private readonly string connectionString;
        public CursosService(IOptions<DBConnection> config)
        {
            connectionString = config.Value.ConnectionString;
        }

        public async Task<IEnumerable<cursos>> GetCursos()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return await db.QueryAsync<cursos>("Select id_curso,id_materia, id_comision,anio_calendario,cupo from Cursos ",
                    commandType: CommandType.Text);
            }
        }
    }
}
