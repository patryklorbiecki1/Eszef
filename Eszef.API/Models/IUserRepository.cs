using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByEmail(String email);
  
    }
}
