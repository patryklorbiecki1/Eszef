using Eszef.API.Models;
using Eszef.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class RoomService : IRoomService
    {
        private readonly IItemRepository _itemRepository;
        private readonly ISoldierRepository _soldierRepository;

        public RoomService(IItemRepository itemRepository, ISoldierRepository soldierRepository)
        {
            _itemRepository = itemRepository;
            _soldierRepository = soldierRepository;
        }
        public async Task<Room> GetRoom(int id)
        {
            var soldiers = await _soldierRepository.GetAll();
            soldiers = soldiers.Where(x => x.IdRoom == id);
            var items = await _itemRepository.GetAllItems();
            items = items.Where(x => x.IdRoom == id);
            return new Room(items, soldiers);
        }
    }
}
