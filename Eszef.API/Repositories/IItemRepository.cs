using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAllItems();
        Task<Item> GetItemById(string id);
        Task Create(string itemName, int idRoom);
        Task Upadate(Item item);
        Task DeleteById(string id);
    }
}
