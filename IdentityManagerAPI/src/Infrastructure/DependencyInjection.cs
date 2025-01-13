using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Domain.Interfaces;
using Application.Common.Interfaces;
using Infrastructure.Services;
using Infrastructure.Persistence;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Register DbContext
            services.AddDbContext<SecurityDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(SecurityDbContext).Assembly.FullName)));

            // Register interfaces
            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<SecurityDbContext>());
            
            // Register Services
            services.AddScoped<ICryptoService, CryptoService>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
} 