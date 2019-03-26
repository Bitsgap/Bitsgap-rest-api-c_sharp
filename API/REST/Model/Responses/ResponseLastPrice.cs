using API.REST.Model.Responses.Data;
using Newtonsoft.Json;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on last price
    /// </summary>
    class ResponseLastPrice : ResponseBase
    {
        /// <summary>
        /// Current ask and bid price
        /// </summary>
        [JsonProperty("data")]
        public new DataLastPrice Data { get; set; }
    }
}
