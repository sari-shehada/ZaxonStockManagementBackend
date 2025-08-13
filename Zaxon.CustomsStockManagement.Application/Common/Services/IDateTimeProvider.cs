namespace Zaxon.CustomsStockManagement.Application.Common.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
