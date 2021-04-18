using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebTraderSpec;
using WebTraderSpec.Model;

namespace EmulatorsDemo
{
    public class EmulatorTests
    {
        static string userName = "user1";
        static string modelName = "model1";

        public static async Task TradingStrategyManagerServiceEmulatorTest()
        {
            Console.WriteLine($"Trade tests.");
            
            TradingStrategyManagerServiceEmulator service = new WebTraderSpec.TradingStrategyManagerServiceEmulator();
            IEnumerable<BasketTrade> trades = await service.GetTradesAsync(userName, modelName);

            foreach (var trade in trades)
            {
                Console.WriteLine($"Product = {trade.Product}, Current value = {trade.CurrentValue}, Wanted Value = {trade.WantedValue}");
            }
            Console.WriteLine($"-----------");
        }

        public static async Task PortfolioManagerServiceEmulatorTest()
        {
            Console.WriteLine($"Portfolio tests.");
        
            PortfolioManagerServiceEmulator service = new PortfolioManagerServiceEmulator();
            var positions = await service.GetPortfolioEntriesAsync(userName, modelName, false);
            
            foreach (var item in positions)
            {
                Console.WriteLine($"Product = {item.Product}, Quantity = {item.Amount}, Price = {item.AvgPrice}");
            }

            Console.WriteLine($"-----------");
        }

        public static async Task ExecutionManagerServiceEmulatorTest()
        {
            Console.WriteLine($"Execution tests.");

            ExecutionManagerServiceEmulator service = new ExecutionManagerServiceEmulator();
            
            Console.WriteLine($"Generated Orders:");
            var orders = await service.GenerateOrdersAsync(userName, modelName, false);
            PrintOrders(orders);

            Console.WriteLine($"Execute...");

            Dictionary<string, OrderAmendArgs> orderParams = new Dictionary<string, OrderAmendArgs>();
            await service.ExecuteAllGeneratedAsync(userName, modelName, orderParams);

            orders = await service.GetOrdersAsync(userName, modelName);
            PrintOrders(orders);

            Console.WriteLine($"Cancel all orders...");
            await service.CancelAllOrdersAsync(userName, modelName);

            orders = await service.GetOrdersAsync(userName, modelName);
            PrintOrders(orders);

            Console.WriteLine($"-----------");
        }

        static void PrintOrders(IEnumerable<SingleOrder> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"Product = {order.Product}, Side = {order.Side}, Quantity = {order.Qty}, Price = {order.Price}, Status = {order.OrderStatus}");
            }
        }
    }
}
