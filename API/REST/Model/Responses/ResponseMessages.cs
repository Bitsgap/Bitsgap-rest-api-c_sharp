using API.REST.Model.Responses.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Response on messages
    /// </summary>
    class ResponseMessages : ResponseBase
    {
        /// <summary>
        /// User's messages
        /// </summary>
        [JsonProperty("data")]
        public new List<DataMessage> Data { get; set; }
    }
}
