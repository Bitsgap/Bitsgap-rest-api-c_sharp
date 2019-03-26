using API.Enums;
using API.Model;
using API.REST.Enums;
using API.REST.Model;
using API.REST.Model.Responses;
using API.REST.Model.Responses.Data;
using API.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;

namespace API.REST
{
    /// <summary>
    /// Use REST API
    /// </summary>
    class Rest
    {
        #region logger

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        #endregion

        #region private variables

        private const string DefaultUrl = @"https://bitsgap.com/api/v1/";

        private const int LogMessSize = 500;

        private readonly string url;
        private readonly string public_key;
        private readonly string private_key;

        private readonly HttpClient HttpClient;
        private TimeSpan Timeout = TimeSpan.FromSeconds(5);

        private static readonly string demo = ".demo";

        #endregion

        #region constructor/destructor

        public Rest(string public_key, string private_key, string url = null)
        {
            this.url = url ?? DefaultUrl;
            this.public_key = public_key ?? throw new ArgumentNullException("public_key");
            this.private_key = private_key ?? throw new ArgumentNullException("private_key");

            HttpClient = new HttpClient()
            {
                Timeout = Timeout
            };
        }

        ~Rest()
        {
            HttpClient?.Dispose();
        }

        #endregion

        #region public methods

        #region market data

        /// <summary>
        /// Get a list of markets and pairs
        /// </summary>
        public Dictionary<MarketType, List<string>> GetMarketsPairs()
        {
            Dictionary<MarketType, List<string>> result = null;

            // request formation
            var request = new Request(MethodType.MarketsPairs);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = new Dictionary<MarketType, List<string>>();

                var data = (response.ResponseObject as ResponseMarketsPairs)?.Data;

                // fill result
                foreach (var item in data)
                {
                    var market = EnumValue.GetEnum<MarketType>(item.Key);
                    if (market == MarketType.Empty)
                    {
                        logger.Error("Undeclared market value: {0}", item.Key);
                    }
                    else
                    {
                        result.Add(market, item.Value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get current ask and bid price
        /// </summary>
        public DataLastPrice GetLastPrice(MarketType market, string pair)
        {
            DataLastPrice result = null;

            // check params
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (string.IsNullOrWhiteSpace(pair)) throw new ArgumentNullException("pair");

            // request formation
            var request = new Request(MethodType.LastPrice);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("pair", pair);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseLastPrice)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get orderbook
        /// </summary>
        public DataOrderbook GetOrderbook(MarketType market, string pair)
        {
            DataOrderbook result = null;

            // check params
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (string.IsNullOrWhiteSpace(pair)) throw new ArgumentNullException("pair");

            // request formation
            var request = new Request(MethodType.Orderbook);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("pair", pair);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOrderbook)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get open-high-low-close price and volume of buying and selling at 1 minute intervals
        /// </summary>
        public List<DataOHLC> GetOHLC(MarketType market, string pair, decimal start, decimal end)
        {
            List<DataOHLC> result = null;

            // check params
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (string.IsNullOrWhiteSpace(pair)) throw new ArgumentNullException("pair");

            // request formation
            var request = new Request(MethodType.OHLC);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("pair", pair);
            request.Params.Add("start", start.ToString(CultureInfo.InvariantCulture));
            request.Params.Add("end", end.ToString(CultureInfo.InvariantCulture));
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOHLC)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get latest deals
        /// </summary>
        public List<DataRecentTrade> GetRecentTrades(MarketType market, string pair, int limit = 50)
        {
            List<DataRecentTrade> result = null;

            // check params
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (string.IsNullOrWhiteSpace(pair)) throw new ArgumentNullException("pair");
            limit = limit < 1 ? 50 : limit > 250 ? 250 : limit;

            // request formation
            var request = new Request(MethodType.RecentTrades);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("pair", pair);
            request.Params.Add("limit", limit.ToString(CultureInfo.InvariantCulture));
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseRecentTrades)?.Data;
            }

            return result;
        }

        #endregion

        #region user data

        /// <summary>
        /// Get a list of API-keys for exchanges
        /// </summary>
        public Dictionary<MarketType, DataAPIKey> GetAPIKeys()
        {
            Dictionary<MarketType, DataAPIKey> result = null;

            // request formation
            var request = new Request(MethodType.APIKeys);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = new Dictionary<MarketType, DataAPIKey>();

                var data = (response.ResponseObject as ResponseAPIKeys)?.Data;

                // fill result
                foreach (var item in data)
                {
                    var market = EnumValue.GetEnum<MarketType>(item.Key);
                    if (market == MarketType.Empty)
                    {
                        logger.Error("Undeclared market value: {0}", item.Key);
                    }
                    else
                    {
                        result.Add(market, item.Value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get user's balances
        /// </summary>
        /// <param name="type">Type of system</param>
        public Dictionary<MarketType, DataBalances> GetBalances(SysType type)
        {
            Dictionary<MarketType, DataBalances> result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.Balances) : new Request(MethodType.DemoBalances);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = new Dictionary<MarketType, DataBalances>();

                var data = (response.ResponseObject as ResponseBalances)?.Data;

                // fill result
                foreach (var item in data)
                {
                    string market_name = item.Key;
                    market_name = market_name.Replace(demo, string.Empty);
                    var market = EnumValue.GetEnum<MarketType>(market_name);

                    if (market == MarketType.Empty)
                    {
                        logger.Error("Undeclared market value: {0}", item.Key);
                    }
                    else
                    {
                        result.Add(market, item.Value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Get user's balance for exchange. Only real markets
        /// </summary>
        /// <param name="market">For exchange request directly</param>
        public DataBalances GetBalance(MarketType market)
        {
            DataBalances result = null;

            // check params
            if (market == MarketType.Empty) throw new ArgumentNullException("market");

            // request formation
            var request = new Request(MethodType.Balances);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseBalance)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get user's balances
        /// </summary>
        /// <param name="type">Type of system</param>
        /// <param name="market">Market</param>
        public List<DataOrder> GetOrders(SysType type, MarketType market)
        {
            List<DataOrder> result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");
            if (market == MarketType.Empty) throw new ArgumentNullException("market");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.Orders) : new Request(MethodType.DemoOrders);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOrders)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get user's last 20 deals
        /// </summary>
        /// <param name="type">Type of system</param>
        /// <param name="market">Market</param>
        public List<DataDeal> GetDeals(SysType type, MarketType market)
        {
            List<DataDeal> result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");
            if (market == MarketType.Empty) throw new ArgumentNullException("market");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.Deals) : new Request(MethodType.DemoDeals);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseDeals)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Get last 200 user's messages
        /// </summary>
        public List<DataMessage> GetMessages()
        {
            List<DataMessage> result = null;

            // request formation
            var request = new Request(MethodType.Messages);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseMessages)?.Data;
            }

            return result;
        }

        /// <summary>
        /// Place order
        /// </summary>
        /// <param name="type">Type of system</param>
        /// <param name="market">Market</param>
        /// <param name="order">Order data</param>
        /// <param name="api_guid">GUID to track an order placed</param>
        public DataOrder OrderPlace(SysType type, MarketType market, Order order, string api_guid = null)
        {
            DataOrder result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (order == null) throw new ArgumentNullException("order");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.OrderPlace) : new Request(MethodType.DemoPlace);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("pair", order.Pair);
            request.Params.Add("type", EnumValue.GetValue(order.Type));
            request.Params.Add("side", EnumValue.GetValue(order.Side));
            request.Params.Add("amount", order.Amount.ToString(CultureInfo.InvariantCulture));
            request.Params.Add("price", order.Price.ToString(CultureInfo.InvariantCulture));
            if (string.IsNullOrWhiteSpace(api_guid)) request.Params.Add("api_guid", api_guid);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOrderResult)?.Data;
            }
            else
            {
                string mess = string.Empty;

                if (string.IsNullOrWhiteSpace(response?.RetMessage))
                {
                    mess = "Empty error message";
                }
                else
                {
                    var res = JsonConvert.DeserializeObject<ResponseBase>(response?.RetMessage);
                    mess = res.Message;
                }

                result = new DataOrder
                {
                    ErrorMessage = mess
                };
            }

            return result;
        }

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="type">Type of system</param>
        /// <param name="market">Market</param>
        /// <param name="order">Order data</param>
        public DataOrder OrderCancel(SysType type, MarketType market, Order order)
        {
            DataOrder result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (order == null) throw new ArgumentNullException("order");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.OrderCancel) : new Request(MethodType.DemoCancel);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("id", order.OrderID);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOrderResult)?.Data;
            }
            else
            {
                string mess = string.Empty;

                if (string.IsNullOrWhiteSpace(response?.RetMessage))
                {
                    mess = "Empty error message";
                }
                else
                {
                    var res = JsonConvert.DeserializeObject<ResponseBase>(response?.RetMessage);
                    mess = res.Message;
                }

                result = new DataOrder
                {
                    ErrorMessage = mess
                };
            }

            return result;
        }


        /// <summary>
        /// Move order
        /// </summary>
        /// <param name="type">Type of system</param>
        /// <param name="market">Market</param>
        /// <param name="order">Order data</param>
        public DataOrder OrderMove(SysType type, MarketType market, Order order)
        {
            DataOrder result = null;

            // check params
            if (type == SysType.Empty) throw new ArgumentNullException("type");
            if (market == MarketType.Empty) throw new ArgumentNullException("market");
            if (order == null) throw new ArgumentNullException("order");

            // request formation
            var request = type == SysType.Real ? new Request(MethodType.OrderMove) : new Request(MethodType.DemoMove);
            request.Params.Add("market", EnumValue.GetValue(market));
            request.Params.Add("id", order.OrderID);
            request.Params.Add("price", order.Price);
            request.Prepare(public_key, private_key);

            // request execution
            var response = ExecQuery(request);

            // response analysis
            if (response.IsSuccessfully)
            {
                result = (response.ResponseObject as ResponseOrderResult)?.Data;
            }
            else
            {
                string mess = string.Empty;

                if (string.IsNullOrWhiteSpace(response?.RetMessage))
                {
                    mess = "Empty error message";
                }
                else
                {
                    var res = JsonConvert.DeserializeObject<ResponseBase>(response?.RetMessage);
                    mess = res.Message;
                }

                result = new DataOrder
                {
                    ErrorMessage = mess
                };
            }

            return result;
        }

        #endregion

        #endregion

        #region private methods

        /// <summary>
        /// Execute API method and parse result
        /// </summary>
        /// <param name="data">Request params</param>
        /// <returns>Request result</returns>
        public Response ExecQuery(Request data)
        {
            var result = new Response(data);

            try
            {
                using (var http_request = new HttpRequestMessage(HttpMethod.Post, url + EnumValue.GetValue(data.Type)))
                {
                    http_request.Content = new StringContent(data.AsRequestString(), Encoding.UTF8, "application/x-www-form-urlencoded");

                    using (var response = HttpClient.SendAsync(http_request).Result)
                    {
                        result.IsExecRequest = true;                                    // request completed
                        result.StatusCode = response.StatusCode;                        // status

                        using (var content = response.Content)
                        {
                            result.RetMessage = content.ReadAsStringAsync().Result;     // result
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Exception execute API request");
            }

            try
            {
                result.Parse();

                logger.Trace("Result: {0}", result.ToLog(LogMessSize));
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Exception parse response");
            }

            return result;
        }

        #endregion
    }
}
