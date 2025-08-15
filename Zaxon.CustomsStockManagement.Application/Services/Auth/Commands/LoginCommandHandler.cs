using MediatR;
using Zaxon.CustomsStockManagement.Application.Common.Auth;
using Zaxon.CustomsStockManagement.Application.Common.Services;
using Zaxon.CustomsStockManagement.Application.Repositories;

namespace Zaxon.CustomsStockManagement.Application.Services.Auth.Commands;

public class LoginCommandHandler
    (IUserRepository userRepository,
    IPasswordManager passwordManager,
    IJwtTokenHandler jwtTokenHandler,
    IUserClaimsHandler userClaimsHandler,
    IDateTimeProvider dateTimeProvider)
    : IRequestHandler<LoginCommand, AuthResult>
{

    public async Task<AuthResult> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        //validate the user does exist
        var user = await userRepository.GetUserByUsernameAsync(request.Username);
        if (user is null || !passwordManager.ValidatePasswordAgainstHash(request.Password, user.PasswordHash))
        {
            //TODO: Change later
            throw new Exception("Invalid Login Credentials");
        }

        //Update user last login date to now
        await userRepository.UpdateUserLastLoginDate(user.Id, dateTimeProvider.UtcNow);

        //Generate token if credentials are correct
        var token = jwtTokenHandler.GenerateToken(
            userClaimsHandler.GenerateClaimsList(user));

        return new AuthResult()
        {
            AccessToken = token,
            User = new UserDto()
            {
                UserId = user.Id,
                Username = user.Username,
                FullName = user.FullName,
            },
        };
    }
}
