using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTraderSpec.Model
{
    public class PortfolioEntryAmendArgs
    {
        public string Product { get; set; }             // Product ID, like MSFT_US_USD_USD
        public double Newqty { get; set; }              // New position quantity
    }
}
