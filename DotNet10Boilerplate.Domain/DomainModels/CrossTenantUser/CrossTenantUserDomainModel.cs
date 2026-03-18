using DotNet10Boilerplate.Domain.DomainModels.Base;
using DotNet10Boilerplate.Domain.DomainModels.CrossTenantUser.Permission;

namespace DotNet10Boilerplate.Domain.DomainModels.CrossTenantUser;

/// <summary> 跨租戶用戶領域模型（同一帳號可加入多個租戶） </summary>
public class CrossTenantUserDomainModel : AuditableDomainModel
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

    /// <summary> 租戶成員關聯（此帳號所屬的所有租戶） </summary>
    public IEnumerable<CrossTenantTenantMemberDomainModel> TenantMembers { get; set; } = [];

    /// <summary> 用戶角色對應資料表 </summary>
    public IEnumerable<CrossTenantRoleMappingDomainModel> RoleMappings { get; set; } = [];

    /// <summary> 登入方式集合 </summary>
    public IEnumerable<CrossTenantUserLoginDomainModel> UserLogins { get; set; } = [];
}
