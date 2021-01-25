using Eszef.API.Database;
using Eszef.API.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Repositories
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

        public async Task Create(string itemName, int idRoom)
        {
            _appDbContext.InsertOne(new Item(itemName, idRoom));
            await Task.CompletedTask;
        }
	    public async Task DeleteById(string id) 
            => await Task.FromResult(_appDbContext.DeleteOne(item => item.Id == id));
        
        public async Task Update(Item item)
          => await Task.FromResult(_appDbContext.ReplaceOne(x=>x.Id==item.Id,item));
        
    }
}
