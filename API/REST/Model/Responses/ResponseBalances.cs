using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on all balances
    /// </summary>
    class ResponseBalances : ResponseBase
    {
        /// <summary>
        /// All user's balances
        /// </summary>
        [JsonProperty("data")]
        public new Dictionary<string, DataBalances> Data { get; set; }
    }
}
