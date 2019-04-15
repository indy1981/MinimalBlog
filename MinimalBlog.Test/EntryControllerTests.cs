using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalBlog.API.Controllers;
using MinimalBlog.DTOs;
using MinimalBlog.Models;
using MinimalBlog.Repositories;
using MinimalBlog.Services;
using Moq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MinimalBlog.Test
{
    public class EntryControllerTest
    {

        public EntryControllerTest()
        {
           
        }

        [Fact]
        public async Task GetControllerReturnsExistingEntry()
        {
            // Arrange          
            var entry = new Entry() 
            {
                Id = 99                
            };

            var repository = new Mock<EntryRepository>(It.IsAny<DbContext>());
            repository.Setup(x => x.GetByIdAsync(99)).Returns(Task.FromResult(entry));
            var service = new EntriesService(repository.Object);
            var controller = GetEntriesControllerWithUser(service);

            // Act
            var result = await controller.Get(entry.Id) as OkObjectResult;

            // Assert
            Assert.Equal(result.StatusCode, StatusCodes.Status200OK);
            Assert.Equal(result.Value, entry);
        }

        [Fact]
        public void PostControllerSavesPublicEntry()
        {
            // Arrange          
            var entryVM = new EntryViewModel()
            {
                Content = "SuperContent",
                Summary = "SuperSummary"
            };

            var entryResult = new Entry()
            {
                Content = "SuperContent",
                Summary = "SuperSummary"
            };

            var repository = new Mock<EntryRepository>(It.IsAny<DbContext>());
            repository.Setup(x => x.Create(It.IsAny<Entry>())).Returns(It.IsAny<Entry>());
            var service = new EntriesService(repository.Object);
            var controller = GetEntriesControllerWithUser(service);

            // Act
            var result = controller.Post(entryVM) as OkObjectResult;

            // Assert
            Assert.Equal(result.StatusCode, StatusCodes.Status200OK);
        }               

        [Fact]        
        public void PostControllerDoesNotSavesPublicEntry()
        {
            // Arrange          
            var entry = new EntryViewModel()
            {                
                Content = "SuperContent"                
            };           

            var repository = new Mock<EntryRepository>(It.IsAny<DbContext>());
            repository.Setup(x => x.Create(It.IsAny<Entry>())).Returns(It.IsAny<Entry>());
            var service = new EntriesService(repository.Object);
            var controller = GetEntriesControllerWithUser(service);

            // Act
            var result = controller.Post(entry) as OkObjectResult;

            // Assert
            Assert.Equal(result.StatusCode, StatusCodes.Status200OK);
        }

        private static EntriesController GetEntriesControllerWithUser(EntriesService service)
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, "1")     
                    }
                )
            );
            
            var controller = new EntriesController(service);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext() { User = user }
            };
            return controller;
        }
    }
}