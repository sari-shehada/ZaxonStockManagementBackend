using System.Security.Claims;
using Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;
using Zaxon.CustomsStockManagement.Domain.Entities;

namespace Zaxon.CustomsStockManagement.Application.Common.Auth;

public interface IUserClaimsHandler
{
    List<Claim> GenerateClaimsList(DomainUser user);
    List<Claim> GenerateClaimsList(UserClaims userClaims);
}

public class UserClaims
{
    public Guid Id { get; set; }

    public string FullName { get; set; } = string.Empty;
}