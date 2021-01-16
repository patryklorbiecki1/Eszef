using Eszef.API.DTO;
using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface ISoldierService
    {
        Task<IEnumerable<SoldierDTO>> GetAllSoldiers();
        Task<IEnumerable<SoldierDTO>> GetSoldierByLastName(string lastname);
        Task CreateSoldier(Soldier soldier);
        Task DeleteById(string id);
        Task UpdateSoldier(Soldier soldier);
    }
}
