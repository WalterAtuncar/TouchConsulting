using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Domain.Interfaces;
using Infrastructure.Services;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SecurityDbContext>(options =>
                options.UseSqlServer(connectionString, 
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 5,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                        sqlOptions.MigrationsAssembly(typeof(SecurityDbContext).Assembly.FullName);
                    }));

            services.AddScoped<ISecurityDbContext>(provider => 
                provider.GetRequiredService<SecurityDbContext>());

            services.AddScoped<ICryptoService, CryptoService>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
