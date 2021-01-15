using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface IItemService
    {
        Task<Item> GetItemById(string id);
        Task<IEnumerable<Item>> GetAllItems();
        Task DeleteItemById(string id);
        Task AddItem(string itemName,int idRoom);
    }
}
