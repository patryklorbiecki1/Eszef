using Eszef.API.DTO;
using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public interface IItemService
    {
        Task<ItemDTO> GetItemById(string id);
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task DeleteItemById(string id);
        Task AddItem(string itemName,int idRoom);
        Task Repair(ItemDTO item);
        Task Update(ItemDTO item);
    }
}
