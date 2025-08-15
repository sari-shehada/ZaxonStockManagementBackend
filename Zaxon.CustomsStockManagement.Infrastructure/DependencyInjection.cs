using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zaxon.CustomsStockManagement.Infrastructure.Config;

namespace Zaxon.CustomsStockManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfigurationManager configuration)
    {
        return services
            .ConfigureDbContext(configuration)
            .ConfigureRepositories();
    }
}
