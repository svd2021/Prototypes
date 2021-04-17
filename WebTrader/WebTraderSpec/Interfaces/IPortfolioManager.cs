using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraderSpec.Model;

namespace WebTraderSpec.Interfaces
{
    interface IPortfolioManager
    {
        //
        // Get a list of portfolio entries
        //
        List<PortfolioEntry> GetPortfolioEntries(string userName, string modelName, bool brokerPositions = false);  // Returns a list of current portfolio positions

        //
        // A list of transactions can be very long
        //
        long GetPortfolioTransactionsCount(string userName, string modelName);                                      
        List<PortfolioTransaction> GetPortfolioTransactions(string userName, string modelName, long startIndex = 0, long endIndex = Int64.MaxValue);  // Returns a list of portfolio transactions
    
        //
        // Portfolio position ajustment
        //
        void AmendPortfolioPositions(string userName, string modelName, List<PortfolioEntryAmendArgs> newValues);                                     // Adjust position in a case of corporate actions
    }
}
