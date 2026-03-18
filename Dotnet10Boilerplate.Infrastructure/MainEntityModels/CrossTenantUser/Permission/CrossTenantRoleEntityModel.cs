using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser.Permission;

/// <summary> 跨租戶用戶角色實體模型 </summary>
[Table("cross_tenant_roles")]
[Comment("跨租戶用戶角色資料表")]
[Index(nameof(TenantId), nameof(Name), Name = "uq_cross_tenant_roles_tenant_name", IsUnique = true)]
public class CrossTenantRoleEntityModel : AuditableEntityModel
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

    /// <summary> 角色名稱 </summary>
    [Column("name")]
    [Comment("角色名稱")]
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary> 是否要求使用多因素驗證登入 </summary>
    [Column("multi_factor_required")]
    [Comment("是否要求使用多因素驗證登入")]
    [Required]
    public bool MultiFactorRequired { get; set; } = true;

    /// <summary> 系統預設角色 </summary>
    [Column("is_system_default")]
    [Comment("系統預設角色")]
    [Required]
    public bool IsSystemDefault { get; set; }

    /// <summary> 用戶數量 </summary>
    [Column("user_count")]
    [Comment("用戶數量")]
    [Required]
    public int UserCount { get; set; }

    /// <summary> 租戶 </summary>
    public virtual CrossTenantTenantEntityModel? Tenant { get; set; }

    /// <summary> 用戶角色對應集合 </summary>
    public virtual ICollection<CrossTenantRoleMappingEntityModel> RoleMappings { get; set; } = [];

    /// <summary> 角色權限集合 </summary>
    public virtual ICollection<CrossTenantRolePermissionEntityModel> RolePermissions { get; set; } = [];
}
