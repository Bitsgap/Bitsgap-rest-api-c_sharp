using Newtonsoft.Json;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Current ask and bid price
    /// </summary>
    class DataLastPrice : DataBase
    {
        /// <summary>
        /// Minimun ask
        /// </summary>
        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        /// <summary>
        /// Maximum bid
        /// </summary>
        [JsonProperty("bid")]
        public decimal Bid { get; set; }
    }
}
