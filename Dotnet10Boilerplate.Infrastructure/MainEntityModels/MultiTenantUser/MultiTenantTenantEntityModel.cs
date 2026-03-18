using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Dotnet10Boilerplate.Infrastructure.MainEntityModels.MultiTenantUser.Permission;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.MultiTenantUser;

/// <summary> 多租戶租戶實體模型 </summary>
[Table("multi_tenant_tenants")]
[Comment("多租戶租戶資料表")]
[Index(nameof(Code), Name = "uq_multi_tenant_tenants_code", IsUnique = true)]
public class MultiTenantTenantEntityModel : AuditableEntityModel
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

    /// <summary> 用戶集合 </summary>
    public virtual ICollection<MultiTenantUserEntityModel> Users { get; set; } = [];

    /// <summary> 角色集合 </summary>
    public virtual ICollection<MultiTenantRoleEntityModel> Roles { get; set; } = [];

    /// <summary> 資源集合 </summary>
    public virtual ICollection<MultiTenantResourceEntityModel> Resources { get; set; } = [];
}
