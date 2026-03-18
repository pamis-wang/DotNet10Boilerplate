using System.ComponentModel;

namespace DotNet10Boilerplate.Domain.DomainModels.Base;

/// <summary> 登入方式 </summary>
public enum LoginMethodDomainEnum
{
    /// <summary> 未知類型 </summary>
    [Description("未知類型")] Unknown = 0,

    /// <summary> 文字帳號 + 密碼 </summary>
    [Description("文字帳號 + 密碼")] LocalUsername = 1,

    /// <summary> 電子信箱 + 密碼 </summary>
    [Description("電子信箱 + 密碼")] LocalEmail = 2,

    /// <summary> 電話號碼 + 密碼 </summary>
    [Description("電話號碼 + 密碼")] LocalPhone = 3,

    /// <summary> 電話號碼 + OTP 簡訊驗證 </summary>
    [Description("電話號碼 + OTP 簡訊驗證")] LocalPhoneOtp = 4,

    /// <summary> 電子信箱 + OTP 驗證碼 </summary>
    [Description("電子信箱 + OTP 驗證碼")] LocalEmailOtp = 5,

    /// <summary> Google 登入 </summary>
    [Description("Google 登入")] Google = 6,

    /// <summary> Apple 登入 </summary>
    [Description("Apple 登入")] Apple = 7,

    /// <summary> Microsoft / Azure AD 登入 </summary>
    [Description("Microsoft / Azure AD 登入")] Microsoft = 8,

    /// <summary> LINE 登入 </summary>
    [Description("LINE 登入")] Line = 9,
}
