using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraderSpec.Model;

namespace WebTraderSpec.Interfaces
{
    public interface ITradingStrategyManager
    {
        List<BasketTrade> GetTrades(string userName, string modelName, bool closeout = false); // Receive a list of trades
    }
}
