using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraderSpec.Model;

namespace WebTraderSpec
{
    public class TradingStrategyManagerServiceEmulator : ITradingStrategyManager
    {
        public async Task<IEnumerable<BasketTrade>> GetTradesAsync(string userName, string modelName, bool closeout = false)
        {
            return await Task.Run(() => 
            {
                List<BasketTrade> result = new List<BasketTrade>();
                result.Add(new BasketTrade() { Product = "APD US Equity_US_USD_USD", Ticker = "APD", MarketDescription = "", Exchange = "US", Currency = "USD", CurrentValue = 1, TradedValue = 3, WantedValue = 4, Price = 20.1, Index = "" });
                result.Add(new BasketTrade() { Product = "AXP US Equity_US_USD_USD", Ticker = "AXP", MarketDescription = "", Exchange = "US", Currency = "USD", CurrentValue = 3, TradedValue = 0, WantedValue = 3, Price = 69.34, Index = "" });
                result.Add(new BasketTrade() { Product = "APH US Equity_US_USD_USD", Ticker = "APH", MarketDescription = "", Exchange = "US", Currency = "USD", CurrentValue = 14, TradedValue = -5, WantedValue = 9, Price = 214.25, Index = "" });
                result.Add(new BasketTrade() { Product = "ADI US Equity_US_USD_USD", Ticker = "ADI", MarketDescription = "", Exchange = "US", Currency = "USD", CurrentValue = 12, TradedValue = -2, WantedValue = 10, Price = 32.76, Index = "" });
                result.Add(new BasketTrade() { Product = "AMA US Equity_US_USD_USD", Ticker = "AMA", MarketDescription = "", Exchange = "US", Currency = "USD", CurrentValue = 10, TradedValue = 10, WantedValue = 20, Price = 16.09, Index = "" });
                return result; 
            });
        }
    }
}