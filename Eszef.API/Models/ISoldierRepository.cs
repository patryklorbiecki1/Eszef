using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface ISoldierRepository
    {
        IEnumerable<Soldier> GetAllSoldiers { get; }
        Soldier GetSoldierById(int id);
        IEnumerable<Soldier> GetSoldierByLastName(string lastname);
    }
}
