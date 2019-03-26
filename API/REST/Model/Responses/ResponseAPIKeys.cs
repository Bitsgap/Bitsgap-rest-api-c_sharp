using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on API-keys
    /// </summary>
    class ResponseAPIKeys : ResponseBase
    {
        /// <summary>
        /// API-keys data
        /// </summary>
        [JsonProperty("data")]
        public new Dictionary<string, DataAPIKey> Data { get; set; }
    }
}
