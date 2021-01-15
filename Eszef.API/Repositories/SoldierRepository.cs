using Eszef.API.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
{
    public class SoldierRepository : ISoldierRepository
    {
        private readonly IMongoCollection<Soldier> _appDbContext;
        public SoldierRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.Database);
            _appDbContext = database.GetCollection<Soldier>("soldier");
        }

        public Task Create(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteById(string id)
            => await Task.FromResult(_appDbContext.DeleteOne(soldier => soldier.IdSoldier == id));

        public async Task<IEnumerable<Soldier>> GetAll()
            => await Task.FromResult(_appDbContext.Find(soldier => true).ToList());
        
        public async Task<IEnumerable<Soldier>> GetSoldier(string lastname)
            => await Task.FromResult(_appDbContext.Find<Soldier>(x => x.LastName == lastname).ToList());

        public Task Update(Soldier soldier)
        {
            throw new NotImplementedException();
        }
    }
}
