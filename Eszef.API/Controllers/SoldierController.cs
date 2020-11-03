using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eszef.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eszef.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoldierController : ControllerBase
    {
        private readonly ISoldierRepository _soldierRepository;

        public SoldierController(ISoldierRepository soldierRepository)
        {
            _soldierRepository = soldierRepository;
        }

        public async Task<IEnumerable<Soldier>> GetAllSoldiers()
            => await _soldierRepository.GetAllSoldiers();

        [HttpGet("{lastname}")]
        public async Task<IEnumerable<Soldier>> GetSoldierByLastName(string lastname)
        => await _soldierRepository.GetSoldierByLastName(lastname);
      
    }
}