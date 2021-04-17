using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraderSpec.Model
{
    public class OrderMarketDataUpdate
    {
        public string Id { get; set; }                  // Unique OrderID. Can be long, GUID or any sort of string
        public MarketData MarketData { get; set; }      // An order Market Data Update
    }
}
