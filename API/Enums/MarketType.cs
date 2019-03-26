using System.Runtime.Serialization;

namespace API.Enums
{
    /// <summary>
    /// Markets
    /// </summary>
    public enum MarketType : short
    {
        [EnumMember(Value = null)]
        Empty,

        [EnumMember(Value = "kraken")]
        Kraken,
        [EnumMember(Value = "livecoin")]
        Livecoin,
        [EnumMember(Value = "poloniex")]
        Poloniex,
        [EnumMember(Value = "cex.io")]
        Cexio,
        [EnumMember(Value = "cryptopia")]
        Cryptopia,
        [EnumMember(Value = "therocktrading")]
        TheRockTrading,
        [EnumMember(Value = "exmo")]
        Exmo,
        [EnumMember(Value = "yobit")]
        Yobit,
        [EnumMember(Value = "bitfinex")]
        Bitfinex,
        [EnumMember(Value = "bitstamp")]
        Bitstamp,
        [EnumMember(Value = "binance")]
        Binance,
        [EnumMember(Value = "kucoin")]
        Kucoin,
        [EnumMember(Value = "gate.io")]
        Gateio,
        [EnumMember(Value = "bittrex")]
        Bittrex,
        [EnumMember(Value = "hitbtc")]
        HitBtc,
        [EnumMember(Value = "gdax")]
        Gdax,
        [EnumMember(Value = "huobi")]
        Huobi,
        [EnumMember(Value = "gemini")]
        Gemini,
        [EnumMember(Value = "okex")]
        Okex,
        [EnumMember(Value = "hadax")]
        Hadax,
        [EnumMember(Value = "idex")]
        Idex,
        [EnumMember(Value = "coinex")]
        Coinex,
        [EnumMember(Value = "zb.com")]
        ZBcom,
        [EnumMember(Value = "bit-z")]
        Bitz,
        [EnumMember(Value = "coinbene")]
        Coinbene,
        [EnumMember(Value = "lbank")]
        LBank,
        [EnumMember(Value = "quoinex")]
        Quoinex,
        [EnumMember(Value = "bibox")]
        Bibox,
        [EnumMember(Value = "ddex")]
        Ddex,
        [EnumMember(Value = "liquid")]
        Liquid,
        [EnumMember(Value = "bithumb")]
        Bithumb,
        [EnumMember(Value = "cobinhood")]
        Cobinhood,
        [EnumMember(Value = "coinbase pro")]
        CoinbasePro,
        [EnumMember(Value = "bitmex")]
        Bitmex,
    }
}
