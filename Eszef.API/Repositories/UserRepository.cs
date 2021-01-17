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

        public async Task CreateUser(User user)
        {
            _appDbContext.InsertOne(new User(user.Email, user.Password));
            await Task.CompletedTask;
        }

        public async Task<User> GetUser(string email,string password) 
            => await Task.FromResult(_appDbContext.Find<User>(user => (user.Email == email && user.Password == password)).FirstOrDefault());
        
       
    }
}
