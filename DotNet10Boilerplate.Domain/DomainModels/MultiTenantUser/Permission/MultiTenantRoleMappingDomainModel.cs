using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.MultiTenantUser.Permission;

/// <summary> 多租戶用戶角色對應領域模型 </summary>
public class MultiTenantRoleMappingDomainModel : AuditableDomainModel
{
    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 用戶唯一編號 </summary>
    public Guid UserId { get; set; }

    /// <summary> 角色唯一編號 </summary>
    public Guid RoleId { get; set; }

    /// <summary> 用戶 </summary>
    public MultiTenantUserDomainModel? User { get; set; }

    /// <summary> 角色 </summary>
    public MultiTenantRoleDomainModel? Role { get; set; }
}
