using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace API.REST.Model.Responses
{
    /// <summary>
    /// Base class for response data
    /// </summary>
    class ResponseBase
    {
        /// <summary>
        /// Request successful
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessfully { get => Status == "ok"; }

        /// <summary>
        /// Request status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Response time, UTS with UTC+00:00
        /// </summary>
        [JsonProperty("time")]
        public decimal UTS { get; set; }

        /// <summary>
        /// Response time in DateTimeOffset and local time
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset Time { get => DateTimeOffset.FromUnixTimeMilliseconds((long)(UTS * 1000L)).ToLocalTime(); }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Raw data
        /// </summary>
        [JsonProperty("data")]
        public dynamic Data { get; set; }

        /// <summary>
        /// Format to log
        /// </summary>
        public Dictionary<string, dynamic> ToLog()
        {
            var dict = new Dictionary<string, dynamic> {
                { "status", Status },
                { "time", Time.ToString() },
            };

            if (IsSuccessfully)
            {
                if (Data != null)
                {
                    dict.Add("data", Data);
                }
            }
            else
            {
                dict.Add("message", Message);
            }

            return dict;
        }
    }
}
