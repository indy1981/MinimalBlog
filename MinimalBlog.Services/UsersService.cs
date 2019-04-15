using MinimalBlog.IRepositories;
using MinimalBlog.Models;
using System.Threading.Tasks;

namespace MinimalBlog.Services
{
    public class UsersService
    {
        private readonly IUsersRepository Repository;

        public UsersService(IUsersRepository repository)
        {
            Repository = repository;            
        }

        public Task<User> Login(string username, string password)
        {
            return Repository.Login(username, password);
        }

        public Task<User> Register(User user, string Password)
        {
            return Repository.Create(user, Password);
        }

        public Task<User> GetByUsername( string Username)
        {
            return Repository.GetByUsername(Username);
        }
    }
}
