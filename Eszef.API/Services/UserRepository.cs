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

        public async Task<User> GetUser(string email) 
            => await Task.FromResult(_appDbContext.Find<User>(user => user.Email == email).FirstOrDefault());
        
        public async Task<User> Login(string email, string password)
        {
            var user = await GetUser(email);
            if(user == null)
            {
                throw new Exception("Invalid credentials");
            }
            return user;
        }


        public async Task Register(string email, string password)
        {
            var user = await GetUser(email);
            if(user != null)
            {
                throw new Exception($"User with email: {email} already exists");
            }
            // hash, salt ...
            _appDbContext.InsertOne(new User(email, password));
            
        }
    }
}
