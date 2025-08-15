using Microsoft.Extensions.DependencyInjection;
using Zaxon.CustomsStockManagement.Application.Common.Auth;
using Zaxon.CustomsStockManagement.Application.Common.Services;
using Zaxon.CustomsStockManagement.Application.Repositories;
using Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;
using Zaxon.CustomsStockManagement.Infrastructure.Common.Services;
using Zaxon.CustomsStockManagement.Infrastructure.Repositories;

namespace Zaxon.CustomsStockManagement.Infrastructure.Config;

public static class ServicesConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        return services
            .AddSingleton<IDateTimeProvider, DateTimeProvider>()
            .AddScoped<IUserClaimsHandler, UserClaimsHandler>()
            .AddScoped<IJwtTokenHandler, JwtTokenHandler>()
            .AddScoped<IPasswordManager, PasswordManager>();
    }
}
