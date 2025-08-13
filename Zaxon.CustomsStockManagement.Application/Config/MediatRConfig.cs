using Microsoft.Extensions.DependencyInjection;

namespace Zaxon.CustomsStockManagement.Application.Config;

public static class MediatRConfig
{
    public static IServiceCollection ConfigureMediatR(this IServiceCollection services)
    {
        return services.
            AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
    }
}
