using AutoMapper;
using Eszef.API.DTO;
using Eszef.API.Models;
using Eszef.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }
        public async Task AddItem(string itemName,int idRoom)
        {
            await _itemRepository.Create(itemName, idRoom); 
        }

        public async Task DeleteItemById(string id)
        {
            await _itemRepository.DeleteById(id);
        }

        public async Task<IEnumerable<ItemDTO>> GetAllItems()
        {
           var items = await _itemRepository.GetAllItems();
            return _mapper.Map<IEnumerable<Item>, IEnumerable<ItemDTO>>(items); 
        }

        public async Task<ItemDTO> GetItemById(string id)
        {
          var item = await _itemRepository.GetItemById(id);
            return _mapper.Map<Item, ItemDTO>(item);
        }

        public async Task Repair(ItemDTO item)
        {
            var i = await _itemRepository.GetItemById(item.Id);
            i.Repair();
            await _itemRepository.Upadate(i);
        }

        public async Task Update(ItemDTO item)
        {
            var i = await _itemRepository.GetItemById(item.Id);
            await _itemRepository.Upadate(i);
        }
    }
}
