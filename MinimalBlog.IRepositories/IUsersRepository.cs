using MinimalBlog.Models;
using System.Threading.Tasks;

namespace MinimalBlog.IRepositories
{
    public interface IUsersRepository
    {
        Task<User> Create(User user, string password);

        Task<User> Login(string username, string password);

        Task<User> GetByUsername(string username);
    }
    
}
