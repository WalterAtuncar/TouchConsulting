using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public interface ISecurityDbContext
{
    DbSet<Menu> Menus { get; set; }

    DbSet<Person> Person { get; set; }

    DbSet<Role> Roles { get; set; }

    DbSet<RoleMenu> RoleMenus { get; set; }

    DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
