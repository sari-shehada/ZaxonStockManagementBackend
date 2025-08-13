using Zaxon.CustomsStockManagement.Application.Common.Services;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Services;

public class PasswordManager : IPasswordManager
{
    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool ValidatePasswordAgainstHash(string password, string passwordHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }
}
