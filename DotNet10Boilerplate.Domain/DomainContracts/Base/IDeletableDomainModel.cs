namespace DotNet10Boilerplate.Domain.DomainContracts.Base;

/// <summary> 基礎審計領域模型介面，定義共用的時間戳記和操作人員屬性 </summary>
public interface IDeletableDomainModel
{
    /// <summary> 刪除時間 </summary>
    public DateTimeOffset? DeletedAt { get; set; }

    /// <summary> 刪除人員 </summary>
    public string? DeletedBy { get; set; }
}