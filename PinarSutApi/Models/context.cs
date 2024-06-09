using Microsoft.Data.SqlClient;
using System.Data;

namespace PinarSutApi.Models
{
    public class context
    {
        private readonly string _connectionString;

        public context(IConfiguration configuration)
        {

            _connectionString = configuration.GetConnectionString("connection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}