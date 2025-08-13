using Zaxon.CustomsStockManagement.Application.Common.Services;

namespace Zaxon.CustomsStockManagement.Infrastructure.Common.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
