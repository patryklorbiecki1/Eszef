using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface IUserService
    {
        Task Register(string email, string password);
        Task<User> Login(string email, string password);
    }
}
