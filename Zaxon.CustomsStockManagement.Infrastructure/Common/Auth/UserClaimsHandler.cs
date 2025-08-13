using System.Security.Claims;
using Zaxon.CustomsStockManagement.Application.Common.Auth;
using Zaxon.CustomsStockManagement.Domain.Entities;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Auth;

public class UserClaimsHandler : IUserClaimsHandler
{
    public List<Claim> GenerateClaimsList(DomainUser user)
    {
        throw new NotImplementedException();
    }

    public List<Claim> GenerateClaimsList(UserClaims userClaims)
    {
        throw new NotImplementedException();
    }
}
