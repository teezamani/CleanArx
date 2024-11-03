using CleanArx.Core;
using MediatR.NotificationPublishers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArx.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCoreDI(configuration);
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
/*            cfg.NotificationPublisher = new TaskWhenAllPublisher();
*/        });
        return services;
    }
}
