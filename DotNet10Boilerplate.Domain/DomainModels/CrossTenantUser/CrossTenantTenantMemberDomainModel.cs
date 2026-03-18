using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.CrossTenantUser;

/// <summary> 跨租戶成員關聯領域模型（用戶與租戶的多對多關聯） </summary>
public class CrossTenantTenantMemberDomainModel : AuditableDomainModel
{
    /// <summary> 用戶唯一編號 </summary>
    public Guid UserId { get; set; }

    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 是否停用此成員資格 </summary>
    public bool IsDisabled { get; set; }

    /// <summary> 加入時間 </summary>
    public DateTimeOffset JoinedAt { get; set; }

    /// <summary> 用戶 </summary>
    public CrossTenantUserDomainModel? User { get; set; }

    /// <summary> 租戶 </summary>
    public CrossTenantTenantDomainModel? Tenant { get; set; }
}
