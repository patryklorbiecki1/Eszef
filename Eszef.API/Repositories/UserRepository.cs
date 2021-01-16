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
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _appDbContext;
        public UserRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.Database);
            _appDbContext = database.GetCollection<User>("user");
        }

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(string email) 
            => await Task.FromResult(_appDbContext.Find<User>(user => user.Email == email).FirstOrDefault());
        
       
    }
}
