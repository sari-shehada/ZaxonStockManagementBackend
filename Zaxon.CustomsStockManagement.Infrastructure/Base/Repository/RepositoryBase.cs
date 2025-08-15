using Microsoft.EntityFrameworkCore;
using Zaxon.CustomsStockManagement.Domain.Entities.Base;
using Zaxon.CustomsStockManagement.Infrastructure.Data;

namespace Zaxon.CustomsStockManagement.Infrastructure.Base.Repository;

public class RepositoryBase<T>(StockManagementDbContext context)
    where T : EntityBase
{
    public DbSet<T> Table { get; } = context.Set<T>();
}
