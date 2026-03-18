using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser.Permission;

/// <summary> 用戶角色權限設定領域模型 </summary>
public class SingleTenantRolePermissionDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 角色唯一編號 </summary>
    public Guid RoleId { get; set; }

    /// <summary> 資源唯一編號 </summary>
    public Guid ResourceId { get; set; }

    /// <summary> 訪問權限 </summary>
    public bool CanAccess { get; set; } = false;

    /// <summary> 新增權限 </summary>
    public bool CanCreate { get; set; } = false;

    /// <summary> 修改權限 </summary>
    public bool CanUpdate { get; set; } = false;

    /// <summary> 刪除權限 </summary>
    public bool CanDelete { get; set; } = false;

    /// <summary> 角色 </summary>
    public SingleTenantRoleDomainModel? Role { get; set; }

    /// <summary> 資源 </summary>
    public SingleTenantResourceDomainModel? Resource { get; set; }
}
