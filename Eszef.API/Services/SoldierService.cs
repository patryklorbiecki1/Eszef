using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class SoldierService : ISoldierService
    {
        private readonly ISoldierRepository _soldierRepository;
        public SoldierService(ISoldierRepository soldierRepository)
        {
            _soldierRepository = soldierRepository;
        }
        public async Task CreateSoldier(Soldier soldier)
        {
           await _soldierRepository.Create(soldier);
        }

        public async Task DeleteById(string id)
        {
            await _soldierRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Soldier>> GetAllSoldiers()
        {
            return await _soldierRepository.GetAll();
        }

        public async Task<IEnumerable<Soldier>> GetSoldierByLastName(string lastname)
        {
            return await _soldierRepository.GetSoldier(lastname);
        }

        public async Task UpdateSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }
    }
}
