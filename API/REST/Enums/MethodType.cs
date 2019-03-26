using System.Runtime.Serialization;

namespace API.REST.Enums
{
    /// <summary>
    /// Types of REST API methods and their endpoints
    /// </summary>
    enum MethodType : short
    {
        /// <summary>
        /// Get a list of markets and pairs
        /// </summary>
        [EnumMember(Value = "markets")]
        MarketsPairs,

        /// <summary>
        /// Get current ask and bid price
        /// </summary>
        [EnumMember(Value = "last-price")]
        LastPrice,

        /// <summary>
        /// Get orderbook
        /// </summary>
        [EnumMember(Value = "order-book")]
        Orderbook,

        /// <summary>
        /// Get open-high-low-close price and volume of buying and selling at 1 minute intervals
        /// </summary>
        [EnumMember(Value = "ohlc")]
        OHLC,

        /// <summary>
        /// Get latest deals
        /// </summary>
        [EnumMember(Value = "recent-trades")]
        RecentTrades,

        /// <summary>
        /// Get a list of API-keys for exchanges
        /// </summary>
        [EnumMember(Value = "keys")]
        APIKeys,

        /// <summary>
        /// Get user's balances
        /// </summary>
        [EnumMember(Value = "balance")]
        Balances,

        /// <summary>
        /// Get user's demo balances
        /// </summary>
        [EnumMember(Value = @"demo/balance")]
        DemoBalances,

        /// <summary>
        /// Get user's open orders
        /// </summary>
        [EnumMember(Value = @"orders/open")]
        Orders,

        /// <summary>
        /// Get user's demo open orders
        /// </summary>
        [EnumMember(Value = @"demo/orders/open")]
        DemoOrders,

        /// <summary>
        ///  last 20 Get user's deals
        /// </summary>
        [EnumMember(Value = @"orders/history")]
        Deals,

        /// <summary>
        /// Get last 20 user's demo deals
        /// </summary>
        [EnumMember(Value = @"demo/orders/history")]
        DemoDeals,

        /// <summary>
        /// Get last 200 user's messages
        /// </summary>
        [EnumMember(Value = "messages")]
        Messages,

        /// <summary>
        /// Place an order on the real market
        /// </summary>
        [EnumMember(Value = @"orders/add")]
        OrderPlace,

        /// <summary>
        /// Cancel an order on the real market
        /// </summary>
        [EnumMember(Value = @"orders/cancel")]
        OrderCancel,

        /// <summary>
        /// Moving an order on the real market
        /// </summary>
        [EnumMember(Value = @"orders/move")]
        OrderMove,

        /// <summary>
        /// Place an order on the demo market
        /// </summary>
        [EnumMember(Value = @"demo/orders/add")]
        DemoPlace,

        /// <summary>
        /// Cancel an order on the demo market
        /// </summary>
        [EnumMember(Value = @"demo/orders/cancel")]
        DemoCancel,

        /// <summary>
        /// Moving an order on the demo market
        /// </summary>
        [EnumMember(Value = @"demo/orders/move")]
        DemoMove,
    }
}
