using AutoMapper;
using Eszef.API.DTO;
using Eszef.API.Models;
using Eszef.API.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Eszef.API.Services
{
    public class SoldierService : ISoldierService
    {
        private readonly ISoldierRepository _soldierRepository;
        private readonly IMapper _mapper;
        public SoldierService(ISoldierRepository soldierRepository, IMapper mapper)
        {
            _soldierRepository = soldierRepository;
            _mapper = mapper;
        }
        public async Task CreateSoldier(Soldier soldier)
        {
           await _soldierRepository.Create(soldier);
        }

        public async Task DeleteById(string id)
        {
            await _soldierRepository.DeleteById(id);
        }

        public async Task<IEnumerable<SoldierDTO>> GetAllSoldiers()
        {
            var soldiers =  await _soldierRepository.GetAll();
            return _mapper.Map<IEnumerable<Soldier>, IEnumerable<SoldierDTO>>(soldiers);
        }

        public async Task<IEnumerable<SoldierDTO>> GetSoldierByLastName(string lastname)
        {
            var soldiers = await _soldierRepository.GetSoldier(lastname);
            return _mapper.Map<IEnumerable<Soldier>, IEnumerable<SoldierDTO>>(soldiers);
        }

        public async Task UpdateSoldier(Soldier soldier)
        {
             throw new NotImplementedException();
        }

        public async Task<IEnumerable<SoldierDTO>> GetSoldiersByRoom(int id)
        {
            var soldiers = await _soldierRepository.GetAll();
            soldiers = soldiers.Where(x => x.IdRoom == id);
            return _mapper.Map<IEnumerable<Soldier>, IEnumerable<SoldierDTO>>(soldiers);
        }

  
    }
}
