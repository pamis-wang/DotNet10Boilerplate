using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser.Permission;

/// <summary> 跨租戶用戶角色對應實體模型 </summary>
/// <remarks> TenantId 與 TenantMember 的 TenantId 對應 </remarks>
[Table("cross_tenant_role_mappings")]
[Comment("跨租戶用戶角色對應資料表")]
[PrimaryKey(nameof(TenantId), nameof(UserId), nameof(RoleId))]
public class CrossTenantRoleMappingEntityModel : AuditableEntityModel
{
    /// <summary> 租戶唯一編號 </summary>
    [Column("tenant_id")]
    [Comment("租戶唯一編號")]
    [Required]
    public Guid TenantId { get; set; }

    /// <summary> 用戶唯一編號 </summary>
    [Column("user_id")]
    [Comment("用戶唯一編號")]
    [Required]
    public Guid UserId { get; set; }

    /// <summary> 角色唯一編號 </summary>
    [Column("role_id")]
    [Comment("角色唯一編號")]
    [Required]
    public Guid RoleId { get; set; }

    /// <summary> 用戶 </summary>
    public virtual CrossTenantUserEntityModel? User { get; set; }

    /// <summary> 角色 </summary>
    public virtual CrossTenantRoleEntityModel? Role { get; set; }
}
