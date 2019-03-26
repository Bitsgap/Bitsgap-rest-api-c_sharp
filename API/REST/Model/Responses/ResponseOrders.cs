using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on open orders
    /// </summary>
    class ResponseOrders : ResponseBase
    {
        /// <summary>
        /// User's open orders
        /// </summary>
        [JsonProperty("data")]
        public new List<DataOrder> Data { get; set; }
    }
}
