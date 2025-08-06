using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Zaxon.CustomsStockManagement.Infrastructure.Config;

public static class InfrastructureConfiguration
{

    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        //TODO: Add More Configuration here as necessary
        return services
            .ConfigureDbContext(configuration);
    } 
}
