namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string SecurityKey { get; set; }
    public int TokenValidityInHours { get; set; }
}