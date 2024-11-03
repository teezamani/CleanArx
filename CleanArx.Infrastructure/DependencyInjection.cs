using CleanArx.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArx.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CleanArxDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        });

        return services;
    }
}
