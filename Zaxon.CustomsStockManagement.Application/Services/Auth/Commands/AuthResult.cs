namespace Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;

public class AuthResult
{
    public required string AccessToken { get; set; }
    public required UserDto User { get; set; }
}

public class TokenPair
{

}

public class UserDto
{
    public required Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string FullName { get; set; }
}