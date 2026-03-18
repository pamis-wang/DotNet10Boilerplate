using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser.Permission;

/// <summary> 用戶的可用資源定義領域模型 </summary>
public class SingleTenantResourceDomainModel : AuditableDomainModel
{
    /// <summary> 階層式唯一編號，格式：1AA2BB3CC </summary>
    public Guid Id { get; set; }

    /// <summary> 父級資源ID </summary>
    public Guid? ParentId { get; set; }

    /// <summary> 資源層級 (1:一層, 2:二層, 3:三層) </summary>
    public int Level { get; set; } = 0;

    /// <summary> 資源名稱 </summary>
    public string ResourceName { get; set; } = string.Empty;

    /// <summary> 顯示順序，格式：1AA2BB3CC，同時作為排序依據 </summary>
    public int DisplayOrder { get; set; }

    /// <summary> 是否啟用 </summary>
    public bool IsEnabled { get; set; }

    /// <summary> 角色權限集合的關聯 </summary>
    public IEnumerable<SingleTenantRolePermissionDomainModel> RolePermissions { get; set; } = [];
}
