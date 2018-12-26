using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace SuperMercadoDAO.Repository
{
    public class UsuarioRepository
    {
        private string connectionString;

        public UsuarioRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("BaseSuperMercado");
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public void Add(string item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO customer (name,phone,email,address) VALUES(@Name,@Phone,@Email,@Address)", item);
            }

        }

    }
}
