using Eszef.API.Database;
using Eszef.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Repositories
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

        public async Task Create(Soldier soldier)
        { 
            _appDbContext.InsertOne(new Soldier(soldier.Name,soldier.LastName,soldier.Rank,soldier.IdRoom));
            await Task.CompletedTask;
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
