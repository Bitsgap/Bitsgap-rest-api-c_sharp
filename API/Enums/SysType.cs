using System.Runtime.Serialization;

namespace API.Enums
{
    /// <summary>
    /// Types of systems
    /// </summary>
    public enum SysType : short
    {
        [EnumMember(Value = null)]
        Empty,

        /// <summary>
        /// Real markets
        /// </summary>
        [EnumMember(Value = "real")]
        Real,

        /// <summary>
        /// Demo markets
        /// </summary>
        [EnumMember(Value = "demo")]
        Demo,
    }
}
