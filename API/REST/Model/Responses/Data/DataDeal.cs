using API.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Deal data
    /// </summary>
    class DataDeal : DataBase
    {
        /// <summary>
        /// Market order id
        /// </summary>
        [JsonProperty("id")]
        public string OrderID { get; set; }

        /// <summary>
        /// Last update time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("time")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Last update time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Bitsgap pair
        /// </summary>
        [JsonProperty("pair")]
        public string Pair { get; set; }

        /// <summary>
        /// Order side
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderSide Side { get; set; }

        /// <summary>
        /// Executed order amount
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Order placement price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Order type
        /// </summary>
        [JsonProperty("order_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderType Type { get; set; }

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
        /// Price of partial execution
        /// </summary>
        [JsonProperty("price_avg", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceAvg { get; set; }

        /// <summary>
        /// Creation time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Created { get; set; }

        /// <summary>
        /// Last modified time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Last { get; set; }
    }
}
