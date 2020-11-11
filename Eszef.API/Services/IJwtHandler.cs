using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface IJwtHandler
    {
        Task<string> GenerateToken(User user);
    }
}
