using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MinimalBlog.DTOs;
using MinimalBlog.Models;
using MinimalBlog.Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinimalBlog.API.Controllers
{
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly UsersService _service;
        private readonly IConfiguration _configuration;
        public UsersController(UsersService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LoginDto userForRegisterDto)
        {            
            if (await _service.GetByUsername(userForRegisterDto.Username) != null)
            {
                return BadRequest("Username already exists");
            }
                
            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };

            var createdUSer = await _service.Register(userToCreate, userForRegisterDto.Password);
            return StatusCode(201);
        }

        [Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> IndexAsync([FromBody] LoginDto loginInfo)
        {
            var resultLogin = await _service.Login(loginInfo.Username, loginInfo.Password);
            if (resultLogin == null)
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, resultLogin.Id.ToString()),
                new Claim(ClaimTypes.Name, resultLogin.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token"]));
           
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);            
            return base.Ok(tokenHandler.WriteToken(token));
        }
    }
}
