using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.SingleTenantUser.Permission;

/// <summary> 用戶可用資源定義實體模型 </summary>
[Table("single_tenant_resources")]
[Comment("用戶可用資源定義資料表")]
[Index(nameof(ParentId), Name = "ix_single_tenant_resources_parent_id")]
public class SingleTenantResourceEntityModel : AuditableEntityModel
{
    /// <summary> 唯一編號 </summary>
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Comment("唯一編號")]
    [Required]
    public Guid Id { get; set; }

    /// <summary> 父級資源ID </summary>
    [Column("parent_id")]
    [Comment("父級資源ID")]
    public Guid? ParentId { get; set; }

    /// <summary> 資源層級 (1:一層, 2:二層, 3:三層) </summary>
    [Column("level")]
    [Comment("資源層級 (1:一層, 2:二層, 3:三層)")]
    [Required]
    public int Level { get; set; } = 0;

    /// <summary> 資源名稱 </summary>
    [Column("resource_name")]
    [Comment("資源名稱")]
    [Required]
    public string ResourceName { get; set; } = string.Empty;

    /// <summary> 顯示順序 </summary>
    [Column("display_order")]
    [Comment("顯示順序")]
    [Required]
    public int DisplayOrder { get; set; }

    /// <summary> 是否啟用 </summary>
    [Column("is_enabled")]
    [Comment("是否啟用")]
    [Required]
    public bool IsEnabled { get; set; }

    /// <summary> 角色權限集合 </summary>
    public virtual ICollection<SingleTenantRolePermissionEntityModel> RolePermissions { get; set; } = [];
}
