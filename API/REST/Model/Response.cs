using API.REST.Enums;
using API.REST.Model.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace API.REST.Model
{
    /// <summary>
    /// Class for response
    /// </summary>
    class Response
    {
        #region public property

        /// <summary>
        /// Request params
        /// </summary>
        public Request RequestParams { get; set; }

        /// <summary>
        /// Request execution flag
        /// </summary>
        public bool IsExecRequest { get; set; }

        /// <summary>
        /// Request status code
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Request result in string
        /// </summary>
        public string RetMessage { get; set; }

        /// <summary>
        /// Success execution flag
        /// </summary>
        public bool IsSuccessfully { get => ResponseObject == null ? false : ResponseObject.IsSuccessfully; }

        /// <summary>
        /// Request result in class
        /// </summary>
        public ResponseBase ResponseObject { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="data">Request params</param>
        public Response(Request data)
        {
            // save request params
            RequestParams = data;
        }

        #endregion

        #region public methods

        /// <summary>
        /// Parse request result
        /// </summary>
        public void Parse()
        {
            if (StatusCode != HttpStatusCode.OK) return;

            ResponseObject = JsonConvert.DeserializeObject<ResponseBase>(RetMessage);

            if (ResponseObject.IsSuccessfully)
            {
                switch (RequestParams.Type)
                {
                    case MethodType.MarketsPairs:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseMarketsPairs>(RetMessage);
                        break;
                    case MethodType.LastPrice:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseLastPrice>(RetMessage);
                        break;
                    case MethodType.Orderbook:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseOrderbook>(RetMessage);
                        break;
                    case MethodType.OHLC:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseOHLC>(RetMessage);
                        break;
                    case MethodType.RecentTrades:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseRecentTrades>(RetMessage);
                        break;
                    case MethodType.APIKeys:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseAPIKeys>(RetMessage);
                        break;
                    case MethodType.Balances:
                    case MethodType.DemoBalances:
                        if (RequestParams.Params.ContainsKey("market"))
                        {
                            ResponseObject = JsonConvert.DeserializeObject<ResponseBalance>(RetMessage);
                        }
                        else
                        {
                            ResponseObject = JsonConvert.DeserializeObject<ResponseBalances>(RetMessage);
                        }
                        break;
                    case MethodType.Orders:
                    case MethodType.DemoOrders:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseOrders>(RetMessage);
                        break;
                    case MethodType.Deals:
                    case MethodType.DemoDeals:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseDeals>(RetMessage);
                        break;
                    case MethodType.Messages:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseMessages>(RetMessage);
                        break;
                    case MethodType.OrderPlace:
                    case MethodType.OrderCancel:
                    case MethodType.OrderMove:
                    case MethodType.DemoPlace:
                    case MethodType.DemoCancel:
                    case MethodType.DemoMove:
                        ResponseObject = JsonConvert.DeserializeObject<ResponseOrderResult>(RetMessage);
                        break;
                    default:
                        throw new InvalidOperationException("Unrealized state: " + RequestParams.Type.ToString());
                }
            }
        }

        /// <summary>
        /// Format to log
        /// </summary>
        public string ToLog(int LogMessSize)
        {
            var dict = new Dictionary<string, dynamic> {
                { "exec", IsExecRequest },
                { "code", string.Format("{0} {1}", (int)StatusCode, StatusCode) },
                { "success", IsSuccessfully },
                { "type", RequestParams.Type.ToString() },
                { "params", RequestParams.ToLog() },
            };

            if (IsSuccessfully)
            {
                var dynamic_data = JsonConvert.DeserializeObject<ResponseBase>(RetMessage);
                dict.Add("result", dynamic_data.ToLog());
            }
            else
            {
                dict.Add("error", RetMessage);
            }

            var str = JsonConvert.SerializeObject(dict);
            str = str.Length > LogMessSize ? str.Substring(1, LogMessSize) + "..." : str;
            return str;
        }

        #endregion
    }
}
