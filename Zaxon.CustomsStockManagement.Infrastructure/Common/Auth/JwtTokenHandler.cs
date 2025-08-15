using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Zaxon.CustomsStockManagement.Application.Common.Auth;
using Zaxon.CustomsStockManagement.Application.Common.Services;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;

public class JwtTokenHandler : IJwtTokenHandler
{
    private readonly IDateTimeProvider dateTimeProvider;
    private readonly JwtSettings jwtSettings;

    private readonly SymmetricSecurityKey key;
    private readonly string securityAlgorithm = SecurityAlgorithms.HmacSha256;


    public JwtTokenHandler(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
    {
        this.dateTimeProvider = dateTimeProvider;
        jwtSettings = jwtOptions.Value;
        key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Value.SecurityKey));
    }




    public string GenerateToken(List<Claim> claims)
    {
        var signingCredentials = new SigningCredentials(key, securityAlgorithm);

        var securityToken = new JwtSecurityToken(
            claims: claims,
            signingCredentials: signingCredentials,
            issuer: jwtSettings.Issuer,
            audience: jwtSettings.Audience,
            expires: dateTimeProvider.UtcNow.AddHours(jwtSettings.TokenValidityInHours));

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}
