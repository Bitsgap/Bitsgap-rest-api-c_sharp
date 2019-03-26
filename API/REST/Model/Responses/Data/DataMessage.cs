using Newtonsoft.Json;
using System;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Message data
    /// </summary>
    class DataMessage : DataBase
    {
        /// <summary>
        /// Message time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("t")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Message time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Message Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Type of system
        /// </summary>
        [JsonProperty("trade")]
        public string SysType { get; set; }

        /// <summary>
        /// Message text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
