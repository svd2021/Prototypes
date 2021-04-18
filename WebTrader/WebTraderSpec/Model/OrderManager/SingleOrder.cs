using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraderSpec.Model
{
    public class SingleOrder
    {
        public string Id { get; set; }                  // Unique OrderID. Can be long, GUID or any sort of string
        public DateTime TimeStamp { get; set; }         // UTC Date-Time stamp when order created.
        public bool Execute { get; set; }               // Indicates weather order is ready to be executed or not
        public string Product { get; set; }             // Product ID, like MSFT_US_USD_USD
        public string Ticker { get; set; }              // Ticker, like MSFT, AAPL etc.
        public string Exchange { get; set; }            // NYSE, NASDAQ, LSE etc.
        public string Currency { get; set; }            // USD, EUR, CNY
        public string OrderType { get; set; }           // MARKET, LIMIT, 
        public string AlgoStrategy { get; set; }		// NONE, VWAP, TWAP etc.
        public string AlgoParameter { get; set; }		// Additional algo parameters
        public string Side { get; set; }                // BUY, SELL
        public string TimeInForce { get; set; }         // Valid until the end of the day, until cancelled, fill or kill, etc.
        public double Qty { get; set; }                 // Order Quantity. How much we are going to trade now, e.g. 2
        public double Price { get; set; }               // Order price for limit orders
        public string OrderStatus { get; set; }         // Order Status: UNKNOWN, NEW, PARTIALLY FILLED, FILLED, CANCELLED, REJECTED, EXPIRED
        public string OrderText { get; set; }           // An explanation of order status especially when order rejected
        public MarketData MarketData { get; set; } = new MarketData();                                   // Market Data for an Order. Can be null
        public Dictionary<string, string> SystemValues { get; set; } = new Dictionary<string, string>(); // Reserverd for future usage. We don't know what additional parameters we will need 
    }
}
