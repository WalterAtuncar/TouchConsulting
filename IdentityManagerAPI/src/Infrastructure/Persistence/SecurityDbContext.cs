using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Common.Interfaces;

namespace Infrastructure.Persistence
{
    public class SecurityDbContext : DbContext, IApplicationDbContext
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Person> People => Set<Person>();
        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<RoleMenu> RoleMenus => Set<RoleMenu>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SecurityDbContext).Assembly);
        }
    }
} 