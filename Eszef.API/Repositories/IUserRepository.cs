using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface IUserRepository
    {
        Task<User> GetUser(string email);
        Task CreateUser(User user);
    }
}
