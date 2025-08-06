using Microsoft.EntityFrameworkCore;
using Zaxon.CustomsStockManagement.Domain.Entities;

namespace Zaxon.CustomsStockManagement.Infrastructure.Data;

public class StockManagementDbContext : DbContext
{
    public StockManagementDbContext(DbContextOptions<StockManagementDbContext> options) : base(options)
    {

    }

    //Entites
    public DbSet<DomainUser> Users { get; set; }
}
