using AutoMapper;
using Eszef.API.DTO;
using Eszef.API.Models;
using Eszef.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eszef.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> Get(string email)
        {
           var user = await _userRepository.GetUser(email);
            return _mapper.Map<User, UserDTO>(user);
        }

        public async Task<User> GetUser(string email)
            => await _userRepository.GetUser(email);
       

        public async Task<User> Login(string email, string password)
        {
            var user = await _userRepository.GetUser(email,password);
            if (user == null)
            {
                throw new Exception("Invalid credentials");
            }
            return user;
        }

        public async Task Register(string email, string password)
        {
            var user = await _userRepository.GetUser(email,password);
            if (user != null)
            {
                throw new Exception($"User with email: {email} already exists");
            }
            // hash, salt ...
            await _userRepository.CreateUser(new User(email, password));

        }

        public async Task Update(User user)
        {
            await _userRepository.Update(user);
        }
    }
}
