using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinimalBlog.DTOs;
using MinimalBlog.Models;
using MinimalBlog.Models.Enums;
using MinimalBlog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MinimalBlog.API.Controllers
{
    [Route("api/Entries")]
    [Authorize]
    public class EntriesController : ControllerBase
    {
        private readonly EntriesService _service;
        public EntriesController(EntriesService service )
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var result  = await _service.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("publics")]
        public IEnumerable<Entry> GetAllPublicsEntries()
        {
            return  _service.GetAllPublicEntries();
        }

        [HttpGet]        
        [Route("AllMyEntries")]
        public IEnumerable<Entry> GetAllAllMyEntries()
        {            
            //Read id from claims and not from parameter to avoid hack reading other users entries
            var userLoggedId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return _service.GetAllMyEntries(userLoggedId);
        }

        [HttpPost]
        public IActionResult Post([FromBody] EntryViewModel entryVM ) 
        {  
            if (!ModelState.IsValid) 
            {                
                return BadRequest();
            }

            //Should be a mapper tool
            var entry =  new Entry() 
            {
                UserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value),
                Content = entryVM.Content,
                Summary = entryVM.Summary,
                Title = entryVM.Title,
                State = entryVM.IsPrivate ? EntryStateEnum.Private : EntryStateEnum.Public,
                Image = entryVM.Image
            };

            var result = _service.Create(entry);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _service.GetByIdAsync(id) == null)
            {
                return NotFound();
            }

            await _service.DeleteById(id);
            return Ok();
        }
    }
}
