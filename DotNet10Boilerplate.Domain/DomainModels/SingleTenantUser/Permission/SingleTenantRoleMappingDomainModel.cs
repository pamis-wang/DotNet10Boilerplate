using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser.Permission;

/// <summary> 用戶角色對應領域模型 </summary>
public class SingleTenantRoleMappingDomainModel : AuditableDomainModel
{
    /// <summary> 後台用戶唯一編號 </summary>
    public Guid UserId { get; set; }

    /// <summary> 角色唯一編號 </summary>
    public Guid RoleId { get; set; }

    /// <summary> 後台用戶唯一編號 </summary>
    public SingleTenantUserDomainModel? User { get; set; }

    /// <summary> 角色唯一編號 </summary>
    public SingleTenantRoleDomainModel? Role { get; set; }
}
