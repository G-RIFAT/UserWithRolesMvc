using UserWithRolesMvc.Models;
using UserWithRolesMvc.Services.Interfaces;
using UserWithRolesMvc.UnitOfWork.Interfaces;

namespace UserWithRolesMvc.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> GetUsersAsync(string role)
        {
            return await _unitOfWork.Users.GetAllAsync(role);
        }
    }
}
