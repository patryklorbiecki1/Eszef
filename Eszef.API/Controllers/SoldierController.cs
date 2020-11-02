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

        public IEnumerable<Soldier> GetAllSoldiers()
            => _soldierRepository.GetAllSoldiers;

        [HttpGet("{lastname}")]
        public IEnumerable<Soldier> GetSoldierByLastName(string lastname)
        => _soldierRepository.GetSoldierByLastName(lastname);

        [HttpGet("id/{id}")]
        public Soldier GetSoldierById(int id)
       => _soldierRepository.GetSoldierById(id);
    }
}