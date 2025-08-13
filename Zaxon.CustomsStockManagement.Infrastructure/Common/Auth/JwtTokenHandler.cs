using System.Security.Claims;
using Zaxon.CustomsStockManagement.Application.Common.Auth;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;

public class JwtTokenHandler : IJwtTokenHandler
{
    public string GenerateToken(List<Claim> claims)
    {
        throw new NotImplementedException();
    }
}
