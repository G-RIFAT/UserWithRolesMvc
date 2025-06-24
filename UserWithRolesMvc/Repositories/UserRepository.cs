using Microsoft.EntityFrameworkCore;
using UserWithRolesMvc.Data;
using UserWithRolesMvc.Models;
using UserWithRolesMvc.Repositories.Interfaces;

namespace UserWithRolesMvc.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync(string role = "")
        {
            return await _context.Users
                .Where(u => role == null || u.Role == role)
                .ToListAsync();
        }
    }
}
