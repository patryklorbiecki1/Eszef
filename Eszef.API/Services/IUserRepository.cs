using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface IUserRepository
    {
        Task<User> GetUser(string email);
        Task Register(string email, string password);
        Task<User> Login(string email, string password);
    }
}
