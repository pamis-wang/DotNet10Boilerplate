using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.MultiTenantUser.Permission;

/// <summary> 多租戶用戶角色領域模型 </summary>
public class MultiTenantRoleDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 角色名稱 </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary> 是否要求使用多因素驗證登入 </summary>
    public bool MultiFactorRequired { get; set; } = true;

    /// <summary> 系統預設角色 </summary>
    public bool IsSystemDefault { get; set; }

    /// <summary> 用戶數量 </summary>
    public int UserCount { get; set; }

    /// <summary> 租戶 </summary>
    public MultiTenantTenantDomainModel? Tenant { get; set; }

    /// <summary> 用戶角色對應資料表 </summary>
    public IEnumerable<MultiTenantRoleMappingDomainModel> RoleMappings { get; set; } = [];

    /// <summary> 角色權限對應資料表 </summary>
    public IEnumerable<MultiTenantRolePermissionDomainModel> RolePermissions { get; set; } = [];
}
