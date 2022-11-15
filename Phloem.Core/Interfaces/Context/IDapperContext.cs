using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Interfaces.Context
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
        Task<T> GetItem<T>(string Query, object? Parms);
        Task<IEnumerable<T>> GetItems<T>(string Query, object? Parms);
        
    }
}
