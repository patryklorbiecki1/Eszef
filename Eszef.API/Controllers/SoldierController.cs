using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eszef.API.Commands;
using Eszef.API.Models;
using Eszef.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eszef.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoldierController : ControllerBase
    {
        private readonly ISoldierService _soldierService;

        public SoldierController(ISoldierService soldierService)
        {
            _soldierService = soldierService;
        }

        // GET: /soldier/
        public async Task<IEnumerable<Soldier>> GetAllSoldiers()
            => await _soldierService.GetAllSoldiers();


        // GET: /soldier/{lastname}
        [HttpGet("{lastname}")]
        public async Task<IEnumerable<Soldier>> GetSoldierByLastName(string lastname)
        => await _soldierService.GetSoldierByLastName(lastname);
      
        [HttpPost]
        public async Task<IActionResult> CreateSoldier([FromBody] CreateSoldier soldier)
        {
            await _soldierService.CreateSoldier(new Soldier(soldier.Name, soldier.Lastname, soldier.Rank, soldier.IdRoom));
            return Accepted();
        }

        // DELETE: /soldier/{id}
        [HttpDelete("{id}")]
        public async Task DeleteSoldier(string id)
        {
            await _soldierService.DeleteById(id);
        }

    }
}