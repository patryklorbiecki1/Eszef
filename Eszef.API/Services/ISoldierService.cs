using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface ISoldierService
    {
        Task<IEnumerable<Soldier>> GetAllSoldiers();
        Task<IEnumerable<Soldier>> GetSoldierByLastName(string lastname);
        Task CreateSoldier(Soldier soldier);
        Task DeleteById(string id);
        Task UpdateSoldier(Soldier soldier);
    }
}
