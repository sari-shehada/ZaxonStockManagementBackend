using System.Security.Claims;

namespace Zaxon.CustomsStockManagement.Application.Common.Auth;

public interface IJwtTokenHandler
{
    string GenerateToken(List<ClaimsPrincipal> claims);
}
