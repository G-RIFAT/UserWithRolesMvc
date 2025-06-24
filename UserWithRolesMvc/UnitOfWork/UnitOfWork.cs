using System;
using UserWithRolesMvc.Data;
using UserWithRolesMvc.Repositories;
using UserWithRolesMvc.Repositories.Interfaces;
using UserWithRolesMvc.UnitOfWork.Interfaces;

namespace UserWithRolesMvc.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserDbContext _context;
        public IUserRepository Users { get; }

        public UnitOfWork(UserDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
