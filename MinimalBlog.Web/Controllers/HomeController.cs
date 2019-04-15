using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MinimalBlog.DTOs;
using MinimalBlog.Models;
using MinimalBlog.Web.Models;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MinimalBlog.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IConfiguration _configuration;
        private readonly string APIUrl;

        public HomeController(IConfiguration configuration) 
        {
            _configuration = configuration;
            APIUrl = _configuration["APIUrl"];
        }
        
        public async Task<IActionResult> Index()
        {
            HttpClient httpClient = new HttpClient();
            var modifier = "publics";

            if (User.Identity.IsAuthenticated)
            {
                modifier = "AllMyEntries";
                AddTokenToClient(httpClient);
            }

            var response = await httpClient.GetAsync($"{APIUrl}/api/entries/{modifier}");

            if (!response.IsSuccessStatusCode)
            {
                await HttpContext.SignOutAsync();
                return View("Error");
            }
            var model = new IndexModel
            {
                Entries = await response.Content.ReadAsAsync<IEnumerable<Entry>>()
            };

            return View(model);
        }

        public async Task<IActionResult> LoginAsync(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return View("ErrorAtLogin");
            }

            HttpClient httpClient = new HttpClient();     
            
            var response = await httpClient.PostAsJsonAsync($"{APIUrl}/api/Users/login", loginDto);
            if (!response.IsSuccessStatusCode)
            {
                await HttpContext.SignOutAsync();
                return View("ErrorAtLogin");
            }

            var token = await response.Content.ReadAsStringAsync();
            var jwtToken = new JwtSecurityToken(token);
            var claims = jwtToken.Claims.ToList();
            claims.Add(new Claim("access_token", token));
            await HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)));
            return Redirect("Index");
        }   
        
        public async Task<IActionResult> LogOutAsync() 
        {
            await HttpContext.SignOutAsync();
            return Redirect("Index");
        }
    }
}
