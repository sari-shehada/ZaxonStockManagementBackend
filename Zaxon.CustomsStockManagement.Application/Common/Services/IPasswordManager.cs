namespace Zaxon.CustomsStockManagement.Application.Common.Services;

public interface IPasswordManager
{
    bool ValidatePasswordAgainstHash(string password, string passwordHash);

    string HashPassword(string password);
}
