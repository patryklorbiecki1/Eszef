using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();
        IEnumerable<Item> GetItemsByRoom(int idRoom);
        Item GetItemById(int id);
    }
}
