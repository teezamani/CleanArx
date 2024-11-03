using CleanArx.Core.Interfaces;
using CleanArx.Core.Options;
using CleanArx.Infrastructure.Data;
using CleanArx.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CleanArx.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>((provider, options) =>
        {
            options.UseSqlServer(provider.GetRequiredService<IOptions<AppSettings>>().Value.DefaultConnection);
        });

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
}
