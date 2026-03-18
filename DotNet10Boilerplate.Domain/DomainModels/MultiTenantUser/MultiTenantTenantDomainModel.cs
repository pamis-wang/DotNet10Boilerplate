using DotNet10Boilerplate.Domain.DomainModels.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.MultiTenantUser;

/// <summary> 多租戶租戶領域模型 </summary>
public class MultiTenantTenantDomainModel : AuditableDomainModel
{
    /// <summary> 唯一編號 </summary>
    public Guid Id { get; set; }

    /// <summary> 租戶名稱 </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary> 租戶代碼（唯一，用於子網域或識別） </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary> 是否啟用 </summary>
    public bool IsEnabled { get; set; } = true;

    /// <summary> Logo 圖片網址 </summary>
    public string? LogoUrl { get; set; }
}
