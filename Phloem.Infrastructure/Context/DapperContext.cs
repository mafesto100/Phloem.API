using Microsoft.Extensions.Configuration;
using Phloem.Core.Domain;
using Phloem.Core.Interfaces.Context;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Infrastructure.Context
{
    public class DapperContext: IDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        public async Task<T> GetItem<T>(string Query, object? Parms = null)
        {
            using (IDbConnection db = CreateConnection())
            {
                T value = await db.QuerySingleAsync<T>(Query, Parms);

                return value;
            }
        }

        public async Task<IEnumerable<T>> GetItems<T>(string Query, object? Parms = null)
        {
            using (IDbConnection db = CreateConnection())
            {
                IEnumerable<T> values = await db.QueryAsync<T>(Query, Parms);

                return values;
            }
        }
    }
}
