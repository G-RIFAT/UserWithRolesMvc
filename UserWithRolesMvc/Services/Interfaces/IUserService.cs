using UserWithRolesMvc.Models;

namespace UserWithRolesMvc.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync(string role);
    }
}
