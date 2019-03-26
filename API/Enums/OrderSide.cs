using System.Runtime.Serialization;

namespace API.Enums
{
    /// <summary>
    /// Order side
    /// </summary>
    public enum OrderSide : short
    {
        [EnumMember(Value = "buy")]
        Buy,

        [EnumMember(Value = "sell")]
        Sell,
    }
}
