using DotNet10Boilerplate.Domain.DomainModels.Base;
using DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser.Permission;

namespace DotNet10Boilerplate.Domain.DomainModels.SingleTenantUser;

/// <summary> 用戶領域模型 </summary>
public class SingleTenantUserDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 帳號 </summary>
    public string Account { get; set; } = string.Empty;

    /// <summary> 電子信箱 </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary> 完整姓名 </summary>
    public string? FullName { get; set; }

    /// <summary> 行動電話 </summary>
    public string? MobilePhone { get; set; }

    /// <summary> 公司電話 </summary>
    public string? OfficePhone { get; set; }

    /// <summary> 系統預設角色 </summary>
    public bool IsSystemDefault { get; set; }

    /// <summary> 是否停用 </summary>
    public bool IsDisabled { get; set; }

    /// <summary> 是否要求多因素驗證登入 </summary>
    public bool MultiFactorRequired { get; set; }

    /// <summary> 是否啟用多因素驗證登入 </summary>
    public bool MultiFactorEnabled { get; set; }

    /// <summary> 記住登入 </summary>
    public string? RememberToken { get; set; }

    /// <summary> 帳號啟用時間 </summary>
    public DateTimeOffset? ActivateTime { get; set; }

    /// <summary> 最後登入 </summary>
    public DateTimeOffset? LastLoginTime { get; set; }

    /// <summary> 後台用戶角色對應資料表 </summary>
    public IEnumerable<SingleTenantRoleMappingDomainModel> RoleMappings { get; set; } = [];

    /// <summary> 登入方式集合 </summary>
    public IEnumerable<SingleTenantUserLoginDomainModel> UserLogins { get; set; } = [];
}
