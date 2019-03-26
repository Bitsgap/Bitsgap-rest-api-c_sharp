using API.Enums;

namespace API.Model
{
    /// <summary>
    /// Order info
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Market order id
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// Bitsgap pair
        /// </summary>
        public string Pair { get; set; }

        /// <summary>
        /// Order side
        /// </summary>
        public OrderSide Side { get; set; }

        /// <summary>
        /// Order type
        /// </summary>
        public OrderType Type { get; set; }

        /// <summary>
        /// Order amount
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Order price
        /// </summary>
        public string Price { get; set; }
    }
}