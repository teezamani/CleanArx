using CleanArx.Core;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArx.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddCoreDI();
        return services;
    }
}
