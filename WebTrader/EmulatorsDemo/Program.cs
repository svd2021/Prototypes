using System;

namespace EmulatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmulatorTests.TradingStrategyManagerServiceEmulatorTest().Wait();

            Console.WriteLine("Press <ENTER> to run Portfolio Tests...");
            Console.ReadLine();

            EmulatorTests.PortfolioManagerServiceEmulatorTest().Wait();

            Console.WriteLine("Press <ENTER> to run Execution Tests...");
            Console.ReadLine();

            EmulatorTests.ExecutionManagerServiceEmulatorTest().Wait();

            Console.WriteLine("Press <ENTER> to quit");
            Console.ReadLine();
        }

    }
}
