using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Orderbook
    /// </summary>
    class DataOrderbook : DataBase
    {
        /// <summary>
        /// Orderbook asks
        /// </summary>
        [JsonProperty("asks")]
        public Dictionary<string, decimal> ASKs { get; set; }

        /// <summary>
        /// Orderbook bids
        /// </summary>
        [JsonProperty("bids")]
        public Dictionary<string, decimal> BIDs { get; set; }
    }
}
