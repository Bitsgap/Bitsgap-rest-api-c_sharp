using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on last 20 deals
    /// </summary>
    class ResponseDeals : ResponseBase
    {
        /// <summary>
        ///  Last 20 user's deals
        /// </summary>
        [JsonProperty("data")]
        public new List<DataDeal> Data { get; set; }
    }
}
