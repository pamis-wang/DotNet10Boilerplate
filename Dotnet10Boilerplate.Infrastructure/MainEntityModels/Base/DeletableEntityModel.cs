using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;

/// <summary> 可刪除基礎領域模型，包含軟刪除相關欄位 </summary>
public abstract class DeletableEntityModel : AuditableEntityModel
{
    /// <summary> 刪除時間 </summary>
    [Column("deleted_at")]
    [Comment("刪除時間")]
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary> 刪除人員 </summary>
    [Column("deleted_by")]
    [Comment("刪除人員")]
    public string? DeletedBy { get; set; }
}