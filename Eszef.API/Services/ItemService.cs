using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task AddItem(string itemName,int idRoom)
        {
            await _itemRepository.Create(itemName, idRoom); 
        }

        public async Task DeleteItemById(string id)
        {
            await _itemRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Item>> GetAllItems()
            => await _itemRepository.GetAllItems();
        

        public async Task<Item> GetItemById(string id)
            => await _itemRepository.GetItemById(id);
        
    }
}
