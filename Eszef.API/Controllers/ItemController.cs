using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eszef.API.Commands.Items;
using Eszef.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eszef.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        // GET: /item
        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
            => await _itemRepository.GetAllItems();
       
        
        // GET: /item/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Item> GetById(string id)
            => await _itemRepository.GetItemById(id);
       

        [HttpPost("")]
        public async Task<IActionResult> AddItem([FromBody] AddItem item)
        {
            await _itemRepository.Create(item.ItemName,item.IdRoom);
            return Accepted();
        }
   
    }
}
