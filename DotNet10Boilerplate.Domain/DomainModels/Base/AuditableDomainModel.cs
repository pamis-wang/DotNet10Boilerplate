namespace DotNet10Boilerplate.Domain.DomainModels.Base;

/// <summary> 基礎審計領域模型，包含共用的時間戳記和操作人員欄位 </summary>
public abstract class AuditableDomainModel 
{
    /// <summary> 新增時間 </summary>
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary> 新增人員 </summary>
    public string? CreatedBy { get; set; }

    /// <summary> 更新時間 </summary>
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary> 更新人員 </summary>
    public string? UpdatedBy { get; set; }
}
