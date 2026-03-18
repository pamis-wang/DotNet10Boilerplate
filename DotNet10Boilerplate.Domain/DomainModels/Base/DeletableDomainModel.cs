using DotNet10Boilerplate.Domain.DomainContracts.Base;

namespace DotNet10Boilerplate.Domain.DomainModels.Base;

/// <summary> 可刪除基礎領域模型，包含軟刪除相關欄位 </summary>
public abstract class DeletableDomainModel : AuditableDomainModel, IDeletableDomainModel
{
    /// <summary> 刪除時間 </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary> 刪除人員 </summary>
    public string? DeletedBy { get; set; }
}
