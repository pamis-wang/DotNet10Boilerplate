using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser;

/// <summary> 用戶登入方式領域模型 </summary>
public class SingleTenantUserLoginDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 用戶唯一編號 </summary>
    public Guid UserId { get; set; }

    /// <summary> 登入方式 </summary>
    public LoginMethodDomainEnum LoginMethod { get; set; }

    /// <summary> 本地登入識別值（帳號 / 信箱 / 電話），僅 Local 登入使用 </summary>
    public string? LoginIdentifier { get; set; }

    /// <summary> 雜湊密碼，僅 Local 登入使用 </summary>
    public string? PasswordHash { get; set; }

    /// <summary> 外部提供者的唯一識別碼，SSO 登入使用 </summary>
    public string? ProviderKey { get; set; }

    /// <summary> 是否重置密碼，僅 Local 登入使用 </summary>
    public bool IsPasswordReset { get; set; }

    /// <summary> 帳戶鎖定結束時間，僅 Local 登入使用 </summary>
    public DateTimeOffset? AccountLockedUntil { get; set; }

    /// <summary> 登入失敗次數，僅 Local 登入使用 </summary>
    public int LoginFailedCount { get; set; }

    /// <summary> 用戶 </summary>
    public SingleTenantUserDomainModel? User { get; set; }
}
