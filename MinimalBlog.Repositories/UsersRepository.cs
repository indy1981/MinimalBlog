using Microsoft.EntityFrameworkCore;
using MinimalBlog.IRepositories;
using MinimalBlog.Models;
using System.Text;
using System.Threading.Tasks;

namespace MinimalBlog.Repositories
{
    public class UsersRepository : EFBaseRepository<Entry, int>, IUsersRepository
    {
        public UsersRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _dbContext.Set<User>().FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;            
            return user;
        }

        public async Task<User> Create(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _dbContext.Set<User>().AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }   
        
        public async Task<User> GetByUsername(string username)
        {
            return await _dbContext.Set<User>().FirstOrDefaultAsync(x => x.Username == username);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) 
                    {
                        return false; 
                    }
                }

                return true;
            }
        }
    }
}
