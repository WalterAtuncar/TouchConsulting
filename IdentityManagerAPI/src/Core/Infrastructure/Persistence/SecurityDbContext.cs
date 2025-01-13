using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq.Expressions;

namespace Infrastructure.Persistence
{
    public partial class SecurityDbContext : DbContext, ISecurityDbContext
    {
        private readonly IConfiguration _configuration;

        public SecurityDbContext(DbContextOptions<SecurityDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicar filtro global para IsDeleted = 0 en todas las entidades que tienen esta propiedad
            Expression<Func<Role, bool>> filterRole = r => !r.IsDeleted;
            modelBuilder.Entity<Role>().HasQueryFilter(filterRole);

            Expression<Func<Menu, bool>> filterMenu = m => !m.IsDeleted;
            modelBuilder.Entity<Menu>().HasQueryFilter(filterMenu);

            Expression<Func<Person, bool>> filterPerson = p => !p.IsDeleted;
            modelBuilder.Entity<Person>().HasQueryFilter(filterPerson);

            Expression<Func<RoleMenu, bool>> filterRoleMenu = rm => !rm.IsDeleted;
            modelBuilder.Entity<RoleMenu>().HasQueryFilter(filterRoleMenu);

            Expression<Func<User, bool>> filterUser = u => !u.IsDeleted;
            modelBuilder.Entity<User>().HasQueryFilter(filterUser);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
