namespace Zaxon.CustomsStockManagement.Api.Common.BuildConfigurations;

public class DevelopmentHostingBuildConfiguration
{
    public const string EnvName = "DevelopmentHosting";   
}
public static class DevelopmentHostingBuildConfigurationExtensions
{
    public static bool IsDevelopmentHosting(this IWebHostEnvironment environment)
    {
        return environment.EnvironmentName == DevelopmentHostingBuildConfiguration.EnvName;
    }
}
