using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Balances
    /// </summary>
    class DataBalances : DataBase
    {
        /// <summary>
        /// Last update time for the market, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("uts")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Last update time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Available balance for all data
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AvailableBalance { get => Available; set => Available = value; }

        /// <summary>
        /// Available balance for single request
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Available { get; set; }

        /// <summary>
        /// Total balance
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Total { get; set; }
    }
}
