using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;
using Zaxon.CustomsStockManagement.Contracts.Auth.Login;

namespace Zaxon.CustomsStockManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly ISender sender;

    public AuthController(ISender sender)
    {
        this.sender = sender;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var command = new LoginCommand()
        {
            Username = request.Username,
            Password = request.Password,
        };

        var loginResult = await sender.Send(command);

        return Ok(loginResult);
    }
}
