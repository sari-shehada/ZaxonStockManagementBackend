namespace Zaxon.CustomsStockManagement.Application;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Zaxon.CustomsStockManagement.Application.Config;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services
            .ConfigureMediatR();
    }
}
