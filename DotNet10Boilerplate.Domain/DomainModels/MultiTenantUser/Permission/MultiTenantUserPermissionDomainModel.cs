using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.MultiTenantUser.Permission;

/// <summary> 多租戶用戶權限領域模型 </summary>
public class MultiTenantUserPermissionDomainModel : AuditableDomainModel
{
    /// <summary> 租戶唯一編號 </summary>
    public Guid TenantId { get; set; }

    /// <summary> 資源唯一編號 </summary>
    public Guid ResourceId { get; set; }

    /// <summary> 父級資源ID </summary>
    public Guid? ParentId { get; set; }

    /// <summary> 資源名稱 </summary>
    public string ResourceName { get; set; } = string.Empty;

    /// <summary> 資源層級 </summary>
    public int Level { get; set; }

    /// <summary> 訪問權限 </summary>
    public bool CanAccess { get; set; }

    /// <summary> 新增權限 </summary>
    public bool CanCreate { get; set; }

    /// <summary> 修改權限 </summary>
    public bool CanUpdate { get; set; }

    /// <summary> 刪除權限 </summary>
    public bool CanDelete { get; set; }

    /// <summary> 子項目列表 </summary>
    public List<MultiTenantUserPermissionDomainModel> Children { get; set; } = [];
}
