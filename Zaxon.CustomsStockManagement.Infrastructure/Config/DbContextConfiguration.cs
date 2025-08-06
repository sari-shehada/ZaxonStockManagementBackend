using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zaxon.CustomsStockManagement.Infrastructure.Data;

namespace Zaxon.CustomsStockManagement.Infrastructure.Config;

public static class DbContextConfiguration
{

    public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");
        return services
            .AddDbContext<StockManagementDbContext>(
                dbContextBuilder => dbContextBuilder.UseMySql(
                        connectionString,
                        ServerVersion.AutoDetect(connectionString)
                )
            );
    }
}
