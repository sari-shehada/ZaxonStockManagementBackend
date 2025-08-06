namespace Zaxon.CustomsStockManagement.Domain.Entities.Base;

public class EntityBase
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
}
