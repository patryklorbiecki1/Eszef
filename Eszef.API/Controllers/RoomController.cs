using Eszef.API.Models;
using Eszef.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        // GET: /room/id
        [HttpGet("{id}")]
        public async Task<Room> GetById(int id)
            => await _roomService.GetRoom(id);

    }
}
