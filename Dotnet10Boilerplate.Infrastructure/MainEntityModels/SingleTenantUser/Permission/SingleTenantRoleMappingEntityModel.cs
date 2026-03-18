using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.SingleTenantUser.Permission;

/// <summary> 用戶角色對應實體模型 </summary>
[Table("single_tenant_role_mappings")]
[Comment("用戶角色對應資料表")]
[PrimaryKey(nameof(UserId), nameof(RoleId))]
public class SingleTenantRoleMappingEntityModel : AuditableEntityModel
{
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
    public virtual SingleTenantUserEntityModel? User { get; set; }

    /// <summary> 角色 </summary>
    public virtual SingleTenantRoleEntityModel? Role { get; set; }
}
