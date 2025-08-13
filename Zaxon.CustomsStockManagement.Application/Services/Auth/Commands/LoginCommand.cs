using MediatR;

namespace Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;

public class LoginCommand : IRequest<AuthResult>
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
