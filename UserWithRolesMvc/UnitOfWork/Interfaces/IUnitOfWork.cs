using UserWithRolesMvc.Repositories.Interfaces;

namespace UserWithRolesMvc.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}
