using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.CrossTenantUser.Permission;

/// <summary> 跨租戶用戶角色對應領域模型 </summary>
/// <remarks> TenantId 與 TenantMember 的 TenantId 對應 </remarks>
public class CrossTenantRoleMappingDomainModel : AuditableDomainModel
{
    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 用戶唯一編號 </summary>
    public Guid UserId { get; set; }

    /// <summary> 角色唯一編號 </summary>
    public Guid RoleId { get; set; }

    /// <summary> 用戶 </summary>
    public CrossTenantUserDomainModel? User { get; set; }

    /// <summary> 角色 </summary>
    public CrossTenantRoleDomainModel? Role { get; set; }
}
