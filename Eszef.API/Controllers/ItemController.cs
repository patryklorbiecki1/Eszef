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
    public class ItemController : ControllerBase
    {

        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        // GET: /Item
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _itemRepository.GetAllItems();
        }

        // GET: /Item/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return _itemRepository.GetItemById(id);
        }
    }
}
