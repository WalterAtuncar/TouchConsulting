using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Role> Roles { get; }
        DbSet<Person> Person { get; }
        DbSet<Menu> Menus { get; }
        DbSet<RoleMenu> RoleMenus { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
} 