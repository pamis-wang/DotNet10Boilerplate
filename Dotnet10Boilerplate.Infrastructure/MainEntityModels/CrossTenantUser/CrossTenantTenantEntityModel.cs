using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser.Permission;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser;

/// <summary> 跨租戶租戶實體模型 </summary>
[Table("cross_tenant_tenants")]
[Comment("跨租戶租戶資料表")]
[Index(nameof(Code), Name = "uq_cross_tenant_tenants_code", IsUnique = true)]
public class CrossTenantTenantEntityModel : AuditableEntityModel
{
    /// <summary> 唯一編號 </summary>
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Comment("唯一編號")]
    [Required]
    public Guid Id { get; set; }

    /// <summary> 租戶名稱 </summary>
    [Column("name")]
    [Comment("租戶名稱")]
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary> 租戶代碼（唯一，用於子網域或識別） </summary>
    [Column("code")]
    [Comment("租戶代碼（唯一，用於子網域或識別）")]
    [Required]
    public string Code { get; set; } = string.Empty;

    /// <summary> 是否啟用 </summary>
    [Column("is_enabled")]
    [Comment("是否啟用")]
    [Required]
    public bool IsEnabled { get; set; } = true;

    /// <summary> Logo 圖片網址 </summary>
    [Column("logo_url")]
    [Comment("Logo 圖片網址")]
    public string? LogoUrl { get; set; }

    /// <summary> 租戶成員集合 </summary>
    public virtual ICollection<CrossTenantTenantMemberEntityModel> Members { get; set; } = [];

    /// <summary> 角色集合 </summary>
    public virtual ICollection<CrossTenantRoleEntityModel> Roles { get; set; } = [];

    /// <summary> 資源集合 </summary>
    public virtual ICollection<CrossTenantResourceEntityModel> Resources { get; set; } = [];
}
