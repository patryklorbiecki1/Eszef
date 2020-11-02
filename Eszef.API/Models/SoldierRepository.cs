using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class SoldierRepository : ISoldierRepository
    {
        private readonly AppDbContext _appDbContext;
        public SoldierRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Soldier> GetAllSoldiers
        {
            get
            {
                return _appDbContext.Soldier;
            }
        }

        public Soldier GetSoldierById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Soldier> GetSoldierByLastName(string lastname)
        {
            throw new NotImplementedException();
        }
    }
}
