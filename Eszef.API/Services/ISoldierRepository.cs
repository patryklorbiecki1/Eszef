using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface ISoldierRepository
    {
        Task<IEnumerable<Soldier>> GetAllSoldiers();
        Task<IEnumerable<Soldier>> GetSoldierByLastName(string lastname);
    }
}
