using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;

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
    public async Task<IActionResult> Login()
    {
        var command = new LoginCommand()
        {
            Username = "sari",
            Password = "sari12345"
        };

        var loginResult = await sender.Send(command);

        throw new NotImplementedException();
    }
}
