using API.REST.Model.Responses.Data;
using Newtonsoft.Json;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on orderbook
    /// </summary>
    class ResponseOrderbook : ResponseBase
    {
        /// <summary>
        /// Orderbook
        /// </summary>
        [JsonProperty("data")]
        public new DataOrderbook Data { get; set; }
    }
}
