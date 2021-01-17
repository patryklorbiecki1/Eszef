using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface IRoomService
    {
        Task<Room> GetRoom(int id);
    }
}
