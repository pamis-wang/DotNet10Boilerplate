using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser.Permission;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.CrossTenantUser;

/// <summary> 跨租戶用戶實體模型（同一帳號可加入多個租戶） </summary>
[Table("cross_tenant_users")]
[Comment("跨租戶用戶資料表")]
[Index(nameof(Account), Name = "uq_cross_tenant_users_account", IsUnique = true)]
[Index(nameof(Email), Name = "uq_cross_tenant_users_email", IsUnique = true)]
public class CrossTenantUserEntityModel : AuditableEntityModel
{
    /// <summary> 唯一編號 </summary>
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Comment("唯一編號")]
    [Required]
    public Guid Id { get; set; }

    /// <summary> 帳號 </summary>
    [Column("account")]
    [Comment("帳號")]
    [Required]
    public string Account { get; set; } = string.Empty;

    /// <summary> 電子信箱 </summary>
    [Column("email")]
    [Comment("電子信箱")]
    [Required]
    public string Email { get; set; } = string.Empty;

    /// <summary> 完整姓名 </summary>
    [Column("full_name")]
    [Comment("完整姓名")]
    public string? FullName { get; set; }

    /// <summary> 行動電話 </summary>
    [Column("mobile_phone")]
    [Comment("行動電話")]
    public string? MobilePhone { get; set; }

    /// <summary> 公司電話 </summary>
    [Column("office_phone")]
    [Comment("公司電話")]
    public string? OfficePhone { get; set; }

    /// <summary> 是否停用 </summary>
    [Column("is_disabled")]
    [Comment("是否停用")]
    [Required]
    public bool IsDisabled { get; set; }

    /// <summary> 是否要求多因素驗證登入 </summary>
    [Column("multi_factor_required")]
    [Comment("是否要求多因素驗證登入")]
    [Required]
    public bool MultiFactorRequired { get; set; }

    /// <summary> 是否啟用多因素驗證登入 </summary>
    [Column("multi_factor_enabled")]
    [Comment("是否啟用多因素驗證登入")]
    [Required]
    public bool MultiFactorEnabled { get; set; }

    /// <summary> 記住登入 </summary>
    [Column("remember_token")]
    [Comment("記住登入")]
    public string? RememberToken { get; set; }

    /// <summary> 帳號啟用時間 </summary>
    [Column("activate_time")]
    [Comment("帳號啟用時間")]
    public DateTimeOffset? ActivateTime { get; set; }

    /// <summary> 最後登入 </summary>
    [Column("last_login_time")]
    [Comment("最後登入")]
    public DateTimeOffset? LastLoginTime { get; set; }

    /// <summary> 租戶成員關聯（此帳號所屬的所有租戶） </summary>
    public virtual ICollection<CrossTenantTenantMemberEntityModel> TenantMembers { get; set; } = [];

    /// <summary> 用戶角色對應集合 </summary>
    public virtual ICollection<CrossTenantRoleMappingEntityModel> RoleMappings { get; set; } = [];

    /// <summary> 登入方式集合 </summary>
    public virtual ICollection<CrossTenantUserLoginEntityModel> UserLogins { get; set; } = [];
}
