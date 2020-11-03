using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eszef.API.Commands.Users;
using Eszef.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eszef.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: /user
        [HttpGet]
        public IEnumerable<User> Get() =>
            _userRepository.GetAllUsers();       

        // GET: /user/email
        [HttpGet("{email}")]
        public User Get(string email) => _userRepository.GetUserByEmail(email);
         
        [HttpPost("")]
        public void Post([FromBody] CreateUser createUser)
        {
            _userRepository.Register(createUser.Email, createUser.Password);
        }
    }
}
