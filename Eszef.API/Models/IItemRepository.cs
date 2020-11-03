using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAllItems();
        Task<IEnumerable<Item>> GetItemsByRoom(int idRoom);
        Task<Item> GetItemById(string id);
        Task Create(string itemName, int idRoom);
        
    }
}
