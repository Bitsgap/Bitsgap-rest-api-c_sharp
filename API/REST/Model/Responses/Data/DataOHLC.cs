using Newtonsoft.Json;
using System;

namespace API.REST.Model.Responses.Data
{
    /// <summary>
    /// Open-high-low-close price and volume of buying and selling at 1 minute intervals
    /// </summary>
    class DataOHLC : DataBase
    {
        /// <summary>
        /// Record time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("time")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Record time in DateTimeOffset and local time
        /// </summary>
        [JsonProperty("dt")]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Opening price
        /// </summary>
        [JsonProperty("open")]
        public decimal Open { get; set; }

        /// <summary>
        /// High price
        /// </summary>
        [JsonProperty("high")]
        public decimal High { get; set; }

        /// <summary>
        /// Low price
        /// </summary>
        [JsonProperty("low")]
        public decimal Low { get; set; }

        /// <summary>
        /// Closing price
        /// </summary>
        [JsonProperty("close")]
        public decimal Close { get; set; }

        /// <summary>
        /// Volume of buying and selling
        /// </summary>
        [JsonProperty("volume")]
        public DataOHLCVolume Volume { get; set; }
    }

    /// <summary>
    /// Volume of buying and selling
    /// </summary>
    class DataOHLCVolume
    {
        /// <summary>
        /// Buying volume
        /// </summary>
        [JsonProperty("buy")]
        public decimal Buy { get; set; }

        /// <summary>
        /// Selling volume
        /// </summary>
        [JsonProperty("sell")]
        public decimal Sell { get; set; }
    }
}
