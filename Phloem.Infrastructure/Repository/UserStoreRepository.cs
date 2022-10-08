using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Phloem.Core.Domain;
using Phloem.Core.Helpers;
using Phloem.Core.Interfaces.Repository;
using Phloem.Infrastructure.Context;

namespace Phloem.Infrastructure.Repository
{
    public class UserStoreRepository: IUserStoreRepository
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserStoreRepository(DapperContext dapperContext, IMapper mapper, IPasswordHasher<User> passwordHasher)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<Response<string>> CreateUser(User user)
        {
            var query = $"SELECT * FROM Users WHERE UserID = {user.Id}";

            throw new NotImplementedException();
        }

        public Task<Response<User>> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<string>> ResetPassword(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Response<string>> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
