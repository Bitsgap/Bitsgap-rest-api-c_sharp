using Newtonsoft.Json;
using System;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// API-key data
    /// </summary>
    class DataAPIKey : DataBase
    {
        /// <summary>
        /// Last check time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("uts")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Last check time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Public API-key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// API-key status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Error description
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
