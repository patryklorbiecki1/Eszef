using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eszef.API.Commands.Users;
using Eszef.API.DTO;
using Eszef.API.Models;
using Eszef.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Eszef.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtHandler _jwtHandler;
        
        public LoginController(IUserService userService, IJwtHandler jwtHandler)
        {
            _userService = userService;
            _jwtHandler = jwtHandler;
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] CreateUser createUser)
        {
            IActionResult response = Unauthorized();
            var user = await _userService.Login(createUser.Email, createUser.Password);
            if(user != null)
            {
                var tokenString = await _jwtHandler.GenerateToken(user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }

        [AllowAnonymous]
        [HttpPost("/register/")]
        public async Task<IActionResult> Register([FromBody] CreateUser createUser)
        {
            await _userService.Register(createUser.Email, createUser.Password);
            return Ok();
        }

        [Authorize]
        [HttpGet("user/{email}")]
        public async Task<UserDTO> GetUser(string email)
        {
            return await _userService.Get(email);
        }

        [Authorize]
        [HttpPut("user/")]
        public async Task UpdateUser([FromBody] UserDTO user)
        {
            var u = await _userService.GetUser(user.Email);
            u.Company = user.Company;
            u.Cost = user.Cost;
            u.LastName = user.LastName;
            u.UserName = user.UserName;
            await _userService.Update(u);
        }
    }
}
