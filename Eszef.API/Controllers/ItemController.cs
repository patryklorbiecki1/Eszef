using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eszef.API.Commands.Items;
using Eszef.API.DTO;
using Eszef.API.Models;
using Eszef.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eszef.API.Controllers
{
  
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET: /item
        [HttpGet]
        public async Task<IEnumerable<ItemDTO>> Get()
            => await _itemService.GetAllItems();


        // GET: /item/{id}
       
        [HttpGet("{id}", Name = "Get")]
        public async Task<ItemDTO> GetById(string id)
            => await _itemService.GetItemById(id);
       

        [HttpPost]
        public async Task<IActionResult> AddItem([FromBody] AddItem item)
        {
            await _itemService.AddItem(item.ItemName,item.IdRoom);
            return Accepted();
        }

        // DELETE: /item/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(string id)
        {
            await _itemService.DeleteItemById(id);
            return Ok();
        }
   
   
    }
}
