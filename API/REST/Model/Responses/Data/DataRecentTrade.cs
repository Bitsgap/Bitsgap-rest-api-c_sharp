using Newtonsoft.Json;
using System;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Latest deal data
    /// </summary>
    class DataRecentTrade : DataBase
    {
        /// <summary>
        /// Record time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("u")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Record time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Deal side
        /// </summary>
        [JsonProperty("s")]
        public string Side { get; set; }

        /// <summary>
        /// Deal amount
        /// </summary>
        [JsonProperty("am")]
        public string Amount { get; set; }

        /// <summary>
        /// Deal price
        /// </summary>
        [JsonProperty("p")]
        public string Price { get; set; }
    }
}
