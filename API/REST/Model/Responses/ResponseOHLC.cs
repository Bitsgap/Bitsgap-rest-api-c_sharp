using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on open-high-low-close price and volume
    /// </summary>
    class ResponseOHLC : ResponseBase
    {
        /// <summary>
        /// Open-high-low-close price and volume of buying and selling at 1 minute intervals
        /// </summary>
        [JsonProperty("data")]
        public new List<DataOHLC> Data { get; set; }
    }
}
