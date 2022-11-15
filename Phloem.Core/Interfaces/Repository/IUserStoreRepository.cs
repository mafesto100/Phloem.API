using Phloem.Core.Domain;
using Phloem.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Interfaces.Repository
{
    public interface IUserStoreRepository
    {
        public Task<User> GetUser(int id);
        public Task<Response<string>> CreateUser(User user);
        public Task<Response<string>> UpdateUser(User user);
        public Task<Response<string>> ResetPassword(User user);

    }
}
