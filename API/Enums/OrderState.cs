using System.Runtime.Serialization;

namespace API.Enums
{
    /// <summary>
    /// Order status in the system
    /// </summary>
    public enum OrderState : short
    {
        /// <summary>
        /// New record, used for bitsgap   
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Opens
        /// </summary>
        [EnumMember(Value = "opens")]
        Opens,

        /// <summary>
        /// Opens error
        /// </summary>
        [EnumMember(Value = "opens.error")]
        OpensError,

        /// <summary>
        /// Opened with REST on the market, used for bitsgap   
        /// </summary>
        [EnumMember(Value = "opened.rest")]
        OpenedRest,

        /// <summary>
        /// Opened
        /// </summary>
        [EnumMember(Value = "opened")]
        Opened,

        /// <summary>
        /// Opened and partially completed
        /// </summary>
        [EnumMember(Value = "opened.partial")]
        OpenedPartial,

        /// <summary>
        /// Closing
        /// </summary>
        [EnumMember(Value = "closing")]
        Closing,

        /// <summary>
        /// Сlosing error
        /// </summary>
        [EnumMember(Value = "closing.error")]
        ClosingError,

        /// <summary>
        /// Closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,

        /// <summary>
        /// Closed, but partially completed
        /// </summary>
        [EnumMember(Value = "closed.partial")]
        ClosedPartial,

        /// <summary>
        /// Filled
        /// </summary>
        [EnumMember(Value = "filled")]
        Filled,

        /// <summary>
        /// Demo moved
        /// </summary>
        [EnumMember(Value = "move")]
        DemoMoved,
    }
}
