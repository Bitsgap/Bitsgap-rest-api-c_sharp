using API.REST.Model.Responses.Data;
using Newtonsoft.Json;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on order place, cancel, move
    /// </summary>
    class ResponseOrderResult : ResponseBase
    {
        /// <summary>
        /// Order data
        /// </summary>
        [JsonProperty("data")]
        public new DataOrder Data { get; set; }
    }
}
