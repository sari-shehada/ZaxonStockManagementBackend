using System.ComponentModel.DataAnnotations;
using Zaxon.CustomsStockManagement.Domain.Entities.Base;

namespace Zaxon.CustomsStockManagement.Domain.Entities;


//TODO: Re-think Permissions System
public class DomainUser : EntityBase
{

    [MaxLength(64)]
    public required string Username { get; set; }

    [MaxLength(64)]
    public required string PasswordHash { get; set; }

    public required string FullName { get; set; }
    public bool ShouldResetPasswordUponLogin { get; set; } = true;
    public bool CanAddCustomsDocument { get; set; } = false;
    public bool CanViewStockChanges { get; set; } = false;
    public bool CanAddUsers { get; set; } = false;
    public bool CanModifyUsers { get; set; } = false;
    public DateTime? LastLoginDate { get; set; }
}
