using CleanArx.Core.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArx.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreDI(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<AppSettings>(configuration.GetSection(AppSettings.SectionName));
        return services;
    }
}
