using Microsoft.Extensions.DependencyInjection;
using Zaxon.CustomsStockManagement.Application.Repositories;
using Zaxon.CustomsStockManagement.Infrastructure.Repositories;

namespace Zaxon.CustomsStockManagement.Infrastructure.Config;

public static class RepositoriesConfiguration
{
    public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
    {
        return services
            .AddScoped<IUserRepository, UserRepository>();
    }
}
