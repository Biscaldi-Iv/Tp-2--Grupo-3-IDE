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
    public class PlanesService : iPlanService
    {
        private readonly string connectionString;
        public PlanesService(IOptions<DBConnection> config)
        {
            connectionString = config.Value.ConnectionString;
        }
        public async Task<IEnumerable<planes>> GetPlanes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return await db.QueryAsync<planes>("Select id_plan,desc_plan,id_especialidad,state from Planes ", 
                    commandType: CommandType.Text);
            }
            
        }
    }
}
