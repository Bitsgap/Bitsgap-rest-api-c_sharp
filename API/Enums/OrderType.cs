using System.Runtime.Serialization;

namespace API.Enums
{
    /// <summary>
    /// Order type
    /// </summary>
    public enum OrderType : short
    {
        [EnumMember(Value = "limit")]
        Limit,

        [EnumMember(Value = "market")]
        Market,
    }
}
