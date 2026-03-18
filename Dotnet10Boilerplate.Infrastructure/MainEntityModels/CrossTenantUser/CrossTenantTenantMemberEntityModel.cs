using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser;

/// <summary> 跨租戶成員關聯實體模型（用戶與租戶的多對多關聯） </summary>
[Table("cross_tenant_tenant_members")]
[Comment("跨租戶成員關聯資料表")]
[PrimaryKey(nameof(UserId), nameof(TenantId))]
public class CrossTenantTenantMemberEntityModel : AuditableEntityModel
{
    /// <summary> 用戶唯一編號 </summary>
    [Column("user_id")]
    [Comment("用戶唯一編號")]
    [Required]
    public Guid UserId { get; set; }

    /// <summary> 租戶唯一編號 </summary>
    [Column("tenant_id")]
    [Comment("租戶唯一編號")]
    [Required]
    public Guid TenantId { get; set; }

    /// <summary> 是否停用此成員資格 </summary>
    [Column("is_disabled")]
    [Comment("是否停用此成員資格")]
    [Required]
    public bool IsDisabled { get; set; }

    /// <summary> 加入時間 </summary>
    [Column("joined_at")]
    [Comment("加入時間")]
    [Required]
    public DateTimeOffset JoinedAt { get; set; }

    /// <summary> 用戶 </summary>
    public virtual CrossTenantUserEntityModel? User { get; set; }

    /// <summary> 租戶 </summary>
    public virtual CrossTenantTenantEntityModel? Tenant { get; set; }
}
