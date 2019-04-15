using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MinimalBlog.DTOs;
using MinimalBlog.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinimalBlog.Web.Controllers
{
    public class EntryController : BaseController
    {
        private readonly IConfiguration _configuration;
        private readonly string APIUrl;

        public EntryController(IConfiguration configuration)
        {
            _configuration = configuration;
            APIUrl = _configuration["APIUrl"];
        }
     
        public async Task<IActionResult> Show(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"{APIUrl}/api/entries/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }           

            var entry = await response.Content.ReadAsAsync<Entry>();

            return View(entry);
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Index");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsync(EntryViewModel entry)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Index");
            }

            if (!ModelState.IsValid)
            {
                return View("Create", entry);
            }           

            HttpClient httpClient = new HttpClient();

            AddTokenToClient(httpClient); 
            var response = await httpClient.PostAsJsonAsync($"{APIUrl}/api/Entries", entry);
            if (!response.IsSuccessStatusCode)
            {
                return View("Error");
            }

            return View("SavedSuccesfully");
        }        
    }
}
