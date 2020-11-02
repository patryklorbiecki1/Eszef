using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class MockItemRepository : IItemRepository
    {
        public IEnumerable<Item> GetAllItems() =>
            new List<Item>
            {
                new Item{Id = 1,ItemName="Szafa",IdRoom=2},
                new Item{Id = 2,ItemName="Łóżko",IdRoom=3},
                new Item{Id = 3,ItemName="Krzesło",IdRoom=4},
                new Item{Id = 4,ItemName="Biurko",IdRoom=5},

            };

        public Item GetItemById(int id) =>
            GetAllItems().SingleOrDefault(x => x.Id == id);

        public IEnumerable<Item> GetItemsByRoom(int idRoom) =>
            GetAllItems().Where(x => x.IdRoom == idRoom);
    }
}
