using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;

namespace Zaxon.CustomsStockManagement.Infrastructure.Config;

public static class OptionsConfiguration
{
    public static IServiceCollection ConfigureApplicationOptions(this IServiceCollection services, IConfiguration configuration)
    {
        return services
            .Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
    }
}
