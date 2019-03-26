using API.REST.Model.Responses.Data;
using Newtonsoft.Json;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on balance
    /// </summary>
    class ResponseBalance : ResponseBase
    {
        /// <summary>
        /// User's balances for market
        /// </summary>
        [JsonProperty("data")]
        public new DataBalances Data { get; set; }
    }
}
