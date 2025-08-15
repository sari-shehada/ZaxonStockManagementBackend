using Microsoft.EntityFrameworkCore;
using Zaxon.CustomsStockManagement.Application.Common.Services;
using Zaxon.CustomsStockManagement.Application.Repositories;
using Zaxon.CustomsStockManagement.Domain.Entities;
using Zaxon.CustomsStockManagement.Infrastructure.Base.Repository;
using Zaxon.CustomsStockManagement.Infrastructure.Data;

namespace Zaxon.CustomsStockManagement.Infrastructure.Repositories;

public class UserRepository(StockManagementDbContext dbContext, IDateTimeProvider dateTimeProvider) :
    RepositoryBase<DomainUser>(dbContext),
    IUserRepository
{
    public async Task<DomainUser?> GetUserByUsernameAsync(string username)
    {
        return await Table.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task UpdateUserLastLoginDate(Guid id, DateTime dateTime)
    {
        await Table
            .Where(u => u.Id == id)
            .ExecuteUpdateAsync(
                e => e.SetProperty(
                    p => p.LastLoginDate,
                    dateTimeProvider.UtcNow));
    }
}
