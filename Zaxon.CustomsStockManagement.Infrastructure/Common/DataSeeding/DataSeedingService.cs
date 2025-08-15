using Microsoft.EntityFrameworkCore;
using Zaxon.CustomsStockManagement.Application.Common.DataSeeding;
using Zaxon.CustomsStockManagement.Application.Common.Services;
using Zaxon.CustomsStockManagement.Domain.Entities;
using Zaxon.CustomsStockManagement.Infrastructure.Data;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.DataSeeding;

public class DataSeedingService(StockManagementDbContext context, IPasswordManager passwordManager) : IDataSeedingService
{
    public async Task SeedApplicationData()
    {
        await SeedAdminUsers();
    }

    private async Task SeedAdminUsers()
    {
        if(await context.Users.AnyAsync())
        {
            return;
        }
        var user = new DomainUser()
        {
            FullName = "Moaz Al-Sheik Ali",
            Username = "moaz",
            PasswordHash = passwordManager.HashPassword("moaz12345")
        };

        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }
}
