using Zaxon.CustomsStockManagement.Domain.Entities;

namespace Zaxon.CustomsStockManagement.Application.Repositories;

public interface IUserRepository
{
    Task<DomainUser> GetUserByUsernameAsync(string username);
    Task UpdateUserLastLoginDate(Guid id, DateTime dateTime);
}
