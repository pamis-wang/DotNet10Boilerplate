using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser.Permission;

/// <summary> 用戶的角色領域模型 </summary>
public class SingleTenantRoleDomainModel: AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 角色名稱 </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary> 是否要求使用多因素驗證登入 </summary>
    public bool MultiFactorRequired { get; set; } = true;

    /// <summary> 系統預設角色 </summary>
    public bool IsSystemDefault { get; set; }

    /// <summary> 用戶數量 </summary>
    public int UserCount { get; set; }

    /// <summary> 後台用戶角色對應資料表 </summary>
    public IEnumerable<SingleTenantRoleMappingDomainModel> RoleMappings { get; set; } = [];

    /// <summary> 角色權限對應資料表 </summary>
    public IEnumerable<SingleTenantRolePermissionDomainModel> RolePermissions { get; set; } = [];
}
