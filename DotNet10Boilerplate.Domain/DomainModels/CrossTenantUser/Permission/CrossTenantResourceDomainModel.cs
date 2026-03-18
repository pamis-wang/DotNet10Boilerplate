using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.CrossTenantUser.Permission;

/// <summary> 跨租戶用戶可用資源定義領域模型 </summary>
public class CrossTenantResourceDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 父級資源ID </summary>
    public Guid? ParentId { get; set; }

    /// <summary> 資源層級 (1:一層, 2:二層, 3:三層) </summary>
    public int Level { get; set; } = 0;

    /// <summary> 資源名稱 </summary>
    public string ResourceName { get; set; } = string.Empty;

    /// <summary> 顯示順序 </summary>
    public int DisplayOrder { get; set; }

    /// <summary> 是否啟用 </summary>
    public bool IsEnabled { get; set; }

    /// <summary> 租戶 </summary>
    public CrossTenantTenantDomainModel? Tenant { get; set; }

    /// <summary> 角色權限集合的關聯 </summary>
    public IEnumerable<CrossTenantRolePermissionDomainModel> RolePermissions { get; set; } = [];
}
