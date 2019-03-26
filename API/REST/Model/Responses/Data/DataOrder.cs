using API.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Open order data
    /// </summary>
    class DataOrder : DataBase
    {
        /// <summary>
        /// Bitsgap order id
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string GUID { get; set; }

        /// <summary>
        /// Market order id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }

        /// <summary>
        /// Last update time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("uts")]
        public decimal Time { get; set; }

        /// <summary>
        /// Bitsgap pair
        /// </summary>
        [JsonProperty("pair")]
        public string Pair { get; set; }

        /// <summary>
        /// Order side
        /// </summary>
        [JsonProperty("side")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSide Side { get; set; }

        /// <summary>
        /// Order type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType Type { get; set; }

        /// <summary>
        /// Remaining order amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Order placement price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Order state
        /// </summary>
        [JsonProperty("state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderState State { get; set; }

        /// <summary>
        /// Initial order amount
        /// </summary>
        [JsonProperty("amount_init", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInit { get; set; }

        /// <summary>
        /// Execution price
        /// </summary>
        [JsonProperty("price_avg", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceAvg { get; set; }

        /// <summary>
        /// GUID to track an order placed
        /// </summary>
        [JsonProperty("api_guid", NullValueHandling = NullValueHandling.Ignore)]
        public string API_GUID { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonIgnore]
        public string ErrorMessage { get; set; }
    }
}
