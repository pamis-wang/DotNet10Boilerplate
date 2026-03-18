using Dotnet10Boilerplate.Infrastructure.MainEntityModels.Base;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet10Boilerplate.Infrastructure.MainEntityModels.MultiTenantUser;

/// <summary> 多租戶用戶登入方式實體模型 </summary>
[Table("multi_tenant_user_logins")]
[Comment("多租戶用戶登入方式資料表")]
[Index(nameof(TenantId), nameof(UserId), nameof(LoginMethod), Name = "uq_multi_tenant_user_logins_tenant_user_method", IsUnique = true)]
public class MultiTenantUserLoginEntityModel : AuditableEntityModel
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

    /// <summary> 用戶唯一編號 </summary>
    [Column("user_id")]
    [Comment("用戶唯一編號")]
    [Required]
    public Guid UserId { get; set; }

    /// <summary> 登入方式 </summary>
    [Column("login_method")]
    [Comment("登入方式")]
    [Required]
    public LoginMethodEntityEnum LoginMethod { get; set; }

    /// <summary> 本地登入識別值（帳號 / 信箱 / 電話），僅 Local 登入使用 </summary>
    [Column("login_identifier")]
    [Comment("本地登入識別值（帳號 / 信箱 / 電話），僅 Local 登入使用")]
    public string? LoginIdentifier { get; set; }

    /// <summary> 外部提供者的唯一識別碼，SSO 登入使用 </summary>
    [Column("provider_key")]
    [Comment("外部提供者的唯一識別碼，SSO 登入使用")]
    public string? ProviderKey { get; set; }

    /// <summary> 雜湊密碼，僅 Local 登入使用 </summary>
    [Column("password_hash")]
    [Comment("雜湊密碼，僅 Local 登入使用")]
    public string? PasswordHash { get; set; }

    /// <summary> 是否重置密碼，僅 Local 登入使用 </summary>
    [Column("is_password_reset")]
    [Comment("是否重置密碼，僅 Local 登入使用")]
    [Required]
    public bool IsPasswordReset { get; set; }

    /// <summary> 帳戶鎖定結束時間，僅 Local 登入使用 </summary>
    [Column("account_locked_until")]
    [Comment("帳戶鎖定結束時間，僅 Local 登入使用")]
    public DateTimeOffset? AccountLockedUntil { get; set; }

    /// <summary> 登入失敗次數，僅 Local 登入使用 </summary>
    [Column("login_failed_count")]
    [Comment("登入失敗次數，僅 Local 登入使用")]
    [Required]
    public int LoginFailedCount { get; set; }

    /// <summary> 租戶 </summary>
    public virtual MultiTenantTenantEntityModel? Tenant { get; set; }

    /// <summary> 用戶 </summary>
    public virtual MultiTenantUserEntityModel? User { get; set; }
}
