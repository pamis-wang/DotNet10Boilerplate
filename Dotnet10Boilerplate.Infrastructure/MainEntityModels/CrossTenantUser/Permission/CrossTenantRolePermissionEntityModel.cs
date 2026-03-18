using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser.Permission;

/// <summary> 跨租戶用戶角色權限設定實體模型 </summary>
[Table("cross_tenant_role_permissions")]
[Comment("跨租戶用戶角色權限設定資料表")]
[Index(nameof(TenantId), nameof(RoleId), nameof(ResourceId), Name = "uq_cross_tenant_role_permissions_tenant_role_resource", IsUnique = true)]
public class CrossTenantRolePermissionEntityModel : AuditableEntityModel
{
    /// <summary> 唯一編號 </summary>
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Comment("唯一編號")]
    [Required]
    public Guid Id { get; set; }

    /// <summary> 租戶唯一編號 </summary>
    [Column("tenant_id")]
    [Comment("租戶唯一編號")]
    [Required]
    public Guid TenantId { get; set; }

    /// <summary> 角色唯一編號 </summary>
    [Column("role_id")]
    [Comment("角色唯一編號")]
    [Required]
    public Guid RoleId { get; set; }

    /// <summary> 資源唯一編號 </summary>
    [Column("resource_id")]
    [Comment("資源唯一編號")]
    [Required]
    public Guid ResourceId { get; set; }

    /// <summary> 訪問權限 </summary>
    [Column("can_access")]
    [Comment("訪問權限")]
    [Required]
    public bool CanAccess { get; set; } = false;

    /// <summary> 新增權限 </summary>
    [Column("can_create")]
    [Comment("新增權限")]
    [Required]
    public bool CanCreate { get; set; } = false;

    /// <summary> 修改權限 </summary>
    [Column("can_update")]
    [Comment("修改權限")]
    [Required]
    public bool CanUpdate { get; set; } = false;

    /// <summary> 刪除權限 </summary>
    [Column("can_delete")]
    [Comment("刪除權限")]
    [Required]
    public bool CanDelete { get; set; } = false;

    /// <summary> 角色 </summary>
    public virtual CrossTenantRoleEntityModel? Role { get; set; }

    /// <summary> 資源 </summary>
    public virtual CrossTenantResourceEntityModel? Resource { get; set; }
}
