using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface ISoldierRepository
    {
        Task<IEnumerable<Soldier>> GetAll();
        Task<IEnumerable<Soldier>> GetSoldier(string lastname);
        Task Create(Soldier soldier);
        Task DeleteById(string id);
        Task Update(Soldier soldier);

    }
}
