using Eszef.API.Database;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly IMongoCollection<Item> _appDbContext;
        public ItemRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.Database);
            _appDbContext = database.GetCollection<Item>("item");
        }
        public async Task<IEnumerable<Item>> GetAllItems()
            => await Task.FromResult(_appDbContext.Find(item => true).ToList());

        public async Task<Item> GetItemById(string id)
            => await Task.FromResult(_appDbContext.Find<Item>(item=>item.Id == id).FirstOrDefault());
        public async Task<IEnumerable<Item>> GetItemsByRoom(int idRoom)
            => await Task.FromResult(_appDbContext.Find<Item>(item => item.IdRoom == idRoom).ToList());
        public async Task Create(string itemName, int idRoom)
        {
            _appDbContext.InsertOne(new Item(itemName, idRoom));
            await Task.CompletedTask;
        }
    }
}
