using UserWithRolesMvc.Models;

namespace UserWithRolesMvc.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync(string role = "");

    }
}
