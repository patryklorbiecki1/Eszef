using Eszef.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Login(string email, string password)
        {
            var user = await _userRepository.GetUser(email);
            if (user == null)
            {
                throw new Exception("Invalid credentials");
            }
            return user;
        }

        public async Task Register(string email, string password)
        {
            var user = await _userRepository.GetUser(email);
            if (user != null)
            {
                throw new Exception($"User with email: {email} already exists");
            }
            // hash, salt ...
            await _userRepository.CreateUser(new User(email, password));

        }
    }
}
