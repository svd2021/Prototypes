using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraderSpec.Model
{
    public class OrderStatusUpdate
    {
        public string Id { get; set; }                  // Unique OrderID. Can be long, GUID or any sort of string
        public string OrderStatus { get; set; }         // Order Status: UNKNOWN, NEW, PARTIALLY FILLED, FILLED, CANCELLED, REJECTED, EXPIRED
        public string OrderText { get; set; }           // An explanation of order status especially when order rejected
        public MarketData MarketData { get; set; }      // Market Data for an Order. Can be null
        public Dictionary<string, string> SystemValues { get; set; } // Reserverd for future usage. We don't know what a
    }
}
