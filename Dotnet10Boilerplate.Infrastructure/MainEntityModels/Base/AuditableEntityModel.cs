using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;

/// <summary> 基礎審計實體模型，包含共用的時間戳記和操作人員欄位 </summary>
public abstract class AuditableEntityModel
{
    /// <summary> 新增時間 </summary>
    [Column("created_at")]
    [Comment("新增時間")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary> 新增人員 </summary>
    [Column("created_by")]
    [Comment("新增人員")]
    public string? CreatedBy { get; set; }

    /// <summary> 更新時間 </summary>
    [Column("updated_at")]
    [Comment("更新時間")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary> 更新人員 </summary>
    [Column("updated_by")]
    [Comment("更新人員")]
    public string? UpdatedBy { get; set; }
}
