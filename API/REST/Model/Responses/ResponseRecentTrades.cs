using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on recent trades
    /// </summary>
    class ResponseRecentTrades : ResponseBase
    {
        /// <summary>
        /// Latest deals
        /// </summary>
        [JsonProperty("data")]
        public new List<DataRecentTrade> Data { get; set; }
    }
}
