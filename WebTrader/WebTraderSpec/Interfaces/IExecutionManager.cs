using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTraderSpec.Model;

namespace WebTraderSpec.Interfaces
{
    public interface IExecutionManager
    {
        //
        // Connection management 
        //
        // Tell the backend (buisiness logic) to connect/disconnect 
        //

        bool CreateAndConnectExecutionInterface(string userName, string modelName); // Connect to Exchange/Broker
        bool DisconnectExecutionInterface(string userName, string modelName);       // Disconnect
        bool IsExecutionInterfaceConnected(string userName, string modelName);      // Check, if execution interface connected

        //
        // Order generation
        //
        List<SingleOrder> GenerateOrders(string userName, string modelName, bool closeout = false);                  // Generate orders for a model. Business logic generates a set of orders and keep it until nexe generation

        //
        // Refresh orders/order statuses and market data
        //
        List<SingleOrder> GetOrders(string userName, string modelName);                                              // Get a list of previously generated ordes
        List<OrderStatusUpdate> GetOrderStatuses(string userName, string modelName);                                 // Refresh order statuses and Market data if present

        //
        // Order Execution
        //

        void ExecuteOrder(string userName, string modelName, OrderAmendArgs orderParams);                            // Execute a single order
        void ExecuteAllGenerated(string userName, string modelName, Dictionary<string, OrderAmendArgs> orderParams); // Execute all generated orders with ajusted values (if any)
        void CancelAllOrders(string userName, string modelName);                                                     // Cancel all orders sent to the market
    }
}
