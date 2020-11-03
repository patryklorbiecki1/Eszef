using Eszef.API.Database;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Models
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
        public async Task<IEnumerable<User>> GetAllUsers()
            => await Task.FromResult(_appDbContext.Find(user => true).ToList());

        public async Task<User> GetUserByEmail(string email)
            => await Task.FromResult(_appDbContext.Find<User>(x => x.Email == email).SingleOrDefault());


        public async Task Register(string email, string password)
        {
            _appDbContext.InsertOne(new User(email, "name", "lastname", 1, password));
            await Task.CompletedTask;
        }

    }
}
