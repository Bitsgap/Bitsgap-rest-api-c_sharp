using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on markets and pairs
    /// </summary>
    class ResponseMarketsPairs : ResponseBase
    {
        /// <summary>
        /// Markets and pairs
        /// </summary>
        [JsonProperty("data")]
        public new Dictionary<string, List<string>> Data { get; set; }
    }
}
