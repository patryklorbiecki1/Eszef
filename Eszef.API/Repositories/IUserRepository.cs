using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUser(string email,string password);
        Task CreateUser(User user);
    }
}
